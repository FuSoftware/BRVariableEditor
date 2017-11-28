using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace BRVariableEditor
{
    class PLC
    {
        WebClient c = new WebClient();
        private string Ext = "/goform/ReadWrite";
        public string IP { get; set; }
        public bool Connected { get; set; }

        private string testExt = "?redirect=sdm&variable=&read=Read PV";

        public string LastError { get; set; }

        public class Variable
        {
            string Data { get; set; }
            string Name { get; set; }

            public Variable(string name, string data)
            {
                this.Name = name;
                this.Data = data;
            }
        }

        public PLC(String IP = "")
        {
            this.IP = IP;
            this.Connected = false;
            this.LastError = "";
        }

        public bool Connect(string IP)
        {
            Ping ping = new Ping();
            this.LastError = "";
            this.Connected = false;

            if (!IP.StartsWith("http://"))
            {
                IP = "http://" + IP;
            }

            this.IP = IP;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(IP + Ext + testExt);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                    this.Connected = true;
                else
                    LastError = "Request returned " + response.StatusCode;
            }
            catch(Exception e)
            {
                LastError = IP + Ext + testExt + "\n\n" + e.ToString();
            }

            return this.Connected;
        }

        public string GetVariable(string variable)
        {
            this.LastError = "";

            string data = "?redirect={0}&variable={1}&read={2}";
            data = String.Format(data, "sdm", variable, "Read PV");

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(IP + Ext + data);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    NameValueCollection query = HttpUtility.ParseQueryString(response.ResponseUri.Query);
                    return query.Get("val");
                }
                else
                {
                    LastError = "Request returned " + response.StatusCode;
                }
                    
            }
            catch (Exception e)
            {
                LastError = e.Message;
            }

            return "";
        }

        public string SetVariable(string variable, string value)
        {

            this.LastError = "";

            string data = "?redirect={0}&variable={1}&value={2}&write={3}";
            data = String.Format(data, "sdm", variable, value, "Write PV");

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(IP + Ext + data);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    NameValueCollection query = HttpUtility.ParseQueryString(response.ResponseUri.Query);
                    return query.Get("val");
                }
                else
                {
                    LastError = "Request returned " + response.StatusCode;
                }

            }
            catch (Exception e)
            {
                LastError = e.Message;
            }

            return "";
        }

        public void SetVariables(string[] variables, string[] values)
        {
            for (int i =0; i<variables.Length;i++)
            {
                SetVariable(variables[i], values[i]);
            }
        }

        public void SetVariablesThread(string[] variables, string[] values)
        {
            int remaining = variables.Length;
            for (int i = 0; i < variables.Length; i++)
            {
                Thread t = new Thread(new ThreadStart(delegate {
                    SetVariable(variables[i], values[i]);
                    remaining--;
                }));
            }

            while (remaining > 0) ;

            return;
        }

        public string [] GetVariables(string [] variables)
        {
            string[] values = new string[variables.Length];

            for(int i=0; i<variables.Length;i++)
            {
                values[i] = GetVariable(variables[i]);
            }

            return values;
        }
    }
}

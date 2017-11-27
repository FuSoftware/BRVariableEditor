using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRVariableEditor
{
    public partial class MainForm : Form
    {
        PLC plc = new PLC();

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonVarRead_Click(object sender, EventArgs e)
        {
            if (textBoxVarName.Text != "")
            {
                string v = this.plc.GetVariable(textBoxVarName.Text);
                textBoxVarVal.Text = v;
            }
                
        }

        private void buttonVarWrite_Click(object sender, EventArgs e)
        {
            if (textBoxVarName.Text != "" && textBoxVarVal.Text != "")
            {
                string v = this.plc.SetVariable(textBoxVarName.Text, textBoxVarVal.Text);
                textBoxVarVal.Text = v;
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            this.plc.Connect(this.textBoxIP.Text);

            if(this.plc.Connected)
            {
                MessageBox.Show("Connected");
            }
            else
            {
                MessageBox.Show("Connection Failed \n\n" + this.plc.LastError);
            }
            
        }

        private void buttonArray_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for(int i=0;i<16;i++)
            {
                string variable = "WEB_TEST_ARRAY[" + i +"]";
                int value = r.Next(0, 100);
                plc.SetVariable(variable, value.ToString());
            }
        }
    }
}

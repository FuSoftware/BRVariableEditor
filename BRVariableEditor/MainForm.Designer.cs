namespace BRVariableEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxVarName = new System.Windows.Forms.TextBox();
            this.textBoxVarVal = new System.Windows.Forms.TextBox();
            this.buttonVarWrite = new System.Windows.Forms.Button();
            this.buttonVarRead = new System.Windows.Forms.Button();
            this.buttonArray = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(12, 12);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxIP.TabIndex = 0;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(13, 39);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(99, 23);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxVarName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxVarVal, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonVarWrite, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonVarRead, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // textBoxVarName
            // 
            this.textBoxVarName.Location = new System.Drawing.Point(3, 3);
            this.textBoxVarName.Name = "textBoxVarName";
            this.textBoxVarName.Size = new System.Drawing.Size(94, 20);
            this.textBoxVarName.TabIndex = 0;
            // 
            // textBoxVarVal
            // 
            this.textBoxVarVal.Location = new System.Drawing.Point(103, 3);
            this.textBoxVarVal.Name = "textBoxVarVal";
            this.textBoxVarVal.Size = new System.Drawing.Size(94, 20);
            this.textBoxVarVal.TabIndex = 1;
            // 
            // buttonVarWrite
            // 
            this.buttonVarWrite.Location = new System.Drawing.Point(103, 53);
            this.buttonVarWrite.Name = "buttonVarWrite";
            this.buttonVarWrite.Size = new System.Drawing.Size(75, 23);
            this.buttonVarWrite.TabIndex = 2;
            this.buttonVarWrite.Text = "Write";
            this.buttonVarWrite.UseVisualStyleBackColor = true;
            this.buttonVarWrite.Click += new System.EventHandler(this.buttonVarWrite_Click);
            // 
            // buttonVarRead
            // 
            this.buttonVarRead.Location = new System.Drawing.Point(3, 53);
            this.buttonVarRead.Name = "buttonVarRead";
            this.buttonVarRead.Size = new System.Drawing.Size(75, 23);
            this.buttonVarRead.TabIndex = 2;
            this.buttonVarRead.Text = "Read";
            this.buttonVarRead.UseVisualStyleBackColor = true;
            this.buttonVarRead.Click += new System.EventHandler(this.buttonVarRead_Click);
            // 
            // buttonArray
            // 
            this.buttonArray.Location = new System.Drawing.Point(16, 176);
            this.buttonArray.Name = "buttonArray";
            this.buttonArray.Size = new System.Drawing.Size(75, 23);
            this.buttonArray.TabIndex = 3;
            this.buttonArray.Text = "Array";
            this.buttonArray.UseVisualStyleBackColor = true;
            this.buttonArray.Click += new System.EventHandler(this.buttonArray_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.buttonArray);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBoxIP);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxVarName;
        private System.Windows.Forms.TextBox textBoxVarVal;
        private System.Windows.Forms.Button buttonVarWrite;
        private System.Windows.Forms.Button buttonVarRead;
        private System.Windows.Forms.Button buttonArray;
    }
}


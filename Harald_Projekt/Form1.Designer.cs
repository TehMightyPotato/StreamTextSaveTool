namespace Harald_Projekt
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.text1 = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.directoryText1 = new System.Windows.Forms.TextBox();
            this.browseButton1 = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.text2 = new System.Windows.Forms.TextBox();
            this.directoryText2 = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.TextBox();
            this.directoryText3 = new System.Windows.Forms.TextBox();
            this.browseButton2 = new System.Windows.Forms.Button();
            this.browseButton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(12, 12);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(264, 20);
            this.text1.TabIndex = 0;
            this.text1.Text = "Your Text Here";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(110, 185);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // directoryText1
            // 
            this.directoryText1.Location = new System.Drawing.Point(12, 38);
            this.directoryText1.Name = "directoryText1";
            this.directoryText1.Size = new System.Drawing.Size(182, 20);
            this.directoryText1.TabIndex = 5;
            this.directoryText1.Text = "C:\\StreamTextSaveTool\\output1.txt";
            // 
            // browseButton1
            // 
            this.browseButton1.Location = new System.Drawing.Point(200, 38);
            this.browseButton1.Name = "browseButton1";
            this.browseButton1.Size = new System.Drawing.Size(75, 23);
            this.browseButton1.TabIndex = 6;
            this.browseButton1.Text = "Browse";
            this.browseButton1.UseVisualStyleBackColor = true;
            this.browseButton1.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(12, 185);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(23, 23);
            this.helpButton.TabIndex = 7;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(12, 64);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(263, 20);
            this.text2.TabIndex = 8;
            this.text2.Text = "Your Text Here";
            // 
            // directoryText2
            // 
            this.directoryText2.Location = new System.Drawing.Point(13, 91);
            this.directoryText2.Name = "directoryText2";
            this.directoryText2.Size = new System.Drawing.Size(181, 20);
            this.directoryText2.TabIndex = 9;
            this.directoryText2.Text = "C:\\StreamTextSaveTool\\output2.txt";
            // 
            // text3
            // 
            this.text3.Location = new System.Drawing.Point(12, 118);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(263, 20);
            this.text3.TabIndex = 10;
            this.text3.Text = "Your Text Here";
            // 
            // directoryText3
            // 
            this.directoryText3.Location = new System.Drawing.Point(13, 145);
            this.directoryText3.Name = "directoryText3";
            this.directoryText3.Size = new System.Drawing.Size(181, 20);
            this.directoryText3.TabIndex = 11;
            this.directoryText3.Text = "C:\\StreamTextSaveTool\\output3.txt";
            // 
            // browseButton2
            // 
            this.browseButton2.Location = new System.Drawing.Point(201, 89);
            this.browseButton2.Name = "browseButton2";
            this.browseButton2.Size = new System.Drawing.Size(75, 23);
            this.browseButton2.TabIndex = 12;
            this.browseButton2.Text = "Browse";
            this.browseButton2.UseVisualStyleBackColor = true;
            this.browseButton2.Click += new System.EventHandler(this.browseButton2_Click);
            // 
            // browseButton3
            // 
            this.browseButton3.Location = new System.Drawing.Point(201, 145);
            this.browseButton3.Name = "browseButton3";
            this.browseButton3.Size = new System.Drawing.Size(75, 23);
            this.browseButton3.TabIndex = 13;
            this.browseButton3.Text = "Browse";
            this.browseButton3.UseVisualStyleBackColor = true;
            this.browseButton3.Click += new System.EventHandler(this.browseButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 221);
            this.Controls.Add(this.browseButton3);
            this.Controls.Add(this.browseButton2);
            this.Controls.Add(this.directoryText3);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.directoryText2);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.browseButton1);
            this.Controls.Add(this.directoryText1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.text1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "StreamTextSaveTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.TextBox directoryText1;
        private System.Windows.Forms.Button browseButton1;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox directoryText2;
        private System.Windows.Forms.TextBox text3;
        private System.Windows.Forms.TextBox directoryText3;
        private System.Windows.Forms.Button browseButton2;
        private System.Windows.Forms.Button browseButton3;
    }
}


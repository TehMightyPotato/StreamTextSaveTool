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
            this.team1 = new System.Windows.Forms.TextBox();
            this.team2 = new System.Windows.Forms.TextBox();
            this.team1score = new System.Windows.Forms.TextBox();
            this.team2score = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.directoryText = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // team1
            // 
            this.team1.Location = new System.Drawing.Point(12, 12);
            this.team1.Name = "team1";
            this.team1.Size = new System.Drawing.Size(100, 20);
            this.team1.TabIndex = 0;
            this.team1.Text = "Team 1";
            this.team1.TextChanged += new System.EventHandler(this.team1_TextChanged);
            // 
            // team2
            // 
            this.team2.Location = new System.Drawing.Point(176, 11);
            this.team2.Name = "team2";
            this.team2.Size = new System.Drawing.Size(100, 20);
            this.team2.TabIndex = 1;
            this.team2.Text = "Team 2";
            this.team2.TextChanged += new System.EventHandler(this.team2_TextChanged);
            // 
            // team1score
            // 
            this.team1score.Location = new System.Drawing.Point(12, 38);
            this.team1score.Name = "team1score";
            this.team1score.Size = new System.Drawing.Size(100, 20);
            this.team1score.TabIndex = 2;
            this.team1score.Text = "Score 1";
            // 
            // team2score
            // 
            this.team2score.Location = new System.Drawing.Point(176, 38);
            this.team2score.Name = "team2score";
            this.team2score.Size = new System.Drawing.Size(100, 20);
            this.team2score.TabIndex = 3;
            this.team2score.Text = "Score 2";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(111, 111);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // directoryText
            // 
            this.directoryText.Location = new System.Drawing.Point(13, 85);
            this.directoryText.Name = "directoryText";
            this.directoryText.Size = new System.Drawing.Size(182, 20);
            this.directoryText.TabIndex = 5;
            this.directoryText.Text = "C:\\StreamTextSaveTool\\output.txt";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(201, 82);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 6;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(12, 111);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(23, 23);
            this.helpButton.TabIndex = 7;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 143);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.directoryText);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.team2score);
            this.Controls.Add(this.team1score);
            this.Controls.Add(this.team2);
            this.Controls.Add(this.team1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "StreamTextSaveTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox team1;
        private System.Windows.Forms.TextBox team2;
        private System.Windows.Forms.TextBox team1score;
        private System.Windows.Forms.TextBox team2score;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.TextBox directoryText;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button helpButton;
    }
}


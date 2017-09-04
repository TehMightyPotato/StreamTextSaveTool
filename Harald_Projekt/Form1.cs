using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Harald_Projekt
{
    public partial class Form1 : Form
    {
        private TextBox Text1 { get; set; }
        private TextBox Text2 { get; set; }
        private TextBox Score1 { get; set; }
        private TextBox Score2 { get; set; }
        public Form1 form;
        
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (form == null)
            {
                form = Form.ActiveForm as Form1;
            }
            Text1 = form.team1;
            Text2 = form.team2;
            Score1 = form.team1score;
            Score2 = form.team2score;
            string stringToSave = Text1.Text + " " + Text2.Text + " " + Score1.Text + " " + Score2.Text;
            var savePath = form.directoryText.Text;
            try
            {
                File.WriteAllText(savePath, stringToSave);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message + "\r\nCode: " + exc.GetType().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void team1_TextChanged(object sender, EventArgs e)
        {

        }

        private void team2_TextChanged(object sender, EventArgs e)
        {

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (form == null)
            {
                form = Form.ActiveForm as Form1;
            }
            saveFile.Filter = "Text files(*.txt) | *.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                form.directoryText.Text = saveFile.FileName;
            }
            
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program saves the contents of the given textboxes following this scheme: \r\n'topLeft topRight bottomLeft bottomRight'\r\nThis programs intended use is to change text in .txt files than can be loaded by programs like OBS", "About", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}

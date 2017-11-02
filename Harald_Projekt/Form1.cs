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
        // #of pair #of box
        private TextBox Text11 { get; set; }
        private TextBox Text12{ get; set; }
        private TextBox Score11 { get; set; }
        private TextBox Score12 { get; set; }
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
            Text11 = form.team1;
            Text12 = form.team2;
            Score11 = form.team1score;
            Score12 = form.team2score;
            string stringToSave = Text11.Text + " " + Text12.Text + " " + Score11.Text + " " + Score12.Text;
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

        private void saveFile_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

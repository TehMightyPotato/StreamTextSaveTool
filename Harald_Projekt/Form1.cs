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
        private TextBox Text1 { get; set; }
        private TextBox Text2 { get; set; }
        private TextBox Text3 { get; set; }
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
            Text1 = form.text1;
            Text2 = form.text2;
            Text3 = form.text3;
            string stringToSave1 = Text1.Text;
            string stringToSave2 = Text2.Text;
            string stringToSave3 = Text3.Text;
            var savePath1 = form.directoryText1.Text;
            var savePath2 = form.directoryText2.Text;
            var savePath3 = form.directoryText3.Text;
            try
            {
                File.WriteAllText(savePath1, stringToSave1);
                File.WriteAllText(savePath2, stringToSave2);
                File.WriteAllText(savePath3, stringToSave3);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message + "\r\nCode: " + exc.GetType().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        //browse Button Methods called by event handler
        private void browseButton_Click(object sender, EventArgs e)
        {
            if (form == null)
            {
                form = Form.ActiveForm as Form1;
            }
            saveFile.Filter = "Text files(*.txt) | *.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                form.directoryText1.Text = saveFile.FileName;
            }
            
        }

        private void browseButton2_Click(object sender, EventArgs e)
        {
            if (form == null)
            {
                form = Form.ActiveForm as Form1;
            }
            saveFile.Filter = "Text files(*.txt) | *.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                form.directoryText2.Text = saveFile.FileName;
            }
        }

        private void browseButton3_Click(object sender, EventArgs e)
        {
            if (form == null)
            {
                form = Form.ActiveForm as Form1;
            }
            saveFile.Filter = "Text files(*.txt) | *.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                form.directoryText3.Text = saveFile.FileName;
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program saves the contents of the given textboxes. This programs intended use is to change text in .txt files than can be loaded by programs like OBS", "About", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void saveFile_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

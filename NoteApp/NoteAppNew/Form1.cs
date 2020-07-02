using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppNew
{
    public partial class Form1 : Form
    {

        CryptSave cryptSave = new CryptSave();
        Update UP = new Update();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //SAVE
        private void button1_Click(object sender, EventArgs e)
        {
            cryptSave.Save(textBox1.Text, cryptSave.TextPath, textBox2.Text);
        }
        //LOAD
        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(cryptSave.TextPath))
            {
                textBox1.Text = cryptSave.Decrypt(File.ReadAllText(cryptSave.TextPath), textBox2.Text);
            }

        }
        //CLEAR
        private void button3_Click(object sender, EventArgs e)
        {
            File.Delete(cryptSave.TextPath);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Update
        private void button4_Click(object sender, EventArgs e)
        {
            UP.Download();
        }
    }
}

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


namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Ati apasat pe butonul click ", "Info");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader("Elisei_Parola.txt", true);
            string line = string.Empty;

            while ((line = streamReader.ReadLine()) != null)
            {
                string[] temp = line.Split(' ');
                if (temp[0].ToString() == textBox1.Text && temp[1] == textBox2.Text)
                {
                    Form2 secondForm = new Form2(textBox1.Text);
                    secondForm.Show();
                }
            }

        }



        private void button1_Click_2(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader("Elisei_Parola.txt", true);
            string line = string.Empty;

            while ((line = streamReader.ReadLine()) != null)
            {
                string[] temp = line.Split(' ');
                if (temp[0].ToString() == textBox1.Text && temp[1] == textBox2.Text)
                {
                    Form2 secondForm = new Form2(textBox1.Text);
                    secondForm.Show();
                }
            }
        }
    }
}


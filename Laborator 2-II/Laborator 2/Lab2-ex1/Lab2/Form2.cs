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
    public partial class Form2 : Form
    {
        public Form2(string text)
        {
            InitializeComponent();
            //secondForm.Show();
            label1.Text = "Hello" + text;

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            ; // inchidem formularul curent 
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

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
using System.Collections;

namespace Lab2_ex2
{
    public partial class Form1 : Form
    {
        private List<string> obiecte = new List<string>();

        public Form1()
        {
            InitializeComponent();
            CitesteObiecteDinFisier();

        }
        private void CitesteObiecteDinFisier()
        {
            
            string[] linii = File.ReadAllLines("Obiecte.txt");
            obiecte.AddRange(linii);
            listBox1.Items.AddRange(obiecte.ToArray());
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            List<string> myStr = new List<string>();
            foreach (var item in listBox1.Items)
            {
                myStr.Add((string)item);
            }
            listBox2.Items.AddRange(myStr.ToArray());
            btn1.Click += new System.EventHandler(this.btn1_Click);
            //3listBox2.Items.Add(selectedItem);

        }

        private void b2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
           //
           // foreach (var item in listBox2.SelectedItems)
           // {
              //  listBox2.Items.Remove(item);
          //  }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

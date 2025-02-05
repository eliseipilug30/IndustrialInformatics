using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BazaDate;
using System.Data.SqlClien
using WebApplication;

namespace BazaDate
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Elisei\\Desktop\\An3\\Semestrul_2\\Informatica Industriala-Laboraror\\Tema2Lab4\\BazaDate\\Database1.mdf;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            LoadNames();
        }


        private void LoadNames()
        {
            WebService1 serviciu = new WebService1();
            List<string> listaNumeCarti = serviciu.AfiseazaToateCartile(connectionString);
            listBox1.DataSource = listaNumeCarti;
            listaNumeCarti.Insert(0, "Nume carte");


        }
        private void btnSterge_Click(object sender, EventArgs e)
        {
            string numeCarte = textNumeCarte.Text;


            WebService1 serviciu = new WebService1();
            serviciu.stergeCarte(numeCarte);

            MessageBox.Show("Cartea a fost ștearsă cu succes!");


            LoadNames();
        }

        private void btnadauga_Click(object sender, EventArgs e)
        {
            int id = textBoxId.Text;
            string numeCarte = textBoxNumeCarte.Text;
            string numeAutor = textBoxAutor.Text;
            string editura = textBoxEditura.Text;

            WebService1 serviciu = new WebService1();
            serviciu.adaugaCarte(id,numeCarte,numeAutor,editura);
            MessageBox.Show("Cartea a fost adaugata!");


            LoadNames();
        }

        private void btncauta_Click(object sender, EventArgs e)
        {
            string numeAutor = textBox2.Text;


            WebService1 serviciu = new WebService1();
            serviciu.cautaDupaAutor(numeAutor);

            LoadNames();
        }
    }
}

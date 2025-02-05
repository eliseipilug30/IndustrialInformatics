using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace lab3ex1
{
    public partial class Form1 : Form
    {
        SqlConnection myCon = new SqlConnection();
        DataSet dsUniv = new DataSet();
        DataSet dsFac = new DataSet();

        public Form1()
        {
            InitializeComponent();
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Elisei\Desktop\An3\Semestrul_2\Informatica Industriala Laboraror\Laborator 3-II\lab3ex1\Database1.mdf"";Integrated Security=True";
            myCon.Open();
            ListBox_Fill();
            //PopulateComboBox():
            //
            myCon.Close();
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }
        private void ListBox_Fill()
        {
            dsUniv.Clear();
            dsFac.Clear();
            listBox1.Items.Clear();

            SqlDataAdapter daUniv = new SqlDataAdapter("SELECT * FROM Universitati", myCon);
            daUniv.Fill(dsUniv, "Universitati");
            SqlDataAdapter daFac = new SqlDataAdapter("SELECT * FROM Facultati", myCon);
            daFac.Fill(dsFac, "Facultati");

            foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
            {
                String name = dr.ItemArray.GetValue(1).ToString();
                listBox1.Items.Add(name);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBox2.Items.Clear();
            textBoxOras.Clear();
            int code = 0;
            String UnivSelected = listBox1.SelectedItem.ToString();
            foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
            {
                if (UnivSelected == dr.ItemArray.GetValue(1).ToString())
                {


                    textBoxOras.Text = dr.ItemArray.GetValue(2).ToString();
                    code = Convert.ToInt16(dr.ItemArray.GetValue(3));
                    textBoxCodUniv.Text = code.ToString();
                }
            }

            foreach (DataRow dr in dsFac.Tables["Facultati"].Rows)
            {

                if (code == Convert.ToInt16(dr.ItemArray.GetValue(1)))
                {

                    String nameFac = dr.ItemArray.GetValue(2).ToString();
                    listBox2.Items.Add(nameFac);
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myCon.Open();
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Universitati(Id, NameUniv, City) VALUES (@Id,@NameUniv,@City)", myCon);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = int.Parse(textBoxID.Text);
                command.Parameters.Add("@NameUniv", SqlDbType.Text).Value = textBoxNumeUser.Text;
                command.Parameters.Add("@City", SqlDbType.Text).Value = textBoxOras.Text;
                command.ExecuteNonQuery();

                ListBox_Fill();
                textBoxID.Clear();
                textBoxNumeUser.Clear();
                textBoxOras.Clear();
                textBoxCodUniv.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            myCon.Close();
        }
        private void PopulateDataGridView()
        {
            SqlDataAdapter daFac1 = new SqlDataAdapter("SELECT * FROM Facultati", myCon);
            DataTable dtFac = new DataTable();
            daFac1.Fill(dtFac);
            dataGridView1.DataSource = dtFac;


        }
        private void PopulateComboBox()
        {
            SqlDataAdapter daUniv1 = new SqlDataAdapter("SELECT * FROM Universitati", myCon);
            DataTable dtUniv = new DataTable();
            daUniv1.Fill(dtUniv);
            Column2.ValueMember = "Code";
            Column2.DisplayMember = "NameUniv";
            DataRow topItem = dtUniv.NewRow();
            topItem[0] = 0;
            topItem[1] = "-SELECT-";
            dtUniv.Rows.InsertAt(topItem, 0);
            Column2.DataSource = dtUniv;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myCon.Open();
            try
            {
                SqlCommand command1 = new SqlCommand("SELECT COUNT(*) FROM Facultati WHERE Code = @Code", myCon);

                command1.Parameters.Add("@Code", SqlDbType.Int).Value = Convert.ToInt32(textBoxCodUniv.Text);


                int n = Convert.ToInt32(command1.ExecuteScalar());
                if (n == 0)
                {
                    SqlCommand command = new SqlCommand("DELETE FROM Universitati WHERE Code=@Code", myCon);
                    command.Parameters.Add("@Copde", SqlDbType.Int).Value = Convert.ToInt32(textBoxCodUniv.Text);
                    command.ExecuteNonQuery();

                    ListBox_Fill();
                    textBoxID.Clear();
                    textBoxNumeUser.Clear();
                    textBoxOras.Clear();
                    textBoxCodUniv.Clear();
                }
                else MessageBox.Show("Univ are facultati!Nu se poate efectua stergerea!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            myCon.Close();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["Column1"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Doriti sa stergeti linia?", "Stergere", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    myCon.Open();
                    SqlCommand sqlcom = new SqlCommand("DeleteFac", myCon);
                    sqlcom.CommandType = CommandType.StoredProcedure;
                    sqlcom.Parameters.AddWithValue("@Id", Convert.ToInt32(dataGridView1.CurrentRow.Cells["Column1"].Value));
                    sqlcom.ExecuteNonQuery();
                    myCon.Close();
                }
                else e.Cancel = true;
            }
            else e.Cancel = true;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                myCon.Open();
                DataGridViewRow row = dataGridView1.CurrentRow;
                if
                (row.Cells["Column1"].Value == DBNull.Value) //insert
                {
                    SqlCommand sqlcom1 = new SqlCommand("IhsertFac", myCon);
                    sqlcom1.CommandType = CommandType.StoredProcedure;
                    sqlcom1.Parameters.AddWithValue("@Code", Convert.ToInt32(row.Cells["Column2"].Value == DBNull.Value ?
            "1" : row.Cells["Column2"].Value.ToString()));
                    sqlcom1.Parameters.AddWithValue("@NameFac", row.Cells["Column3"].Value == DBNull.Value ?
                        "" : row.Cells["Column3"].Value.ToString());
                    sqlcom1.ExecuteNonQuery();
                    PopulateDataGridView();
                }
                myCon.Close();
            }
        }
    }
}

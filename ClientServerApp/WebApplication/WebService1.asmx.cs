using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Tema2Lab4
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Biblioteca;Integrated Security=True";

        [WebMethod]
        public List<string> AfiseazaToateCartile(string connectionString)
        {
            List<string> numeCarti = new List<string>();


            string query = "SELECT Nume_carte FROM Biblioteca";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();


                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            string numeCarte = reader["Nume_carte"].ToString();
                            numeCarti.Add(numeCarte);
                        }
                    }
                }
            }


            return numeCarti;
        }

        [WebMethod]
        public void AdaugaCarte(int Id, string Nume_carte, string Autor,  string Editura)
        {

            string query = "INSERT INTO Biblioteca (Id,Nume_carte,Autor,Editura) VALUES (@Id, @Nume_carte, @Autor,@Editura)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id",Id);
                command.Parameters.AddWithValue("@Nume_carte",Nume_carte);
                command.Parameters.AddWithValue("@Autor",Autor);
                command.Parameters.AddWithValue("@Editura",Editura);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        [WebMethod]
        public void stergeCarte(string numeCarte)
        {

            string query = "DELETE FROM Biblioteca WHERE Nume_carte = @Nume_carte";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nume_carte", numeCarte);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        [WebMethod]
        public List<string> cautaDupaAutor(string numeAutor)
        {
            List<string> numeCarti = new List<string>();

            string query = "SELECT * FROM Biblioteca WHERE Autor =@Autor";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();


                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            string numeCarte = reader["Nume_carte"].ToString();
                            numeCarti.Add(numeCarte);
                        }
                    }
                }
            }
            return numeCarti;
        }
    }

}

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace Quiz_Tema_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxNume.Text;
            string password = textBoxParola.Text;
            if (ValidateInput())
            {
                // Verifică dacă username și parola sunt corecte
                if (dateCorecte(username, password))
                {
                    MessageBox.Show("Autentificare reușită!");
                    if (checkBox1.Checked)
                    {
                        scriereFisier(username, password);
                    }
                    Form2 secondForm = new Form2(); ;
                    secondForm.Show();
                }
                else
                {
                    if (username != "Elisei")
                    {
                        MessageBox.Show("Nume de utilizator incorect");
                    }
                    else
                        if (password != "Pilug")
                    {

                        MessageBox.Show("Parola incorecta");
                    }
                }
            }

        }
        private bool dateCorecte(string username, string password)
        {
            if (username == "Elisei" && password == "Pilug")
            {
                return true;
            }
            return false;
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxNume.Text) || string.IsNullOrWhiteSpace(textBoxParola.Text))
            {
                MessageBox.Show("Introduceți numele de utilizator și parola.");
                return false;
            }
            return true;
        }
        private void scriereFisier(String userName, string password)
        {
            string caleFisierLogare = "Scriere.txt";

            // Scrierea datelor de logare în fișier 
            using (StreamWriter sw = new StreamWriter(caleFisierLogare, true))
            {

                string dataLogare = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                string dataLogareStr = "Data logare: " + dataLogare;
                string utilizatorStr = "Utilizator: " + userName;
                string parolaStr = "Parola: " + password;
                string linieDelimitatoare = "----------------";

                sw.WriteLine(dataLogareStr);
                sw.WriteLine(utilizatorStr);
                sw.WriteLine(parolaStr);
                sw.WriteLine(linieDelimitatoare);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}




    

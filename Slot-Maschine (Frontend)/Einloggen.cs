using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class Einloggen : Form
    {
        private string connetionString =
            "SERVER=localhost;" +
            "DATABASE=slot-maschine;" +
            "UID=a.wehn3008;" +
            "PASSWORD=sommerhutA1!;";

        public Einloggen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TheForm.ActiveForm.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrieren einloggen = new Registrieren();
            einloggen.Dock = DockStyle.Fill;
            einloggen.TopLevel = false;
            TheForm.ActiveForm.Controls.Clear();
            TheForm.ActiveForm.Controls.Add(einloggen);
            TheForm.ActiveForm.Size = einloggen.Size;
            einloggen.Show();
            einloggen.Focus();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if(AuthenticateUser(email, password))
            {
                MessageBox.Show("Login erfolgreich! Das Spiel wird gestartet.");
                this.Hide();
                //MainGameForm game = new MainGameForm();
                //game.Show();
            }
            else
            {
                MessageBox.Show("Falsche E-Mail oder falsches Passwort!", "Login fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string email, string password)
        {
            bool isAuthenticated = false;
            string query = "SELECT COUNT(*)FORM user WHERE email = @mail AND passwort = @passwort";

            using (MySqlConnection conn = new MySqlConnection(connetionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if(count > 0)
                        {
                            isAuthenticated = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler bei der Verbindung zur Datenbank: " + ex.Message);
                }

                return isAuthenticated;
            }
        }
    }
}

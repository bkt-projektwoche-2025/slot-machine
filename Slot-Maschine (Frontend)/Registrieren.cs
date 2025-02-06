using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class Registrieren : Form
    {

        private string connetionString =
            "SERVER=localhost;" +
            "DATABASE=slot-maschine;" +
            "UID=a.wehn3008;" +
            "PASSWORD=sommerhutA1!;";

        public Registrieren()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string Vorname = textBox2.Text;
            string Mail = textBox4.Text;
            string Passwort = textBox3.Text;
            string Geburtsdatum = dateTimePicker1.Text;

            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Vorname) || string.IsNullOrEmpty(Mail) || string.IsNullOrEmpty(Passwort) || string.IsNullOrEmpty(Geburtsdatum))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus, um sich zu registrieren!");
                return;
            }
            if(!IsValidEmail(Mail))
            {
                MessageBox.Show("Bitte geben Sie eine gültige E-Mail-Adresse ein!");
                return;
            }
            if(!IsValidPassword(Passwort))
            {
                MessageBox.Show("Das Passwort muss mindestens 8 Zeichen lang sein und mindestens einen Großbuchstaben, einen Kleinbuchstaben, eine Zahl und ein Sonderzeichen enthalten!");
                return;
            }
            if(!IsValidDateofBirth(DateTime.Parse(Geburtsdatum)))
            {
                MessageBox.Show("Sie müssen mindestens 18 Jahre alt sein, um sich zu registrieren!");
                return;
            }
            else
            {
                MySqlConnection connection = new MySqlConnection(connetionString);
                connection.Open();
                connection.Close();
                //MessageBox.Show("Registrierung erfolgreich!");
            }

            string hashedPasswort = BCrypt.Net.BCrypt.HashPassword(Passwort);

            using (MySqlConnection conn = new MySqlConnection(connetionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO user (Name, Vorname, Mail, Passwort, Geburtsdatum) VALUES (@Name, @Vorname, @Mail, @Passwort, @Geburtsdatum)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@Vorname", Vorname);
                        cmd.Parameters.AddWithValue("@Mail", Mail);
                        cmd.Parameters.AddWithValue("@Passwort", hashedPasswort);
                        cmd.Parameters.AddWithValue("@Geburtsdatum", Geburtsdatum);

                        //MessageBox.Show("SQL wird ausgeführt...", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        //MessageBox.Show("Datensätze eingefügt: " + rowsAffected);
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registrierung erfolgreich!");
                            // Eingabefelder zurücksetzen
                            textBox1.Text = string.Empty;
                            textBox2.Text = string.Empty;
                            textBox3.Text = string.Empty;
                            textBox4.Text = string.Empty;
                            dateTimePicker1.Value = DateTime.Now;
                        }
                        else
                        {
                            MessageBox.Show("Registrierung fehlgeschlagen!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler: " + ex.Message, "Datenbankfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPassword(string password)
        {
            if(password.Length < 8) return false;
            if(!password.Any(char.IsUpper)) return false;
            if (!password.Any(char.IsLower)) return false;
            if (!password.Any(char.IsDigit)) return false;
            if(!password.Any(ch => !char.IsLetterOrDigit(ch))) return false;
            return true;
        }

        private bool IsValidDateofBirth(DateTime date)
        {
            int age = DateTime.Now.Year - date.Year;
            if (DateTime.Now.DayOfYear < date.DayOfYear)
                age--;
            return age >= 18;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TheForm.ActiveForm.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Einloggen einloggen = new Einloggen();
            einloggen.Dock = DockStyle.Fill;
            einloggen.TopLevel = false;
            TheForm.ActiveForm.Controls.Clear();
            TheForm.ActiveForm.Controls.Add(einloggen);
            TheForm.ActiveForm.Size = einloggen.Size;
            einloggen.Show();
            einloggen.Focus();
        }
    }
}

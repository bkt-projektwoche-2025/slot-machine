using Frontend;
using Slot_Machine;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Registrieren : Form
    {
        public int user_id;
        public Registrieren()
        {
            InitializeComponent();
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

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (Email.Text == "" || Password.Text == "" || PasswortWiederholung.Text == "" || Vorname.Text == ""||_Name.Text=="")
            {
                InfoBox.ForeColor = Color.Red;
                InfoBox.Text = "Etwas fehlt.";
                return;
            }
            else
            {
                if ((DateTime.Now-GebDat.Value).TotalDays > 6575)
                {
                    if (new EmailAddressAttribute().IsValid(Email.Text) && Password.Text == PasswortWiederholung.Text)
                    {
                        if (password_IsValid(Password.Text))
                        {
                            InfoBox.ForeColor = SystemColors.Control;
                            new DataHandler().register(_Name.Text, Vorname.Text, Email.Text, Password.Text, GebDat.Text, InfoBox, this);
                        } else
                        {
                            InfoBox.ForeColor = Color.Red;
                            InfoBox.Text = "Passwort ungültig.";
                        }
                    }
                    else if (new EmailAddressAttribute().IsValid(Email.Text)) {
                        InfoBox.ForeColor = Color.Red;
                        InfoBox.Text = "Passworteingabe stimmt nicht.";
                    }
                    else
                    {
                        InfoBox.ForeColor = Color.Red;
                        InfoBox.Text = "Email ungültig.";
                    }
                } else
                {
                    InfoBox.ForeColor = Color.Red;
                    InfoBox.Text = "Alter ungültig.";
                }

            }
        }

        private void InfoBox_Textchanged(object sender, EventArgs e) {
            if (InfoBox.Text == "Erfolg!")
            {
                if (user_id == 0) MessageBox.Show("Etwas ist fehlerhaft.");
                Spielfeld Spiel = new Spielfeld() { 
                    user_id = user_id
                };
                new DataHandler().create_session(Spiel);
                Spiel.Dock = DockStyle.Fill;
                Spiel.TopLevel = false;
                TheForm.ActiveForm.Controls.Clear();
                TheForm.ActiveForm.Controls.Add(Spiel);
                TheForm.ActiveForm.Size = Spiel.Size;
                Spiel.Show();
                Spiel.Focus();

            }
            else return;
        }

        private bool password_IsValid(string password)
        {
            //regex für Passwort-Format-Übereintimmung |   AbisZ       abisz       zahl        Zeichen     Anzahl von Characters
            Regex validateGuidRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#,.?!@$%^&*_-]).{8,255}$");
            return validateGuidRegex.IsMatch(password);

        }
    }
}

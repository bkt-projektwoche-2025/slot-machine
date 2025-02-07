using Frontend;
using Slot_Machine;
using System.ComponentModel.DataAnnotations;

namespace WinFormsApp1
{
    public partial class Einloggen : Form
    {
        public int user_id;
        public Einloggen()
        {
            InitializeComponent();
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
            if(Email.Text==""||Password.Text=="")
            {
                Infobox.ForeColor = Color.Red;
                Infobox.Text = "Etwas fehlt.";
                return;
            }
            else
            {
                if (new EmailAddressAttribute().IsValid(Email.Text))
                {
                    Infobox.ForeColor = SystemColors.Control;
                    new DataHandler().login(Email.Text, Password.Text, Infobox, this);
                }
                else
                {
                    Infobox.ForeColor = Color.Red;
                    Infobox.Text = "Email ungültig.";
                }
            }
        }
        private void InfoBox_TextChanged(object sender, EventArgs e)
        {
            if (Infobox.Text == "Erfolg!")
            {
                
                if (user_id == 0) MessageBox.Show("Etwas ist fehlerhaft.");
                Spielfeld Spiel = new Spielfeld() {
                    user_id = user_id
                };
                DataHandler datahandler = new DataHandler();
                datahandler.create_session(Spiel);
                    //datahandler.load_data(Spiel);
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
    }
}

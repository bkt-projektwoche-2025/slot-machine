using Frontend;
using Slot_Machine;
using System.ComponentModel.DataAnnotations;

namespace WinFormsApp1
{
    public partial class Einloggen : Form
    {
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
                label2.ForeColor = Color.Red;
                label2.Text = "Etwas fehlt.";
                return;
            }
            else
            {
                if (new EmailAddressAttribute().IsValid(Email.Text))
                {
                    label2.ForeColor = SystemColors.Control;
                    new DataHandler().login(Email.Text, Password.Text, label2);


                    if(label2.Text=="Erfolg!")
                    {
                        Form1 Spiel = new Form1();
                        Spiel.Dock = DockStyle.Fill;
                        Spiel.TopLevel = false;
                        TheForm.ActiveForm.Controls.Clear();
                        TheForm.ActiveForm.Controls.Add(Spiel);
                        TheForm.ActiveForm.Size = Spiel.Size;
                        Spiel.Show();
                        Spiel.Focus();
                    }
                }
                else
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Email ungültig.";
                }
                
            }
        }
    }
}

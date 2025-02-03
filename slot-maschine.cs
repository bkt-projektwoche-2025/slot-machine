using System;
using System.Windows.Forms;

namespace SlotMaschine
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private string[] symbols = { "🍒", "🔔", "⭐", "💎", "🍋" };
        private int guthaben = 100;

        public Form1()
        {
            InitializeComponent();
            lblGuthaben.Text = $"Guthaben: {guthaben}€";
        }

        private void btnDrehen_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEinsatz.Text, out int einsatz) || einsatz <= 0 || einsatz > guthaben)
            {
                MessageBox.Show("Ungültiger Einsatz!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            guthaben -= einsatz;
            lblGuthaben.Text = $"Guthaben: {guthaben}€";

            // Zufällige Symbole auswählen
            lblSlot1.Text = symbols[random.Next(symbols.Length)];
            lblSlot2.Text = symbols[random.Next(symbols.Length)];
            lblSlot3.Text = symbols[random.Next(symbols.Length)];

            // Gewinn überprüfen
            if (lblSlot1.Text == lblSlot2.Text && lblSlot2.Text == lblSlot3.Text)
            {
                int gewinn = einsatz * 5;
                guthaben += gewinn;
                lblGuthaben.Text = $"Guthaben: {guthaben}€";
                MessageBox.Show($"🎉 JACKPOT! Du gewinnst {gewinn}€! 🎉", "Gewinn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Spielende prüfen
            if (guthaben <= 0)
            {
                MessageBox.Show("Du hast kein Guthaben mehr. Spiel beendet.", "Spielende", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnDrehen.Enabled = false;
            }
        }
    }
}

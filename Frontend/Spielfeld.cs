using System;               //Basis-Bibliothek von .NET
using System.Windows.Forms; //Um die Windows Forms und Steuerelemente wie Buttons, Labels etc. zu nutzen
using System.Drawing;       //Für Grafikoperationen, z.B. das Setzen von Bildern
using Microsoft.VisualBasic;
using WinFormsApp1;
using Frontend; //Ermöglicht den Zugriff auf Funktionen aus der Visual Basic-Bibliothek (z.B. VBMath.Rnd())


namespace Slot_Machine
{

    //Definition der Form (Hauptfenster) der Slot-Maschine
    public partial class Spielfeld : Form
    {
        //Variablen für die Slot-Maschine
        int m;            //Zeitgeber-Marker (Steuert den Timer)
        int a, b, c;      //Zufällige Werte für die 3 Walzen
        public int guthaben = 100;   //Startguthaben
        public int einsatz = 10;  //Anfangseinsatz
        public int user_id; //user user_id
        public string session_token; //session user_id
        //Konstruktor der Form, in dem die initialen Einstellungen vorgenommen werden
        public Spielfeld()
        {
            InitializeComponent(); //Initialisiert alle Formularelemente

            //Deaktiviert die Schaltflächen zu Beginn
            Button1.Enabled = false;
            button5.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;


        }

        //Startet das Spiel
        private void Button1_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;   //Deaktiviert den Button für Einsatz erhöhen
            button7.Enabled = false;   //Deaktiviert den Button für Einsatz verringern
            button9.Enabled = false;   //Deaktiviert den Button für Spiel Neustart
            button8.Enabled = true;    //Aktiviert den Button zum Spiel beenden
            timer1.Enabled = true;     //Startet den Timer
            timer1.Interval = 50;      //Setzt das Intervall des Timers auf 50ms
            
        }

        //Initialisierung der Form, Timer ist zunächst deaktiviert
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false; //Timer ist zu Beginn nicht aktiv

        }

        //Tick-Ereignis des Timers, das regelmäßig ausgelöst wird, um die Walzen zu drehen
        private void timer1_Tick(object sender, EventArgs e)
        {
            m = m + 10;  //Erhöht den Timer-Wert

            if (m < 100)  //Wenn der Timerwert kleiner als 100ms ist, zeigen wir weiter die Walzenbilder
            {
                //Zufällige Werte für jede Walze generieren
                a = (int)(Conversion.Int(1 + VBMath.Rnd() * 3));
                b = (int)(Conversion.Int(1 + VBMath.Rnd() * 3));
                c = (int)(Conversion.Int(1 + VBMath.Rnd() * 3));

                string bildPfadwa = System.IO.Path.Combine(Application.StartupPath, "wassermelone.png");
                string bildPfadwe = System.IO.Path.Combine(Application.StartupPath, "wientrauben.png");
                string bildPfadsi = System.IO.Path.Combine(Application.StartupPath, "sieben.png");
                //Walzenbilder basierend auf den zufälligen Zahlen setzen
                switch (a)
                {
                    case 1:
                        PictureBox1.Image = Frontend.Properties.Resources.wassermelone;
                        break;
                    case 2:
                        PictureBox1.Image = Frontend.Properties.Resources.weintrauben;
                        break;
                    case 3:
                        PictureBox1.Image = Frontend.Properties.Resources.sieben;
                        break;
                }

                switch (b)
                {
                    case 1:
                        PictureBox2.Image = Frontend.Properties.Resources.wassermelone;
                        break;
                    case 2:
                        PictureBox2.Image = Frontend.Properties.Resources.weintrauben;
                        break;
                    case 3:
                        PictureBox2.Image = Frontend.Properties.Resources.sieben;
                        break;
                }

                switch (c)
                {
                    case 1:
                        PictureBox3.Image = Frontend.Properties.Resources.wassermelone;
                        break;
                    case 2:
                        PictureBox3.Image = Frontend.Properties.Resources.weintrauben;
                        break;
                    case 3:
                        PictureBox3.Image = Frontend.Properties.Resources.sieben;
                        break;
                }
            }
            else  //Wenn der Timerwert 100ms erreicht, wird das Spiel ausgewertet
            {
                timer1.Enabled = false;  //Stoppt den Timer
                m = 0;  //Setzt den Timer zurück

                //Wenn alle Walzen das gleiche Symbol haben, gibt es einen Jackpot
                if ((a == b) && (a == c))
                {
                    lblMsg.Text = "Jackpot! Du hast " + (8 * einsatz).ToString() + "€ gewonnen!!!";
                    guthaben = guthaben + (8 * einsatz);  //Erhöht das Guthaben um den achtfachen Einsatz
                    infolbl.Text = "Guthaben: " + guthaben.ToString() + "€"; //Aktualisiert das Guthaben
                }
                else  //Wenn keine Übereinstimmung besteht, verliert der Spieler den Einsatz
                {
                    lblMsg.Text = "Kein Glück, versuche es erneut!";
                    guthaben = guthaben - einsatz; //Zieht den Einsatz vom Guthaben ab
                    infolbl.Text = "Guthaben: " + guthaben.ToString() + "€"; //Aktualisiert das Guthaben
                    if (guthaben < einsatz)  //Wenn nicht genügend Guthaben für den nächsten Einsatz vorhanden ist, wird der Start-Button deaktiviert
                    {
                        Button1.Enabled = false;
                    }
                    if (guthaben == 0)  //Wenn das Guthaben 0 ist, wird der Neustart-Button aktiviert
                    {
                        button2.Enabled = true;
                        button8.Enabled = false;
                        button5.Enabled = false;
                    }
                }

                new DataHandler().add_data(user_id, session_token, a, b, c, einsatz, ((a == b && b == c) ? 8 * einsatz : 0), guthaben, this);//Daten speichern.

            }
        }

        //Button zum Neustarten des Spiels (Startguthaben auf 50 setzen)
        private void button2_Click(object sender, EventArgs e)
        {
            guthaben = 100;
            infolbl.Text = "Guthaben: " + "100€";
            button3.Enabled = true;
            button9.Enabled = true;
            button2.Enabled = false;
        }

        //Button zum Erhöhen des Guthabens
        private void button3_Click(object sender, EventArgs e)
        {
            guthaben += 50;  //Guthaben wird um 50 erhöht
            infolbl.Text = "Guthaben: " + guthaben.ToString() + "€"; //Aktualisiert die Anzeige des Guthabens
            button9.Enabled = true;
            button4.Enabled = true;
        }

        //Button zum Verringern des Guthabens
        private void button4_Click(object sender, EventArgs e)
        {
            if ((guthaben > 0) && (einsatz < guthaben)) guthaben -= 50; //Guthaben verringern, wenn ausreichend vorhanden
            if (guthaben >= 0)
                infolbl.Text = "Guthaben: " + guthaben.ToString() + "€"; //Zeigt das neue Guthaben an
            if (guthaben == 0)  //Wenn Guthaben aufgebraucht, deaktiviert den Spielstart-Button
            {
                Button1.Enabled = false;
                button9.Enabled = false;
            }
            if (guthaben == 50) button4.Enabled = false;  //Wenn das Guthaben 50 erreicht, wird der "weniger setzen"-Button deaktiviert
        }

        //Button zum Setzen des Einsatzes
        private void button5_Click(object sender, EventArgs e)
        {
            if ((einsatz <= guthaben) && (einsatz > 0)) Button1.Enabled = true;  //Aktiviert den Start-Button, wenn der Einsatz gültig ist
            button6.Enabled = true;  //Aktiviert den Button zum Erhöhen des Einsatzes
            button7.Enabled = true;  //Aktiviert den Button zum Verringern des Einsatzes
            betlbl.Text = "Einsatz: " + einsatz.ToString() + "€";  //Zeigt den aktuellen Einsatz an
        }

        //Button zum Verringern des Einsatzes
        private void button7_Click(object sender, EventArgs e)
        {
            if (einsatz > 0) einsatz -= 10;  //Verringert den Einsatz um 10
            if (einsatz <= guthaben) Button1.Enabled = true; //Aktiviert den Start-Button, wenn der Einsatz gültig ist
            betlbl.Text = "Einsatz: " + einsatz.ToString() + "€";  //Zeigt den aktuellen Einsatz an
            if (einsatz == 0)  // Wenn der Einsatz 0 erreicht, wird der Start-Button deaktiviert
            {
                Button1.Enabled = false;
                button7.Enabled = false;
            }
        }

        // Button zum Erhöhen des Einsatzes
        private void button6_Click(object sender, EventArgs e)
        {
            if (einsatz < guthaben)  // Erhöht den Einsatz, wenn noch genug Guthaben vorhanden ist
            {
                Button1.Enabled = true;
                einsatz += 10;
                betlbl.Text = "Einsatz: " + einsatz.ToString() + "€";  // Zeigt den neuen Einsatz an
            }
            button7.Enabled = true;  // Aktiviert den Button zum Verringern des Einsatzes
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Regeln neueForm = new Regeln(); // Erstellt eine neue Instanz von Form2
            neueForm.Show();  // Zeigt Form2 an (ohne Spielfeld zu schließen)
        }

        // Button zum Abbrechen des Spiels und Neuanfang
        private void button9_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button9.Enabled = false;
            button5.Enabled = true;
        }

        // Button zum Beenden des Spiels und Bestätigung des Spiels
        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Danke fürs spielen!\nMöchtest du nochmal spielen?", "Spielende", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)  // Wenn "Ja" gewählt wird, startet das Spiel neu
            {
                Button1.Enabled = false;
                button5.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button9.Enabled = false;
                button8.Enabled = false;
                button2.Enabled = true;
                guthaben = 100;
                einsatz = 50;
                infolbl.Text = "Guthaben: ";
                betlbl.Text = "Einsatz: ";
                lblMsg.Text = "";
            }
            else {
                new DataHandler().delete_session(user_id, session_token);
                exit();
                return;
            }
            // Wenn "Nein" gewählt wird, schließt sich das Spiel
        }
        public void run_message(string msg)
        {
            MessageBox.Show(msg);
        }
        public void exit()
        {
            Application.Exit();
        }
        public void Form1_FormClosing(object sender, EventArgs e)
        {
            new DataHandler().delete_session(user_id, session_token);
            Application.Exit();
            TheForm.ActiveForm.Close();

        }
    }
}

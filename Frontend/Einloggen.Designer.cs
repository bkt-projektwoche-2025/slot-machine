namespace WinFormsApp1
{
    partial class Einloggen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            LoginButton = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginLabel.Location = new Point(270, 125);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(268, 50);
            LoginLabel.TabIndex = 0;
            LoginLabel.Text = "Slot-Maschine";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(270, 247);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "E-Mail";
            textBox1.Size = new Size(268, 34);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(270, 298);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '•';
            textBox2.PlaceholderText = "Passwort";
            textBox2.Size = new Size(268, 34);
            textBox2.TabIndex = 2;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.White;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButton.Location = new Point(270, 428);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(268, 46);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Anmelden";
            LoginButton.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(270, 485);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(115, 28);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registrieren";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.Location = new Point(434, 485);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(104, 28);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Schließen?";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // Einloggen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(LoginButton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(LoginLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Einloggen";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoginLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button LoginButton;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}

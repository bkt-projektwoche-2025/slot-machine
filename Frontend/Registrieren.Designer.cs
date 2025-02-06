namespace WinFormsApp1
{
    partial class Registrieren : Form
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
            _Name = new TextBox();
            Vorname = new TextBox();
            RegisterButton = new Button();
            Einloggen = new LinkLabel();
            Schließen = new LinkLabel();
            Password = new TextBox();
            Email = new TextBox();
            GebDat = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            PasswortWiederholung = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginLabel.Location = new Point(270, 80);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(268, 50);
            LoginLabel.TabIndex = 0;
            LoginLabel.Text = "Slot-Maschine";
            // 
            // _Name
            // 
            _Name.BorderStyle = BorderStyle.FixedSingle;
            _Name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _Name.Location = new Point(270, 154);
            _Name.Name = "_Name";
            _Name.PlaceholderText = "Name";
            _Name.Size = new Size(268, 34);
            _Name.TabIndex = 1;
            _Name.TextAlign = HorizontalAlignment.Center;
            // 
            // Vorname
            // 
            Vorname.BorderStyle = BorderStyle.FixedSingle;
            Vorname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Vorname.Location = new Point(270, 198);
            Vorname.Name = "Vorname";
            Vorname.PlaceholderText = "Vorname";
            Vorname.Size = new Size(268, 34);
            Vorname.TabIndex = 2;
            Vorname.TextAlign = HorizontalAlignment.Center;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.White;
            RegisterButton.FlatAppearance.BorderSize = 0;
            RegisterButton.FlatStyle = FlatStyle.Flat;
            RegisterButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegisterButton.Location = new Point(270, 448);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(268, 46);
            RegisterButton.TabIndex = 9;
            RegisterButton.Text = "Registrieren";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // Einloggen
            // 
            Einloggen.AutoSize = true;
            Einloggen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Einloggen.Location = new Point(270, 504);
            Einloggen.Name = "Einloggen";
            Einloggen.Size = new Size(100, 28);
            Einloggen.TabIndex = 10;
            Einloggen.TabStop = true;
            Einloggen.Text = "Einloggen";
            Einloggen.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Schließen
            // 
            Schließen.AutoSize = true;
            Schließen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Schließen.Location = new Point(434, 504);
            Schließen.Name = "Schließen";
            Schließen.Size = new Size(104, 28);
            Schließen.TabIndex = 11;
            Schließen.TabStop = true;
            Schließen.Text = "Schließen?";
            Schließen.LinkClicked += linkLabel2_LinkClicked;
            // 
            // Password
            // 
            Password.BorderStyle = BorderStyle.FixedSingle;
            Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.Location = new Point(270, 286);
            Password.Name = "Password";
            Password.PasswordChar = '•';
            Password.PlaceholderText = "Password";
            Password.Size = new Size(268, 34);
            Password.TabIndex = 4;
            Password.TextAlign = HorizontalAlignment.Center;
            // 
            // Email
            // 
            Email.BorderStyle = BorderStyle.FixedSingle;
            Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Email.Location = new Point(270, 244);
            Email.Name = "Email";
            Email.PlaceholderText = "E-Mail";
            Email.Size = new Size(268, 34);
            Email.TabIndex = 3;
            Email.TextAlign = HorizontalAlignment.Center;
            // 
            // GebDat
            // 
            GebDat.CustomFormat = "yyyy-MM-dd";
            GebDat.Font = new Font("Segoe UI", 12F);
            GebDat.Format = DateTimePickerFormat.Custom;
            GebDat.Location = new Point(270, 371);
            GebDat.Name = "GebDat";
            GebDat.Size = new Size(268, 34);
            GebDat.TabIndex = 6;
            GebDat.Value = new DateTime(2000, 1, 1, 12, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 162);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 11;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 205);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 12;
            label2.Text = "Vorname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, 251);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 13;
            label3.Text = "E-Mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(195, 293);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 14;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(156, 378);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 15;
            label5.Text = "Geburtsdatum:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(96, 334);
            label6.Name = "label6";
            label6.Size = new Size(171, 20);
            label6.TabIndex = 17;
            label6.Text = "Wiederholung Password:";
            // 
            // PasswortWiederholung
            // 
            PasswortWiederholung.BorderStyle = BorderStyle.FixedSingle;
            PasswortWiederholung.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswortWiederholung.Location = new Point(270, 327);
            PasswortWiederholung.Name = "PasswortWiederholung";
            PasswortWiederholung.PasswordChar = '•';
            PasswortWiederholung.PlaceholderText = "Wiederholung";
            PasswortWiederholung.Size = new Size(268, 34);
            PasswortWiederholung.TabIndex = 5;
            PasswortWiederholung.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(12, 417);
            label7.Name = "label7";
            label7.Size = new Size(776, 20);
            label7.TabIndex = 18;
            label7.Text = "Bitte geben Sie sorgfältig an.";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // Registrieren
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(PasswortWiederholung);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GebDat);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(Schließen);
            Controls.Add(Einloggen);
            Controls.Add(RegisterButton);
            Controls.Add(Vorname);
            Controls.Add(_Name);
            Controls.Add(LoginLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registrieren";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoginLabel;
        private TextBox _Name;
        private TextBox Vorname;
        private Button RegisterButton;
        private LinkLabel Einloggen;
        private LinkLabel Schließen;
        private TextBox Password;
        private TextBox Email;
        private DateTimePicker GebDat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox PasswortWiederholung;
        private Label label7;
    }
}

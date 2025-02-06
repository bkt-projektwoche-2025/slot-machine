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
            Email = new TextBox();
            Password = new TextBox();
            LoginButton = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label2 = new Label();
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
            // Email
            // 
            Email.BorderStyle = BorderStyle.FixedSingle;
            Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Email.Location = new Point(270, 228);
            Email.Name = "Email";
            Email.PlaceholderText = "E-Mail";
            Email.Size = new Size(268, 34);
            Email.TabIndex = 1;
            Email.TextAlign = HorizontalAlignment.Center;
            // 
            // Password
            // 
            Password.BorderStyle = BorderStyle.FixedSingle;
            Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.Location = new Point(270, 276);
            Password.Name = "Password";
            Password.PasswordChar = '•';
            Password.PlaceholderText = "Password";
            Password.Size = new Size(268, 34);
            Password.TabIndex = 2;
            Password.TextAlign = HorizontalAlignment.Center;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.White;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButton.Location = new Point(270, 448);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(268, 46);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Anmelden";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(270, 505);
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
            linkLabel2.Location = new Point(434, 505);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(104, 28);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Schließen?";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label2
            // 
            label2.Location = new Point(270, 416);
            label2.Name = "label2";
            label2.Size = new Size(268, 20);
            label2.TabIndex = 8;
            label2.Text = "Bitte melden Sie sorgfältig an.";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Einloggen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(label2);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(LoginButton);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(LoginLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Einloggen";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoginLabel;
        private TextBox Email;
        private TextBox Password;
        private Button LoginButton;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Label label2;
    }
}

namespace WinFormsApp1
{
    partial class Registrieren
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
            textBox3 = new TextBox();
            textBox4 = new TextBox();
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
            textBox1.Location = new Point(270, 215);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 34);
            textBox1.TabIndex = 1;
            textBox1.Text = "Name";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(270, 259);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(268, 34);
            textBox2.TabIndex = 2;
            textBox2.Text = "Vorname";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.White;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButton.Location = new Point(270, 408);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(268, 46);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Registrieren";
            LoginButton.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(270, 464);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(109, 28);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Einloggen?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.Location = new Point(434, 464);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(104, 28);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Schließen?";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(270, 345);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(268, 34);
            textBox3.TabIndex = 9;
            textBox3.Text = "Passwort";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(270, 303);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(268, 34);
            textBox4.TabIndex = 8;
            textBox4.Text = "E-Mail";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // Registrieren
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(LoginButton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(LoginLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registrieren";
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
        private TextBox textBox3;
        private TextBox textBox4;
    }
}

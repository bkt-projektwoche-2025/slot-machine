namespace Slot_Machine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Button1 = new Button();
            PictureBox3 = new PictureBox();
            PictureBox2 = new PictureBox();
            PictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lblMsg = new Label();
            infolbl = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            betlbl = new Label();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button9 = new Button();
            button8 = new Button();
            button10 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)PictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.BackColor = Color.White;
            Button1.FlatAppearance.BorderSize = 0;
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button1.Location = new Point(395, 491);
            Button1.Margin = new Padding(4, 5, 4, 5);
            Button1.Name = "Button1";
            Button1.Size = new Size(240, 148);
            Button1.TabIndex = 7;
            Button1.Text = "DREHEN";
            Button1.UseVisualStyleBackColor = false;
            Button1.Click += Button1_Click;
            // 
            // PictureBox3
            // 
            PictureBox3.BackColor = Color.White;
            PictureBox3.Image = Frontend.Properties.Resources.sieben;
            PictureBox3.Location = new Point(641, 150);
            PictureBox3.Margin = new Padding(4, 5, 4, 5);
            PictureBox3.Name = "PictureBox3";
            PictureBox3.Size = new Size(133, 274);
            PictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox3.TabIndex = 6;
            PictureBox3.TabStop = false;
            // 
            // PictureBox2
            // 
            PictureBox2.BackColor = Color.White;
            PictureBox2.Image = Frontend.Properties.Resources.weintrauben;
            PictureBox2.Location = new Point(441, 150);
            PictureBox2.Margin = new Padding(4, 5, 4, 5);
            PictureBox2.Name = "PictureBox2";
            PictureBox2.Size = new Size(133, 274);
            PictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox2.TabIndex = 5;
            PictureBox2.TabStop = false;
            // 
            // PictureBox1
            // 
            PictureBox1.BackColor = Color.White;
            PictureBox1.Image = Frontend.Properties.Resources.wassermelone;
            PictureBox1.Location = new Point(242, 150);
            PictureBox1.Margin = new Padding(4, 5, 4, 5);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(133, 274);
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.TabIndex = 4;
            PictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblMsg
            // 
            lblMsg.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblMsg.Location = new Point(393, 414);
            lblMsg.Margin = new Padding(4, 0, 4, 0);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(240, 62);
            lblMsg.TabIndex = 8;
            lblMsg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // infolbl
            // 
            infolbl.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            infolbl.ForeColor = SystemColors.Highlight;
            infolbl.Location = new Point(242, 33);
            infolbl.Margin = new Padding(4, 0, 4, 0);
            infolbl.Name = "infolbl";
            infolbl.Size = new Size(261, 46);
            infolbl.TabIndex = 9;
            infolbl.Text = "Guthaben:";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(219, 531);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(112, 105);
            button2.TabIndex = 11;
            button2.Text = "100€ EINZAHLEN";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button3.Location = new Point(339, 531);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(36, 40);
            button3.TabIndex = 12;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(339, 593);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(36, 43);
            button4.TabIndex = 13;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // betlbl
            // 
            betlbl.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            betlbl.ForeColor = SystemColors.Highlight;
            betlbl.Location = new Point(543, 33);
            betlbl.Margin = new Padding(4, 0, 4, 0);
            betlbl.Name = "betlbl";
            betlbl.Size = new Size(312, 46);
            betlbl.TabIndex = 14;
            betlbl.Text = "Einsatz:";
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(659, 533);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(100, 103);
            button5.TabIndex = 15;
            button5.Text = "EINSATZ";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button6.Location = new Point(767, 533);
            button6.Margin = new Padding(4, 5, 4, 5);
            button6.Name = "button6";
            button6.Size = new Size(36, 40);
            button6.TabIndex = 16;
            button6.Text = "+";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(767, 593);
            button7.Margin = new Padding(4, 5, 4, 5);
            button7.Name = "button7";
            button7.Size = new Size(36, 43);
            button7.TabIndex = 17;
            button7.Text = "-";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(219, 472);
            button9.Margin = new Padding(4, 5, 4, 5);
            button9.Name = "button9";
            button9.Size = new Size(112, 49);
            button9.TabIndex = 19;
            button9.Text = "EINZAHLEN";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(659, 472);
            button8.Margin = new Padding(4, 5, 4, 5);
            button8.Name = "button8";
            button8.Size = new Size(144, 49);
            button8.TabIndex = 20;
            button8.Text = "SPIEL BEENDEN";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.White;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.Location = new Point(863, 21);
            button10.Margin = new Padding(4, 5, 4, 5);
            button10.Name = "button10";
            button10.Size = new Size(121, 58);
            button10.TabIndex = 21;
            button10.Text = "Regeln";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(infolbl);
            panel1.Controls.Add(lblMsg);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(betlbl);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(PictureBox1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(Button1);
            panel1.Controls.Add(PictureBox2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(PictureBox3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(143, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(1006, 679);
            panel1.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1269, 868);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Slot Machine";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.PictureBox PictureBox3;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label infolbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label betlbl;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private Panel panel1;
    }
}


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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Button1 = new System.Windows.Forms.Button();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMsg = new System.Windows.Forms.Label();
            this.infolbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.betlbl = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(388, 374);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(180, 68);
            this.Button1.TabIndex = 7;
            this.Button1.Text = "DREHEN";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PictureBox3
            // 
            this.PictureBox3.Image = global::Slot_Machine.Properties.Resources.sieben;
            this.PictureBox3.Location = new System.Drawing.Point(593, 82);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(100, 178);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox3.TabIndex = 6;
            this.PictureBox3.TabStop = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = global::Slot_Machine.Properties.Resources.weintraube;
            this.PictureBox2.Location = new System.Drawing.Point(436, 82);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(100, 178);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox2.TabIndex = 5;
            this.PictureBox2.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::Slot_Machine.Properties.Resources.wassermelone;
            this.PictureBox1.Location = new System.Drawing.Point(266, 82);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(100, 178);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 4;
            this.PictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMsg.Location = new System.Drawing.Point(388, 306);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(180, 40);
            this.lblMsg.TabIndex = 8;
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infolbl
            // 
            this.infolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infolbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.infolbl.Location = new System.Drawing.Point(266, 39);
            this.infolbl.Name = "infolbl";
            this.infolbl.Size = new System.Drawing.Size(170, 30);
            this.infolbl.TabIndex = 9;
            this.infolbl.Text = "Guthaben:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 68);
            this.button2.TabIndex = 11;
            this.button2.Text = "50€ EINZAHLEN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(338, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 26);
            this.button3.TabIndex = 12;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(338, 414);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 28);
            this.button4.TabIndex = 13;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // betlbl
            // 
            this.betlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.betlbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.betlbl.Location = new System.Drawing.Point(436, 39);
            this.betlbl.Name = "betlbl";
            this.betlbl.Size = new System.Drawing.Size(257, 30);
            this.betlbl.TabIndex = 14;
            this.betlbl.Text = "Einsatz:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(593, 375);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 67);
            this.button5.TabIndex = 15;
            this.button5.Text = "EINSATZ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(674, 375);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(27, 26);
            this.button6.TabIndex = 16;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(674, 414);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(27, 28);
            this.button7.TabIndex = 17;
            this.button7.Text = "-";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(248, 345);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(84, 23);
            this.button9.TabIndex = 19;
            this.button9.Text = "EINZAHLEN";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(593, 296);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 62);
            this.button8.TabIndex = 20;
            this.button8.Text = "SPIEL BEENDEN";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(952, 564);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.betlbl);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.infolbl);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.PictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

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
    }
}


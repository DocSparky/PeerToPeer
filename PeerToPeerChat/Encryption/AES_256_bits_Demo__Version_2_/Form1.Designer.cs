namespace AESDemo
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
            System.Security.SecureString secureString2 = new System.Security.SecureString();
            this.secureTextBox1 = new System.Windows.Forms.SecureTextBox();
            this.txtDecrypted4 = new System.Windows.Forms.TextBox();
            this.txtDecrypted3 = new System.Windows.Forms.TextBox();
            this.txtDecrypted2 = new System.Windows.Forms.TextBox();
            this.txtDecrypted1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEncrypted4 = new System.Windows.Forms.TextBox();
            this.txtEncrypted3 = new System.Windows.Forms.TextBox();
            this.txtEncrypted2 = new System.Windows.Forms.TextBox();
            this.txtEncrypted1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOriginalText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // secureTextBox1
            // 
            this.secureTextBox1.BackColor = System.Drawing.Color.LightYellow;
            this.secureTextBox1.Location = new System.Drawing.Point(92, 6);
            this.secureTextBox1.Name = "secureTextBox1";
            this.secureTextBox1.SecureText = secureString2;
            this.secureTextBox1.Size = new System.Drawing.Size(310, 20);
            this.secureTextBox1.TabIndex = 0;
            this.secureTextBox1.UseSystemPasswordChar = true;
            // 
            // txtDecrypted4
            // 
            this.txtDecrypted4.Location = new System.Drawing.Point(365, 174);
            this.txtDecrypted4.Name = "txtDecrypted4";
            this.txtDecrypted4.Size = new System.Drawing.Size(310, 20);
            this.txtDecrypted4.TabIndex = 29;
            // 
            // txtDecrypted3
            // 
            this.txtDecrypted3.Location = new System.Drawing.Point(365, 148);
            this.txtDecrypted3.Name = "txtDecrypted3";
            this.txtDecrypted3.Size = new System.Drawing.Size(310, 20);
            this.txtDecrypted3.TabIndex = 28;
            // 
            // txtDecrypted2
            // 
            this.txtDecrypted2.Location = new System.Drawing.Point(365, 122);
            this.txtDecrypted2.Name = "txtDecrypted2";
            this.txtDecrypted2.Size = new System.Drawing.Size(310, 20);
            this.txtDecrypted2.TabIndex = 27;
            // 
            // txtDecrypted1
            // 
            this.txtDecrypted1.Location = new System.Drawing.Point(365, 96);
            this.txtDecrypted1.Name = "txtDecrypted1";
            this.txtDecrypted1.Size = new System.Drawing.Size(310, 20);
            this.txtDecrypted1.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 117);
            this.label5.TabIndex = 25;
            this.label5.Text = "        Decrypted Text\r\n\r\n>\r\n\r\n>\r\n\r\n>\r\n\r\n>";
            // 
            // txtEncrypted4
            // 
            this.txtEncrypted4.Location = new System.Drawing.Point(31, 174);
            this.txtEncrypted4.Name = "txtEncrypted4";
            this.txtEncrypted4.Size = new System.Drawing.Size(310, 20);
            this.txtEncrypted4.TabIndex = 24;
            // 
            // txtEncrypted3
            // 
            this.txtEncrypted3.Location = new System.Drawing.Point(31, 148);
            this.txtEncrypted3.Name = "txtEncrypted3";
            this.txtEncrypted3.Size = new System.Drawing.Size(310, 20);
            this.txtEncrypted3.TabIndex = 23;
            // 
            // txtEncrypted2
            // 
            this.txtEncrypted2.Location = new System.Drawing.Point(31, 122);
            this.txtEncrypted2.Name = "txtEncrypted2";
            this.txtEncrypted2.Size = new System.Drawing.Size(310, 20);
            this.txtEncrypted2.TabIndex = 21;
            // 
            // txtEncrypted1
            // 
            this.txtEncrypted1.Location = new System.Drawing.Point(31, 96);
            this.txtEncrypted1.Name = "txtEncrypted1";
            this.txtEncrypted1.Size = new System.Drawing.Size(310, 20);
            this.txtEncrypted1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 117);
            this.label3.TabIndex = 22;
            this.label3.Text = "Encrypted Text\r\n\r\n1\r\n\r\n2\r\n\r\n3\r\n\r\n4";
            // 
            // txtOriginalText
            // 
            this.txtOriginalText.BackColor = System.Drawing.Color.Lavender;
            this.txtOriginalText.Location = new System.Drawing.Point(92, 32);
            this.txtOriginalText.Name = "txtOriginalText";
            this.txtOriginalText.Size = new System.Drawing.Size(310, 20);
            this.txtOriginalText.TabIndex = 19;
            this.txtOriginalText.TextChanged += new System.EventHandler(this.txtOriginalText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Original Text";
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(689, 205);
            this.Controls.Add(this.secureTextBox1);
            this.Controls.Add(this.txtDecrypted4);
            this.Controls.Add(this.txtDecrypted3);
            this.Controls.Add(this.txtDecrypted2);
            this.Controls.Add(this.txtDecrypted1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEncrypted4);
            this.Controls.Add(this.txtEncrypted3);
            this.Controls.Add(this.txtEncrypted2);
            this.Controls.Add(this.txtEncrypted1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOriginalText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SecureTextBox secureTextBox1;
        private System.Windows.Forms.TextBox txtDecrypted4;
        private System.Windows.Forms.TextBox txtDecrypted3;
        private System.Windows.Forms.TextBox txtDecrypted2;
        private System.Windows.Forms.TextBox txtDecrypted1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEncrypted4;
        private System.Windows.Forms.TextBox txtEncrypted3;
        private System.Windows.Forms.TextBox txtEncrypted2;
        private System.Windows.Forms.TextBox txtEncrypted1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOriginalText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}


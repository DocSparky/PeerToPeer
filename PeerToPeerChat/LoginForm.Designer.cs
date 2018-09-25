namespace PeerToPeerChat
{
    partial class LoginForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbCipher = new System.Windows.Forms.Label();
            this.tbCipherKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(60, 104);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(61, 36);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select User Name (32 char max)";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(9, 21);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUserName.MaxLength = 32;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(164, 20);
            this.tbUserName.TabIndex = 0;
            // 
            // tbCipher
            // 
            this.tbCipher.AutoSize = true;
            this.tbCipher.Location = new System.Drawing.Point(6, 56);
            this.tbCipher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tbCipher.Name = "tbCipher";
            this.tbCipher.Size = new System.Drawing.Size(86, 13);
            this.tbCipher.TabIndex = 3;
            this.tbCipher.Text = "Enter Cipher Key";
            // 
            // tbCipherKey
            // 
            this.tbCipherKey.Location = new System.Drawing.Point(9, 71);
            this.tbCipherKey.Margin = new System.Windows.Forms.Padding(2);
            this.tbCipherKey.MaxLength = 32;
            this.tbCipherKey.Name = "tbCipherKey";
            this.tbCipherKey.Size = new System.Drawing.Size(164, 20);
            this.tbCipherKey.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 162);
            this.Controls.Add(this.tbCipherKey);
            this.Controls.Add(this.tbCipher);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.Text = "Select User Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label tbCipher;
        private System.Windows.Forms.TextBox tbCipherKey;
    }
}
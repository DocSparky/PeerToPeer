namespace PeerToPeerChat
{
    partial class ChatForm
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
            this.rtbChat = new System.Windows.Forms.RichTextBox();
            this.tbSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbChat
            // 
            this.rtbChat.BackColor = System.Drawing.Color.White;
            this.rtbChat.Location = new System.Drawing.Point(6, 8);
            this.rtbChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbChat.Name = "rtbChat";
            this.rtbChat.ReadOnly = true;
            this.rtbChat.Size = new System.Drawing.Size(622, 266);
            this.rtbChat.TabIndex = 2;
            this.rtbChat.TabStop = false;
            this.rtbChat.Text = "";
            // 
            // tbSend
            // 
            this.tbSend.Location = new System.Drawing.Point(6, 278);
            this.tbSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSend.MaxLength = 968;
            this.tbSend.Name = "tbSend";
            this.tbSend.Size = new System.Drawing.Size(571, 20);
            this.tbSend.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(584, 278);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(44, 25);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 313);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbSend);
            this.Controls.Add(this.rtbChat);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbChat;
        private System.Windows.Forms.TextBox tbSend;
        private System.Windows.Forms.Button btnSend;
    }
}


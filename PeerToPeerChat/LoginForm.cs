/* based on https://www.dreamincode.net/forums/topic/231058-peer-to-peer-chat-advanced/
 * 
 * When we add encryption, and put the password on the login form, we could:
 * use the password as a shared key between users
 * use the passed usernames un-encrypted, and use them to salt the encryption
 * for instance - Michael enters message "Hello Friend"
 * program sends message "Michael - jaberwocky goblygook"
 * Daniel's program receives "Michael - jaberwocky goblygook" and uses the shared password he entered,
 * and the salt from "Michael" to decrypt the message and displays "Michael - Hello Friend"
 * 
 * Daniel sending the same message would transmit salted with his username, and may be received by 
 * Michael as "Daniel - AbraCadabra Flicker" before being decrypted with the "Daniel" salt to display "Daniel - Hello Friend"
*/

S

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeerToPeerChat
{
    public partial class LoginForm : Form
    {
        string userName = "";
        // Likely need to add a string for PASSWORD, that will then need to be passed to ChatForm.cs, and used for the encryption program.

        public string UserName                          // Add field for User Name
        {
            get { return userName; }
        }
        public LoginForm()                              // Set behavior for closing form
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler (LoginForm_FormClosing);
            btnOK.Click += new EventHandler(btnOK_Click);
        }

        void btnOK_Click(object sender, EventArgs e)    // Set behavior for clicking OK button; Trim removes leading and following spaces from user entry
        {
            userName = tbUserName.Text.Trim();

            if (string.IsNullOrEmpty(userName))         // Check if user entry is empty; error message if empty
            {
                MessageBox.Show("Please select a user name up to 32 charachters.");
                return;
            }
            
            this.FormClosing -= LoginForm_FormClosing;  // If user doesnt use OK button, sets userName to empty / precipitates apoptosis of ChatForm
            this.Close();                               // Closes the form
        }

        void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            userName = "";
        }
    }
}

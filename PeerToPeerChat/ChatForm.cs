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


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace PeerToPeerChat
{
    public partial class ChatForm : Form
    {
        delegate void AddMessage(string message);                       // Permits a peer to add info to our GUI

        string userName;                                                // Remember the username entered on LoginForm

        const int port = 54545;                                         // Fixed port for communication; 1 to 1024 are reserved, 1025 to 65436 are fair game
        const string broadcastAddress = "255.255.255.255";              // Special TCP/IP address: All data sent to this address is routed to all local hosts on LAN // Stays LAN, will not go external

        UdpClient receivingClient;                                      // Receives messages
        UdpClient sendingClient;                                        // Sends messages

        Thread receivingThread;                                         // Listening thread; operates in background

        public ChatForm()
        {
            InitializeComponent();

            this.Load += new EventHandler(ChatForm_Load);               // Does initial setup when the form loads
            btnSend.Click += new EventHandler(btnSend_Click);           // Sets up what to do when hitting send
        }

        void ChatForm_Load(object sender, EventArgs e)
        {
            this.Hide();                                                // Hides the login form immediately after its use

            using (LoginForm loginForm = new LoginForm())               // Generates a new login form
            {
                loginForm.ShowDialog();                                 // Displays the login form / user must complete form to continue

                if (loginForm.UserName == "")                           // If user does not enter user name, all forms close
                    this.Close();
                else
                {
                    userName = loginForm.UserName;                      // If user does enter user name, sets user name in memory and program progresses
                    this.Show();                                        // Shows Chat form
                }
            }

            tbSend.Focus();                                             // Selects the text entry box on the Chat Form

            InitializeSender();                                         // Start the sending UDP processes
            InitializeReceiver();                                       // Start the receiving UDP processes
        }

        private void InitializeSender()
        {
            sendingClient = new UdpClient(broadcastAddress, port);      // Sets up UDP client to send on previously defined IP/Port
            sendingClient.EnableBroadcast = true;                       // Tells UDP you really want to send message to all machines in LAN
        }

        private void InitializeReceiver()
        {
            receivingClient = new UdpClient(port);                      // Sets up UDP client that listens on previously specified port

            ThreadStart start = new ThreadStart(Receiver);              // Creates background thread to listen for incoming messages
            receivingThread = new Thread(start);
            receivingThread.IsBackground = true;                        // Specifies it to run in the background
            receivingThread.Start();                                    // Actually starts the thread
        }

/* This is probably where we are going to have to make modifications to handle encryption outbound */

        void btnSend_Click(object sender, EventArgs e)          
        {
            tbSend.Text = tbSend.Text.TrimEnd();                        // Removes trailing spaces from textbox entry

            if (!string.IsNullOrEmpty(tbSend.Text))                     // Checks to see if user is trying to send a blank line
            {
                string toSend = userName + ":\n" + tbSend.Text;         // Create a string of user name and trimmed message






                byte[] data = Encoding.ASCII.GetBytes(toSend);          // Generate array of bytes representing string of previous line
                sendingClient.Send(data, data.Length);                  // Send array of previous line
                tbSend.Text = "";                                       // Clear text entry box
            }

            tbSend.Focus();                                             // Sets curor focus to text entry box
        }

/* This is probably where we are going to have to make modifications to handle encryption inbound */

        private void Receiver()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, port);  // Defines IP address and Port to listen to; IPAddress.Any listens to any and all IP addresses broadcasting to specified port
            AddMessage messageDelegate = MessageReceived;

            while (true)                                                // Infinite loop that checks for incoming data / why having to use threads
            {
                byte[] data = receivingClient.Receive(ref endPoint);    // Brings received data into array
                string message = Encoding.ASCII.GetString(data);        // Hashes array back into string
                Invoke(messageDelegate, message);                       // Pass message to delegate thread to post to rtbChat's text property
            }
        }

        private void MessageReceived(string message)
        {
            rtbChat.Text += message + "\n" + "\n";
        }

        // I think these lines are extraneous,... not positive..
        /*
        private void rtbChat_TextChanged(object sender, EventArgs e)
        {

        }*/
    }
}

using System;
using System.Security;
using System.Runtime.InteropServices;

namespace System.Windows.Forms
{
    /// <summary>
    /// TextBox implementation that uses the System.Security.SecureString as its backing
    /// store instead of standard managed string instance. 
    /// </summary>
    internal partial class SecureTextBox : TextBox
    {
        SecureString _secureEntry = new SecureString();

        /// <summary>
        /// 
        /// </summary>
        public SecureTextBox()
            : base()
        {
            /* Use system password character */
            this.UseSystemPasswordChar = true;
        }

        /// <summary>
        /// The secure string instance captured so far.
        /// This is the preferred method of accessing the string contents.
        /// </summary>
        public SecureString SecureText
        {
            get
            {
                return this._secureEntry;
            }

            set
            {
                this._secureEntry = value;
            }
        }

        /// <summary>
        /// Allows the consumer to retrieve this string instance as a character array. Note that this is still
        /// visible plainly in memory and should be 'consumed' as quickly as possible, then the contents
        /// 'zero-ed' so that they cannot be viewed.
        /// </summary>
        public char[] CharacterData
        {
            get
            {
                char[] bytes = new char[this._secureEntry.Length];
                IntPtr pszText = IntPtr.Zero;

                try
                {
                    pszText = Marshal.SecureStringToGlobalAllocUnicode(this._secureEntry);
                    bytes = new char[this._secureEntry.Length];

                    Marshal.Copy(pszText, bytes, 0, this._secureEntry.Length);
                }
                finally
                {
                    if (pszText != IntPtr.Zero)
                    {
                        Marshal.ZeroFreeGlobalAllocUnicode(pszText);
                    }
                }

                return bytes;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="placeHolder">Should contain placeholder text only! (i.e. not a password!)</param>
        public void SetPlaceholder(string placeHolder)
        {
            if (!string.IsNullOrEmpty(placeHolder))
            {
                char[] chars = placeHolder.ToCharArray();

                for (int i = 0; i < chars.Length; ++i)
                {
                    this._secureEntry.AppendChar(chars[i]);
                }

                this.Text = placeHolder;
            }
        }

        #region Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            /* Deny cut, copy and paste */
            if (m.Msg == 0x0301) /* WM_COPY */
            {
                return;
            }

            if (m.Msg == 0x0300) /* WM_CUT */
            {
                return;
            }

            if (m.Msg == 0x0302) /* WM_PASTE */
            {
                return;
            }

            /* Remove the context menu (after all we can't cut/copy/paste, so it's not much good to us anyway!) */
            if (m.Msg == 0x007B) /* WM_CONTEXTMENU */
            {
                return;
            }

            base.WndProc(ref m);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            try
            {
                int startPos = this.SelectionStart;

                /* Handle backspace */
                if (((Keys)e.KeyChar) == Keys.Back)
                {
                    if (this.SelectionLength == 0 && startPos > 0 && startPos <= this._secureEntry.Length)
                    {
                        startPos--;
                        this._secureEntry.RemoveAt(startPos);

                        this.Text = new string('*', this._secureEntry.Length);
                        this.SelectionStart = startPos;
                    }
                    else if (this.SelectionLength > 0)
                    {
                        for (int i = 0; i < this.SelectionLength; i++)
                        {
                            this._secureEntry.RemoveAt(this.SelectionStart);
                        }

                        this.Text = new string('*', this._secureEntry.Length);
                        this.SelectionStart = startPos;
                    }

                    e.Handled = true;
                    return;
                }

                /* Give us some input, baby! */
                if (!char.IsControl(e.KeyChar) && !char.IsHighSurrogate(e.KeyChar) && !char.IsLowSurrogate(e.KeyChar))
                {
                    if (this.IsInputChar(e.KeyChar))
                    {
                        if (this.SelectionLength > 0)
                        {
                            for (int i = 0; i < this.SelectionLength; i++)
                            {
                                this._secureEntry.RemoveAt(this.SelectionStart);
                            }
                        }

                        if (startPos == this._secureEntry.Length)
                        {
                            this._secureEntry.AppendChar(e.KeyChar);
                        }
                        else
                        {
                            this._secureEntry.InsertAt(startPos, e.KeyChar);
                        }

                        this.Text = new string('*', this._secureEntry.Length);
                        startPos++;

                        this.SelectionStart = startPos;
                        e.Handled = true;

                        return;
                    }
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                this._HandleCritialFailure(ex);
            }

            base.OnKeyPress(e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool IsInputKey(Keys keyData)
        {
            try
            {
                /* Handle the delete key */
                bool allowedToDelete = ((keyData & Keys.Delete) == Keys.Delete);

                if (allowedToDelete)
                {
                    if (this.SelectionLength == this._secureEntry.Length)
                    {
                        this._secureEntry.Clear();
                    }
                    else if (this.SelectionLength > 0)
                    {
                        for (int i = 0; i < this.SelectionLength; i++)
                        {
                            this._secureEntry.RemoveAt(this.SelectionStart);
                        }
                    }
                    else
                    {
                        if ((keyData & Keys.Delete) == Keys.Delete && this.SelectionStart < this.Text.Length)
                        {
                            this._secureEntry.RemoveAt(this.SelectionStart);
                        }
                    }

                    return true;
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                this._HandleCritialFailure(ex);
            }

            return base.IsInputKey(keyData);
        }
        #endregion

        #region Helpers
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        private void _HandleCritialFailure(Exception e)
        {
            this._secureEntry.Clear();
            this.Text = string.Empty;

            /* todo: resource strings */
            MessageBox.Show("Secure password error: Reached critical endpoint: " + e.Message);
        }
        #endregion
    }
}
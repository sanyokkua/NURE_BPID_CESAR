using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPID_CESAR_WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            string text = richTextBoxText.Text;
            if (text.Length > 0 && textBoxShiftEncryption.Text.Length>0)
            {
                int shift = 0;
                try
                {
                    shift = Convert.ToInt32(textBoxShiftEncryption.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                string result = Cesar.Encrypt(text, shift);
                richTextBoxEncrypted.Text = result;
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            string cipher = richTextBoxEncrypted.Text;
            if (cipher.Length > 0 && textBoxShiftDecryption.Text.Length > 0)
            {
                int shift = 0;
                try
                {
                    shift = Convert.ToInt32(textBoxShiftDecryption.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                string result = Cesar.Decrypt(cipher, shift);
                richTextBoxDecrypted.Text = result;
            }
        }
    }
}

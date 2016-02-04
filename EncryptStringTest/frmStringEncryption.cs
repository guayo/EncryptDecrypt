using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptStringTest
{
    public partial class frmStringEncryption : Form
    {
        public frmStringEncryption()
        {
            InitializeComponent();
        }

        private void butEncrypt_Click(object sender, EventArgs e)
        {
           // if ((!string.IsNullOrWhiteSpace(textBoxString.Text) && !string.IsNullOrWhiteSpace(textBoxString.Text))==true)
          //  {
                try
                {
                   // textBoxEncrypted.Text = Encrypt.EncryptString(textBoxString.Text, textBoxPassword.Text);
                    textBoxEncrypted.Text = Encrypt.EncryptString(textBoxString.Text, "Killz0ne");
                    textBoxString.Text = "";
                }
                catch( Exception ex )
                {
                    MessageBox.Show(ex.ToString());
                }
           // }
        }

        private void butDecrypt_Click(object sender, EventArgs e)
        {
           // if ((!string.IsNullOrWhiteSpace(textBoxEncrypted.Text) && !string.IsNullOrWhiteSpace(textBoxPassword.Text))==true)
           // {
                try
                {
                   // textBoxString.Text = Encrypt.DecryptString(textBoxEncrypted.Text, textBoxPassword.Text);
                    textBoxString.Text = Encrypt.DecryptString(textBoxEncrypted.Text, "Killz0ne");
                    textBoxEncrypted.Text = "";
                }
                catch( Exception ex )
                {
                    MessageBox.Show(ex.ToString());
                }
          //  }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace RsaDeneme01
{
    public partial class Form1 : Form
    {
        Rsa rsa = new Rsa();
        public Form1()
        {
            InitializeComponent();
        }


        private void btnEncyrpt_Click(object sender, EventArgs e)
        {
            rsa.Gen_PublicKey(Convert.ToInt16(txt_P_val.Text),Convert.ToInt16(txt_Q_val.Text));
            string plain = txtPlainText.Text;
            byte[] dataToEncrypt = Encoding.ASCII.GetBytes(plain);
            rsa.Encyrpt(dataToEncrypt);
            txtCipherText.Text = rsa.cipherText;
        }

        private void btnDecyrpt_Click(object sender, EventArgs e)
        {
            rsa.Gen_PrivateKey();
            rsa.Decyrpt();
            txtMessage.Text=   rsa.plainText;
        }
    }
}

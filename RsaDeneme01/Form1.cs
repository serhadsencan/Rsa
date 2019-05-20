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
        

        private void button1_Click(object sender, EventArgs e)
        {

            //Console.WriteLine(dataToEncrypt[0].ToString());
            //string result = System.Text.Encoding.UTF8.GetString(dataToEncrypt);
            //Console.WriteLine(result.ToString());
            //int[] intArr = new int[2];
            //for (int i = 0; i < 2; i++)
            //{
            //    intArr[i] = intArr[i] * dataToEncrypt[i];
            //}
            //byte[] a = new byte[dataToEncrypt.Length];
            //    Convert.ToByte(intArr[0] % 183);
            //for (int j=0;j<dataToEncrypt.Length;j++)
            //{

            //}
            //string encry = System.Text.Encoding.UTF8.GetString(a);
            //Console.WriteLine(a);


            //Console.WriteLine(rsa.gcd(1701,3768).ToString());
            string first = "SerhatEymenSencan ve Emirhan Gumus projesi bitches";
            byte[] dataToEncrypt = Encoding.ASCII.GetBytes(first);
            
            rsa.Gen_PublicKey(17,11);
            Console.WriteLine("End of publickey");
            rsa.Gen_PrivateKey();
            Console.WriteLine("End of privatekey");
            rsa.Encyrpt(dataToEncrypt);
            Console.WriteLine("End of encyrpt");
            rsa.Decyrpt();
            Console.WriteLine("End of decyrpt");
            Console.WriteLine("Şifrelenecek mesaj : "+first);
            Console.WriteLine("Cipher text : "+ rsa.cipherText);
            Console.WriteLine("Decyrpted text : " + rsa.plainText);

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

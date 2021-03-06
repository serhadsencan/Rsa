﻿using System;
using System.Numerics;
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
            rsa.Gen_PublicKey(BigInteger.Parse(txt_P_val.Text), BigInteger.Parse(txt_Q_val.Text));
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

        private void button1_Click(object sender, EventArgs e)
        {
            BigInteger a, b;
            a = 123213213221221211;
            b = 213213213213213122;
            rsa.Test(a,b);
        }
    }
}

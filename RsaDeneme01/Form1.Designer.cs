namespace RsaDeneme01
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPlainText = new System.Windows.Forms.RichTextBox();
            this.txtCipherText = new System.Windows.Forms.RichTextBox();
            this.btnEncyrpt = new System.Windows.Forms.Button();
            this.btnDecyrpt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_P_val = new System.Windows.Forms.TextBox();
            this.txt_Q_val = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(31, 43);
            this.txtPlainText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(509, 153);
            this.txtPlainText.TabIndex = 1;
            this.txtPlainText.Text = "";
            // 
            // txtCipherText
            // 
            this.txtCipherText.Location = new System.Drawing.Point(35, 240);
            this.txtCipherText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCipherText.Name = "txtCipherText";
            this.txtCipherText.Size = new System.Drawing.Size(512, 164);
            this.txtCipherText.TabIndex = 2;
            this.txtCipherText.Text = "";
            // 
            // btnEncyrpt
            // 
            this.btnEncyrpt.Location = new System.Drawing.Point(607, 198);
            this.btnEncyrpt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEncyrpt.Name = "btnEncyrpt";
            this.btnEncyrpt.Size = new System.Drawing.Size(97, 60);
            this.btnEncyrpt.TabIndex = 3;
            this.btnEncyrpt.Text = "Encyrpt";
            this.btnEncyrpt.UseVisualStyleBackColor = true;
            this.btnEncyrpt.Click += new System.EventHandler(this.btnEncyrpt_Click);
            // 
            // btnDecyrpt
            // 
            this.btnDecyrpt.Location = new System.Drawing.Point(726, 198);
            this.btnDecyrpt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDecyrpt.Name = "btnDecyrpt";
            this.btnDecyrpt.Size = new System.Drawing.Size(97, 60);
            this.btnDecyrpt.TabIndex = 4;
            this.btnDecyrpt.Text = "Decyrpt";
            this.btnDecyrpt.UseVisualStyleBackColor = true;
            this.btnDecyrpt.Click += new System.EventHandler(this.btnDecyrpt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Plain Text :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cipher Text:";
            // 
            // txt_P_val
            // 
            this.txt_P_val.Location = new System.Drawing.Point(666, 71);
            this.txt_P_val.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_P_val.Name = "txt_P_val";
            this.txt_P_val.Size = new System.Drawing.Size(132, 22);
            this.txt_P_val.TabIndex = 7;
            // 
            // txt_Q_val
            // 
            this.txt_Q_val.Location = new System.Drawing.Point(666, 115);
            this.txt_Q_val.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Q_val.Name = "txt_Q_val";
            this.txt_Q_val.Size = new System.Drawing.Size(132, 22);
            this.txt_Q_val.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "P :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(606, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Q :";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(31, 452);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(527, 159);
            this.txtMessage.TabIndex = 11;
            this.txtMessage.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 420);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Message :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 641);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Q_val);
            this.Controls.Add(this.txt_P_val);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDecyrpt);
            this.Controls.Add(this.btnEncyrpt);
            this.Controls.Add(this.txtCipherText);
            this.Controls.Add(this.txtPlainText);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "RSA Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtPlainText;
        private System.Windows.Forms.RichTextBox txtCipherText;
        private System.Windows.Forms.Button btnEncyrpt;
        private System.Windows.Forms.Button btnDecyrpt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_P_val;
        private System.Windows.Forms.TextBox txt_Q_val;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.Label label5;
    }
}


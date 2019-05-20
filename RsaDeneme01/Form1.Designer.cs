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
            this.button1 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Encyrpt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(23, 35);
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(383, 125);
            this.txtPlainText.TabIndex = 1;
            this.txtPlainText.Text = "";
            // 
            // txtCipherText
            // 
            this.txtCipherText.Location = new System.Drawing.Point(26, 195);
            this.txtCipherText.Name = "txtCipherText";
            this.txtCipherText.Size = new System.Drawing.Size(385, 134);
            this.txtCipherText.TabIndex = 2;
            this.txtCipherText.Text = "";
            // 
            // btnEncyrpt
            // 
            this.btnEncyrpt.Location = new System.Drawing.Point(573, 196);
            this.btnEncyrpt.Name = "btnEncyrpt";
            this.btnEncyrpt.Size = new System.Drawing.Size(73, 49);
            this.btnEncyrpt.TabIndex = 3;
            this.btnEncyrpt.Text = "Encyrpt";
            this.btnEncyrpt.UseVisualStyleBackColor = true;
            this.btnEncyrpt.Click += new System.EventHandler(this.btnEncyrpt_Click);
            // 
            // btnDecyrpt
            // 
            this.btnDecyrpt.Location = new System.Drawing.Point(662, 196);
            this.btnDecyrpt.Name = "btnDecyrpt";
            this.btnDecyrpt.Size = new System.Drawing.Size(73, 49);
            this.btnDecyrpt.TabIndex = 4;
            this.btnDecyrpt.Text = "Decyrpt";
            this.btnDecyrpt.UseVisualStyleBackColor = true;
            this.btnDecyrpt.Click += new System.EventHandler(this.btnDecyrpt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Plain Text :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cipher Text:";
            // 
            // txt_P_val
            // 
            this.txt_P_val.Location = new System.Drawing.Point(615, 70);
            this.txt_P_val.Name = "txt_P_val";
            this.txt_P_val.Size = new System.Drawing.Size(100, 20);
            this.txt_P_val.TabIndex = 7;
            // 
            // txt_Q_val
            // 
            this.txt_Q_val.Location = new System.Drawing.Point(615, 106);
            this.txt_Q_val.Name = "txt_Q_val";
            this.txt_Q_val.Size = new System.Drawing.Size(100, 20);
            this.txt_Q_val.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "P :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Q :";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(23, 367);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(396, 130);
            this.txtMessage.TabIndex = 11;
            this.txtMessage.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Message :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 536);
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
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
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


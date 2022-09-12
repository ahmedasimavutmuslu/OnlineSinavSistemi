
namespace ProjeDeneme
{
    partial class frmGirisBilgiOgrenci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnSifremiUnuttumOgrenci = new System.Windows.Forms.Button();
            this.bttnGirisYapOgrenci = new System.Windows.Forms.Button();
            this.textBoxSifreOgrenci = new System.Windows.Forms.TextBox();
            this.textBoxtcKimlikOgrenci = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "TC Kimlik Numarası :";
            // 
            // bttnSifremiUnuttumOgrenci
            // 
            this.bttnSifremiUnuttumOgrenci.Location = new System.Drawing.Point(425, 325);
            this.bttnSifremiUnuttumOgrenci.Name = "bttnSifremiUnuttumOgrenci";
            this.bttnSifremiUnuttumOgrenci.Size = new System.Drawing.Size(75, 54);
            this.bttnSifremiUnuttumOgrenci.TabIndex = 9;
            this.bttnSifremiUnuttumOgrenci.Text = "Şifremi Unuttum";
            this.bttnSifremiUnuttumOgrenci.UseVisualStyleBackColor = true;
            this.bttnSifremiUnuttumOgrenci.Click += new System.EventHandler(this.bttnSifremiUnuttumOgrenci_Click);
            // 
            // bttnGirisYapOgrenci
            // 
            this.bttnGirisYapOgrenci.Location = new System.Drawing.Point(294, 325);
            this.bttnGirisYapOgrenci.Name = "bttnGirisYapOgrenci";
            this.bttnGirisYapOgrenci.Size = new System.Drawing.Size(75, 54);
            this.bttnGirisYapOgrenci.TabIndex = 8;
            this.bttnGirisYapOgrenci.Text = "Giriş Yap";
            this.bttnGirisYapOgrenci.UseVisualStyleBackColor = true;
            this.bttnGirisYapOgrenci.Click += new System.EventHandler(this.bttnGirisYapOgrenci_Click);
            // 
            // textBoxSifreOgrenci
            // 
            this.textBoxSifreOgrenci.Location = new System.Drawing.Point(346, 271);
            this.textBoxSifreOgrenci.Name = "textBoxSifreOgrenci";
            this.textBoxSifreOgrenci.PasswordChar = '*';
            this.textBoxSifreOgrenci.Size = new System.Drawing.Size(114, 22);
            this.textBoxSifreOgrenci.TabIndex = 7;
            this.textBoxSifreOgrenci.UseSystemPasswordChar = true;
            // 
            // textBoxtcKimlikOgrenci
            // 
            this.textBoxtcKimlikOgrenci.Location = new System.Drawing.Point(346, 233);
            this.textBoxtcKimlikOgrenci.Name = "textBoxtcKimlikOgrenci";
            this.textBoxtcKimlikOgrenci.Size = new System.Drawing.Size(114, 22);
            this.textBoxtcKimlikOgrenci.TabIndex = 6;
            // 
            // frmGirisBilgiOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnSifremiUnuttumOgrenci);
            this.Controls.Add(this.bttnGirisYapOgrenci);
            this.Controls.Add(this.textBoxSifreOgrenci);
            this.Controls.Add(this.textBoxtcKimlikOgrenci);
            this.Name = "frmGirisBilgiOgrenci";
            this.Text = "Öğrenci || Giriş Yap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnSifremiUnuttumOgrenci;
        private System.Windows.Forms.Button bttnGirisYapOgrenci;
        private System.Windows.Forms.TextBox textBoxSifreOgrenci;
        private System.Windows.Forms.TextBox textBoxtcKimlikOgrenci;
    }
}
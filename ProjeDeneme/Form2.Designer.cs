
namespace ProjeDeneme
{
    partial class frmGirisBilgiOgretmen
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
            this.textBoxtcKimlikOgretmen = new System.Windows.Forms.TextBox();
            this.textBoxSifreOgretmen = new System.Windows.Forms.TextBox();
            this.bttnGirisYapOgretmen = new System.Windows.Forms.Button();
            this.bttnSifremiUnuttumOgretmen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxtcKimlikOgretmen
            // 
            this.textBoxtcKimlikOgretmen.Location = new System.Drawing.Point(332, 240);
            this.textBoxtcKimlikOgretmen.Name = "textBoxtcKimlikOgretmen";
            this.textBoxtcKimlikOgretmen.Size = new System.Drawing.Size(114, 22);
            this.textBoxtcKimlikOgretmen.TabIndex = 0;
            // 
            // textBoxSifreOgretmen
            // 
            this.textBoxSifreOgretmen.Location = new System.Drawing.Point(332, 278);
            this.textBoxSifreOgretmen.Name = "textBoxSifreOgretmen";
            this.textBoxSifreOgretmen.PasswordChar = '*';
            this.textBoxSifreOgretmen.Size = new System.Drawing.Size(114, 22);
            this.textBoxSifreOgretmen.TabIndex = 1;
            this.textBoxSifreOgretmen.UseSystemPasswordChar = true;
            // 
            // bttnGirisYapOgretmen
            // 
            this.bttnGirisYapOgretmen.Location = new System.Drawing.Point(280, 332);
            this.bttnGirisYapOgretmen.Name = "bttnGirisYapOgretmen";
            this.bttnGirisYapOgretmen.Size = new System.Drawing.Size(75, 54);
            this.bttnGirisYapOgretmen.TabIndex = 2;
            this.bttnGirisYapOgretmen.Text = "Giriş Yap";
            this.bttnGirisYapOgretmen.UseVisualStyleBackColor = true;
            this.bttnGirisYapOgretmen.Click += new System.EventHandler(this.bttnGirisYap_Click);
            // 
            // bttnSifremiUnuttumOgretmen
            // 
            this.bttnSifremiUnuttumOgretmen.Location = new System.Drawing.Point(411, 332);
            this.bttnSifremiUnuttumOgretmen.Name = "bttnSifremiUnuttumOgretmen";
            this.bttnSifremiUnuttumOgretmen.Size = new System.Drawing.Size(75, 54);
            this.bttnSifremiUnuttumOgretmen.TabIndex = 3;
            this.bttnSifremiUnuttumOgretmen.Text = "Şifremi Unuttum";
            this.bttnSifremiUnuttumOgretmen.UseVisualStyleBackColor = true;
            this.bttnSifremiUnuttumOgretmen.Click += new System.EventHandler(this.bttnSifremiUnuttumOgretmen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "TC Kimlik Numarası :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre :";
            // 
            // frmGirisBilgiOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnSifremiUnuttumOgretmen);
            this.Controls.Add(this.bttnGirisYapOgretmen);
            this.Controls.Add(this.textBoxSifreOgretmen);
            this.Controls.Add(this.textBoxtcKimlikOgretmen);
            this.Name = "frmGirisBilgiOgretmen";
            this.Text = "Öğretmen || Giriş Yap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmgirisbilgi_FormClosing);
            this.Load += new System.EventHandler(this.frmGirisBilgiOgretmen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxtcKimlikOgretmen;
        private System.Windows.Forms.TextBox textBoxSifreOgretmen;
        private System.Windows.Forms.Button bttnGirisYapOgretmen;
        private System.Windows.Forms.Button bttnSifremiUnuttumOgretmen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
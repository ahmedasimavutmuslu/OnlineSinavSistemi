
namespace ProjeDeneme
{
    partial class frmOgrenciIslemleri
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
            this.dataGridViewOgrenciListesi = new System.Windows.Forms.DataGridView();
            this.textBoxAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOgrenciEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSoyadi = new System.Windows.Forms.TextBox();
            this.textBoxTC = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.buttonOgrenciSil = new System.Windows.Forms.Button();
            this.buttonOgrenciListele = new System.Windows.Forms.Button();
            this.buttonGeriDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrenciListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOgrenciListesi
            // 
            this.dataGridViewOgrenciListesi.AllowUserToAddRows = false;
            this.dataGridViewOgrenciListesi.AllowUserToDeleteRows = false;
            this.dataGridViewOgrenciListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOgrenciListesi.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewOgrenciListesi.Name = "dataGridViewOgrenciListesi";
            this.dataGridViewOgrenciListesi.ReadOnly = true;
            this.dataGridViewOgrenciListesi.RowHeadersWidth = 51;
            this.dataGridViewOgrenciListesi.RowTemplate.Height = 24;
            this.dataGridViewOgrenciListesi.Size = new System.Drawing.Size(536, 425);
            this.dataGridViewOgrenciListesi.TabIndex = 0;
            // 
            // textBoxAdi
            // 
            this.textBoxAdi.Location = new System.Drawing.Point(667, 41);
            this.textBoxAdi.Name = "textBoxAdi";
            this.textBoxAdi.Size = new System.Drawing.Size(100, 22);
            this.textBoxAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(568, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adı:";
            // 
            // buttonOgrenciEkle
            // 
            this.buttonOgrenciEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOgrenciEkle.Location = new System.Drawing.Point(611, 222);
            this.buttonOgrenciEkle.Name = "buttonOgrenciEkle";
            this.buttonOgrenciEkle.Size = new System.Drawing.Size(137, 43);
            this.buttonOgrenciEkle.TabIndex = 3;
            this.buttonOgrenciEkle.Text = "Öğrenci Ekle";
            this.buttonOgrenciEkle.UseVisualStyleBackColor = true;
            this.buttonOgrenciEkle.Click += new System.EventHandler(this.buttonOgrenciEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(568, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(555, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "TC Kimlik No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(568, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Şifre:";
            // 
            // textBoxSoyadi
            // 
            this.textBoxSoyadi.Location = new System.Drawing.Point(667, 84);
            this.textBoxSoyadi.Name = "textBoxSoyadi";
            this.textBoxSoyadi.Size = new System.Drawing.Size(100, 22);
            this.textBoxSoyadi.TabIndex = 7;
            // 
            // textBoxTC
            // 
            this.textBoxTC.Location = new System.Drawing.Point(667, 135);
            this.textBoxTC.Name = "textBoxTC";
            this.textBoxTC.Size = new System.Drawing.Size(100, 22);
            this.textBoxTC.TabIndex = 8;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(667, 184);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(100, 22);
            this.textBoxSifre.TabIndex = 9;
            // 
            // buttonOgrenciSil
            // 
            this.buttonOgrenciSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOgrenciSil.Location = new System.Drawing.Point(611, 271);
            this.buttonOgrenciSil.Name = "buttonOgrenciSil";
            this.buttonOgrenciSil.Size = new System.Drawing.Size(137, 43);
            this.buttonOgrenciSil.TabIndex = 10;
            this.buttonOgrenciSil.Text = "Öğrenci Sil";
            this.buttonOgrenciSil.UseVisualStyleBackColor = true;
            this.buttonOgrenciSil.Click += new System.EventHandler(this.buttonOgrenciSil_Click);
            // 
            // buttonOgrenciListele
            // 
            this.buttonOgrenciListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOgrenciListele.Location = new System.Drawing.Point(611, 320);
            this.buttonOgrenciListele.Name = "buttonOgrenciListele";
            this.buttonOgrenciListele.Size = new System.Drawing.Size(137, 43);
            this.buttonOgrenciListele.TabIndex = 11;
            this.buttonOgrenciListele.Text = "Öğrenci Listele";
            this.buttonOgrenciListele.UseVisualStyleBackColor = true;
            this.buttonOgrenciListele.Click += new System.EventHandler(this.buttonOgrenciListele_Click);
            // 
            // buttonGeriDon
            // 
            this.buttonGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGeriDon.Location = new System.Drawing.Point(611, 369);
            this.buttonGeriDon.Name = "buttonGeriDon";
            this.buttonGeriDon.Size = new System.Drawing.Size(137, 43);
            this.buttonGeriDon.TabIndex = 12;
            this.buttonGeriDon.Text = "Geri Dön";
            this.buttonGeriDon.UseVisualStyleBackColor = true;
            this.buttonGeriDon.Click += new System.EventHandler(this.buttonGeriDon_Click);
            // 
            // frmOgrenciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGeriDon);
            this.Controls.Add(this.buttonOgrenciListele);
            this.Controls.Add(this.buttonOgrenciSil);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxTC);
            this.Controls.Add(this.textBoxSoyadi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonOgrenciEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAdi);
            this.Controls.Add(this.dataGridViewOgrenciListesi);
            this.Name = "frmOgrenciIslemleri";
            this.Text = "frmOgrenciIslemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrenciListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOgrenciListesi;
        private System.Windows.Forms.TextBox textBoxAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOgrenciEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSoyadi;
        private System.Windows.Forms.TextBox textBoxTC;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Button buttonOgrenciSil;
        private System.Windows.Forms.Button buttonOgrenciListele;
        private System.Windows.Forms.Button buttonGeriDon;
    }
}
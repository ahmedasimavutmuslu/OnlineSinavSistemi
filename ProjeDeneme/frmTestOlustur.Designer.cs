
namespace ProjeDeneme
{
    partial class frmTestOlustur
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
            this.panelTestOlusturDersSec = new System.Windows.Forms.Panel();
            this.buttonTestDersSecimi = new System.Windows.Forms.Button();
            this.radioButtonTestSayisalAnaliz = new System.Windows.Forms.RadioButton();
            this.radioButtonTestPDP = new System.Windows.Forms.RadioButton();
            this.radioButtonTestNDP = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTestOlustur = new System.Windows.Forms.Button();
            this.dataGridViewSorular = new System.Windows.Forms.DataGridView();
            this.textBoxTestSinavTarihi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTestSinavSuresi = new System.Windows.Forms.TextBox();
            this.textBoxTestSoruSayisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOgrenciEkle = new System.Windows.Forms.Button();
            this.buttonSoruEkle = new System.Windows.Forms.Button();
            this.dataGridViewOgrenciListesi = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTestAdi = new System.Windows.Forms.TextBox();
            this.panelTestOlusturDersSec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSorular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrenciListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTestOlusturDersSec
            // 
            this.panelTestOlusturDersSec.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelTestOlusturDersSec.Controls.Add(this.buttonTestDersSecimi);
            this.panelTestOlusturDersSec.Controls.Add(this.radioButtonTestSayisalAnaliz);
            this.panelTestOlusturDersSec.Controls.Add(this.radioButtonTestPDP);
            this.panelTestOlusturDersSec.Controls.Add(this.radioButtonTestNDP);
            this.panelTestOlusturDersSec.Controls.Add(this.label1);
            this.panelTestOlusturDersSec.Location = new System.Drawing.Point(12, 11);
            this.panelTestOlusturDersSec.Name = "panelTestOlusturDersSec";
            this.panelTestOlusturDersSec.Size = new System.Drawing.Size(776, 518);
            this.panelTestOlusturDersSec.TabIndex = 0;
            this.panelTestOlusturDersSec.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTestOlusturDersSec_Paint);
            // 
            // buttonTestDersSecimi
            // 
            this.buttonTestDersSecimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTestDersSecimi.Location = new System.Drawing.Point(315, 241);
            this.buttonTestDersSecimi.Name = "buttonTestDersSecimi";
            this.buttonTestDersSecimi.Size = new System.Drawing.Size(162, 39);
            this.buttonTestDersSecimi.TabIndex = 4;
            this.buttonTestDersSecimi.Text = "Dersi Seç";
            this.buttonTestDersSecimi.UseVisualStyleBackColor = true;
            this.buttonTestDersSecimi.Click += new System.EventHandler(this.buttonTestDersSecimi_Click);
            // 
            // radioButtonTestSayisalAnaliz
            // 
            this.radioButtonTestSayisalAnaliz.AutoSize = true;
            this.radioButtonTestSayisalAnaliz.Location = new System.Drawing.Point(453, 158);
            this.radioButtonTestSayisalAnaliz.Name = "radioButtonTestSayisalAnaliz";
            this.radioButtonTestSayisalAnaliz.Size = new System.Drawing.Size(116, 21);
            this.radioButtonTestSayisalAnaliz.TabIndex = 3;
            this.radioButtonTestSayisalAnaliz.TabStop = true;
            this.radioButtonTestSayisalAnaliz.Text = "Sayısal Analiz";
            this.radioButtonTestSayisalAnaliz.UseVisualStyleBackColor = true;
            // 
            // radioButtonTestPDP
            // 
            this.radioButtonTestPDP.AutoSize = true;
            this.radioButtonTestPDP.Location = new System.Drawing.Point(338, 158);
            this.radioButtonTestPDP.Name = "radioButtonTestPDP";
            this.radioButtonTestPDP.Size = new System.Drawing.Size(57, 21);
            this.radioButtonTestPDP.TabIndex = 2;
            this.radioButtonTestPDP.TabStop = true;
            this.radioButtonTestPDP.Text = "PDP";
            this.radioButtonTestPDP.UseVisualStyleBackColor = true;
            // 
            // radioButtonTestNDP
            // 
            this.radioButtonTestNDP.AutoSize = true;
            this.radioButtonTestNDP.Location = new System.Drawing.Point(226, 158);
            this.radioButtonTestNDP.Name = "radioButtonTestNDP";
            this.radioButtonTestNDP.Size = new System.Drawing.Size(58, 21);
            this.radioButtonTestNDP.TabIndex = 1;
            this.radioButtonTestNDP.TabStop = true;
            this.radioButtonTestNDP.Text = "NDP";
            this.radioButtonTestNDP.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(210, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test Ouşturmak İstediğiniz Dersi Seçiniz!";
            // 
            // buttonTestOlustur
            // 
            this.buttonTestOlustur.Location = new System.Drawing.Point(34, 385);
            this.buttonTestOlustur.Name = "buttonTestOlustur";
            this.buttonTestOlustur.Size = new System.Drawing.Size(140, 52);
            this.buttonTestOlustur.TabIndex = 22;
            this.buttonTestOlustur.Text = "Testi Oluştur";
            this.buttonTestOlustur.UseVisualStyleBackColor = true;
            this.buttonTestOlustur.Click += new System.EventHandler(this.buttonTestOlustur_Click);
            // 
            // dataGridViewSorular
            // 
            this.dataGridViewSorular.AllowUserToAddRows = false;
            this.dataGridViewSorular.AllowUserToDeleteRows = false;
            this.dataGridViewSorular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSorular.Location = new System.Drawing.Point(226, 285);
            this.dataGridViewSorular.Name = "dataGridViewSorular";
            this.dataGridViewSorular.ReadOnly = true;
            this.dataGridViewSorular.RowHeadersWidth = 51;
            this.dataGridViewSorular.RowTemplate.Height = 24;
            this.dataGridViewSorular.Size = new System.Drawing.Size(559, 244);
            this.dataGridViewSorular.TabIndex = 21;
            this.dataGridViewSorular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // textBoxTestSinavTarihi
            // 
            this.textBoxTestSinavTarihi.Location = new System.Drawing.Point(104, 155);
            this.textBoxTestSinavTarihi.Name = "textBoxTestSinavTarihi";
            this.textBoxTestSinavTarihi.Size = new System.Drawing.Size(100, 22);
            this.textBoxTestSinavTarihi.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Soru Sayısı";
            // 
            // textBoxTestSinavSuresi
            // 
            this.textBoxTestSinavSuresi.Location = new System.Drawing.Point(104, 99);
            this.textBoxTestSinavSuresi.Name = "textBoxTestSinavSuresi";
            this.textBoxTestSinavSuresi.Size = new System.Drawing.Size(100, 22);
            this.textBoxTestSinavSuresi.TabIndex = 15;
            // 
            // textBoxTestSoruSayisi
            // 
            this.textBoxTestSoruSayisi.Location = new System.Drawing.Point(104, 56);
            this.textBoxTestSoruSayisi.Name = "textBoxTestSoruSayisi";
            this.textBoxTestSoruSayisi.Size = new System.Drawing.Size(100, 22);
            this.textBoxTestSoruSayisi.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(16, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 42);
            this.label3.TabIndex = 17;
            this.label3.Text = "Sınav Süresi (Dakika)";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(16, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 48);
            this.label4.TabIndex = 18;
            this.label4.Text = "Sınav Tarihi GG/AA/YY";
            // 
            // buttonOgrenciEkle
            // 
            this.buttonOgrenciEkle.Location = new System.Drawing.Point(34, 244);
            this.buttonOgrenciEkle.Name = "buttonOgrenciEkle";
            this.buttonOgrenciEkle.Size = new System.Drawing.Size(140, 52);
            this.buttonOgrenciEkle.TabIndex = 5;
            this.buttonOgrenciEkle.Text = "Öğrenci Ekle";
            this.buttonOgrenciEkle.UseVisualStyleBackColor = true;
            this.buttonOgrenciEkle.Click += new System.EventHandler(this.buttonOgrenciEkle_Click);
            // 
            // buttonSoruEkle
            // 
            this.buttonSoruEkle.Location = new System.Drawing.Point(34, 313);
            this.buttonSoruEkle.Name = "buttonSoruEkle";
            this.buttonSoruEkle.Size = new System.Drawing.Size(140, 52);
            this.buttonSoruEkle.TabIndex = 23;
            this.buttonSoruEkle.Text = "Soru Ekle";
            this.buttonSoruEkle.UseVisualStyleBackColor = true;
            this.buttonSoruEkle.Click += new System.EventHandler(this.buttonSoruEkle_Click);
            // 
            // dataGridViewOgrenciListesi
            // 
            this.dataGridViewOgrenciListesi.AllowUserToAddRows = false;
            this.dataGridViewOgrenciListesi.AllowUserToDeleteRows = false;
            this.dataGridViewOgrenciListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOgrenciListesi.Location = new System.Drawing.Point(226, 12);
            this.dataGridViewOgrenciListesi.Name = "dataGridViewOgrenciListesi";
            this.dataGridViewOgrenciListesi.ReadOnly = true;
            this.dataGridViewOgrenciListesi.RowHeadersWidth = 51;
            this.dataGridViewOgrenciListesi.RowTemplate.Height = 24;
            this.dataGridViewOgrenciListesi.Size = new System.Drawing.Size(559, 267);
            this.dataGridViewOgrenciListesi.TabIndex = 24;
            this.dataGridViewOgrenciListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(16, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Test Adı";
            // 
            // textBoxTestAdi
            // 
            this.textBoxTestAdi.Location = new System.Drawing.Point(104, 25);
            this.textBoxTestAdi.Name = "textBoxTestAdi";
            this.textBoxTestAdi.Size = new System.Drawing.Size(100, 22);
            this.textBoxTestAdi.TabIndex = 26;
            // 
            // frmTestOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.textBoxTestAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewOgrenciListesi);
            this.Controls.Add(this.dataGridViewSorular);
            this.Controls.Add(this.textBoxTestSinavTarihi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTestSinavSuresi);
            this.Controls.Add(this.buttonTestOlustur);
            this.Controls.Add(this.buttonSoruEkle);
            this.Controls.Add(this.buttonOgrenciEkle);
            this.Controls.Add(this.textBoxTestSoruSayisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelTestOlusturDersSec);
            this.Name = "frmTestOlustur";
            this.Text = "frmTestOlustur";
            this.Load += new System.EventHandler(this.frmTestOlustur_Load);
            this.panelTestOlusturDersSec.ResumeLayout(false);
            this.panelTestOlusturDersSec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSorular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrenciListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTestOlusturDersSec;
        private System.Windows.Forms.Button buttonTestDersSecimi;
        private System.Windows.Forms.RadioButton radioButtonTestSayisalAnaliz;
        private System.Windows.Forms.RadioButton radioButtonTestPDP;
        private System.Windows.Forms.RadioButton radioButtonTestNDP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTestOlustur;
        private System.Windows.Forms.DataGridView dataGridViewSorular;
        private System.Windows.Forms.TextBox textBoxTestSinavTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTestSinavSuresi;
        private System.Windows.Forms.TextBox textBoxTestSoruSayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSoruEkle;
        private System.Windows.Forms.Button buttonOgrenciEkle;
        private System.Windows.Forms.DataGridView dataGridViewOgrenciListesi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTestAdi;
    }
}

namespace ProjeDeneme
{
    partial class frmOgrenciSinav
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOgrenciSinav));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBoxSinavKurallari = new System.Windows.Forms.GroupBox();
            this.buttonSinaviBaslat = new System.Windows.Forms.Button();
            this.groupBoxSinav = new System.Windows.Forms.GroupBox();
            this.radioButtonCevapBes = new System.Windows.Forms.RadioButton();
            this.radioButtonCevapDort = new System.Windows.Forms.RadioButton();
            this.radioButtonCevapUc = new System.Windows.Forms.RadioButton();
            this.radioButtonCevapIki = new System.Windows.Forms.RadioButton();
            this.radioButtonCevapBir = new System.Windows.Forms.RadioButton();
            this.buttonSinaviBitir = new System.Windows.Forms.Button();
            this.buttonSonrakiSoru = new System.Windows.Forms.Button();
            this.textBoxGeriSayim = new System.Windows.Forms.TextBox();
            this.labelToplamSoru = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBulunanSoru = new System.Windows.Forms.Label();
            this.buttonOncekiSoru = new System.Windows.Forms.Button();
            this.richTextBoxSoruKoku = new System.Windows.Forms.RichTextBox();
            this.pictureBoxSoruGorsel = new System.Windows.Forms.PictureBox();
            this.timerSinavSuresi = new System.Windows.Forms.Timer(this.components);
            this.groupBoxSinavKurallari.SuspendLayout();
            this.groupBoxSinav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSoruGorsel)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(102, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(686, 332);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // groupBoxSinavKurallari
            // 
            this.groupBoxSinavKurallari.Controls.Add(this.buttonSinaviBaslat);
            this.groupBoxSinavKurallari.Controls.Add(this.richTextBox1);
            this.groupBoxSinavKurallari.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSinavKurallari.Name = "groupBoxSinavKurallari";
            this.groupBoxSinavKurallari.Size = new System.Drawing.Size(906, 554);
            this.groupBoxSinavKurallari.TabIndex = 1;
            this.groupBoxSinavKurallari.TabStop = false;
            // 
            // buttonSinaviBaslat
            // 
            this.buttonSinaviBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSinaviBaslat.Location = new System.Drawing.Point(292, 412);
            this.buttonSinaviBaslat.Name = "buttonSinaviBaslat";
            this.buttonSinaviBaslat.Size = new System.Drawing.Size(317, 45);
            this.buttonSinaviBaslat.TabIndex = 1;
            this.buttonSinaviBaslat.Text = "Anladım, sınavı başlatmak istiyorum.";
            this.buttonSinaviBaslat.UseVisualStyleBackColor = true;
            this.buttonSinaviBaslat.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxSinav
            // 
            this.groupBoxSinav.Controls.Add(this.radioButtonCevapBes);
            this.groupBoxSinav.Controls.Add(this.radioButtonCevapDort);
            this.groupBoxSinav.Controls.Add(this.radioButtonCevapUc);
            this.groupBoxSinav.Controls.Add(this.radioButtonCevapIki);
            this.groupBoxSinav.Controls.Add(this.radioButtonCevapBir);
            this.groupBoxSinav.Controls.Add(this.buttonSinaviBitir);
            this.groupBoxSinav.Controls.Add(this.buttonSonrakiSoru);
            this.groupBoxSinav.Controls.Add(this.textBoxGeriSayim);
            this.groupBoxSinav.Controls.Add(this.labelToplamSoru);
            this.groupBoxSinav.Controls.Add(this.label2);
            this.groupBoxSinav.Controls.Add(this.labelBulunanSoru);
            this.groupBoxSinav.Controls.Add(this.buttonOncekiSoru);
            this.groupBoxSinav.Controls.Add(this.richTextBoxSoruKoku);
            this.groupBoxSinav.Controls.Add(this.pictureBoxSoruGorsel);
            this.groupBoxSinav.Location = new System.Drawing.Point(6, 12);
            this.groupBoxSinav.Name = "groupBoxSinav";
            this.groupBoxSinav.Size = new System.Drawing.Size(906, 554);
            this.groupBoxSinav.TabIndex = 2;
            this.groupBoxSinav.TabStop = false;
            // 
            // radioButtonCevapBes
            // 
            this.radioButtonCevapBes.AutoSize = true;
            this.radioButtonCevapBes.Location = new System.Drawing.Point(474, 517);
            this.radioButtonCevapBes.Name = "radioButtonCevapBes";
            this.radioButtonCevapBes.Size = new System.Drawing.Size(17, 16);
            this.radioButtonCevapBes.TabIndex = 15;
            this.radioButtonCevapBes.TabStop = true;
            this.radioButtonCevapBes.UseVisualStyleBackColor = true;
            // 
            // radioButtonCevapDort
            // 
            this.radioButtonCevapDort.AutoSize = true;
            this.radioButtonCevapDort.Location = new System.Drawing.Point(474, 490);
            this.radioButtonCevapDort.Name = "radioButtonCevapDort";
            this.radioButtonCevapDort.Size = new System.Drawing.Size(17, 16);
            this.radioButtonCevapDort.TabIndex = 14;
            this.radioButtonCevapDort.TabStop = true;
            this.radioButtonCevapDort.UseVisualStyleBackColor = true;
            // 
            // radioButtonCevapUc
            // 
            this.radioButtonCevapUc.AutoSize = true;
            this.radioButtonCevapUc.Location = new System.Drawing.Point(474, 463);
            this.radioButtonCevapUc.Name = "radioButtonCevapUc";
            this.radioButtonCevapUc.Size = new System.Drawing.Size(17, 16);
            this.radioButtonCevapUc.TabIndex = 13;
            this.radioButtonCevapUc.TabStop = true;
            this.radioButtonCevapUc.UseVisualStyleBackColor = true;
            // 
            // radioButtonCevapIki
            // 
            this.radioButtonCevapIki.AutoSize = true;
            this.radioButtonCevapIki.Location = new System.Drawing.Point(474, 436);
            this.radioButtonCevapIki.Name = "radioButtonCevapIki";
            this.radioButtonCevapIki.Size = new System.Drawing.Size(17, 16);
            this.radioButtonCevapIki.TabIndex = 12;
            this.radioButtonCevapIki.TabStop = true;
            this.radioButtonCevapIki.UseVisualStyleBackColor = true;
            // 
            // radioButtonCevapBir
            // 
            this.radioButtonCevapBir.AutoSize = true;
            this.radioButtonCevapBir.Location = new System.Drawing.Point(474, 412);
            this.radioButtonCevapBir.Name = "radioButtonCevapBir";
            this.radioButtonCevapBir.Size = new System.Drawing.Size(17, 16);
            this.radioButtonCevapBir.TabIndex = 11;
            this.radioButtonCevapBir.TabStop = true;
            this.radioButtonCevapBir.UseVisualStyleBackColor = true;
            // 
            // buttonSinaviBitir
            // 
            this.buttonSinaviBitir.Location = new System.Drawing.Point(154, 464);
            this.buttonSinaviBitir.Name = "buttonSinaviBitir";
            this.buttonSinaviBitir.Size = new System.Drawing.Size(100, 28);
            this.buttonSinaviBitir.TabIndex = 10;
            this.buttonSinaviBitir.Text = "Sınavı Bitir";
            this.buttonSinaviBitir.UseVisualStyleBackColor = true;
            this.buttonSinaviBitir.Click += new System.EventHandler(this.buttonSinaviBitir_Click);
            // 
            // buttonSonrakiSoru
            // 
            this.buttonSonrakiSoru.Location = new System.Drawing.Point(308, 412);
            this.buttonSonrakiSoru.Name = "buttonSonrakiSoru";
            this.buttonSonrakiSoru.Size = new System.Drawing.Size(100, 28);
            this.buttonSonrakiSoru.TabIndex = 9;
            this.buttonSonrakiSoru.Text = "Sonraki Soru";
            this.buttonSonrakiSoru.UseVisualStyleBackColor = true;
            this.buttonSonrakiSoru.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxGeriSayim
            // 
            this.textBoxGeriSayim.Location = new System.Drawing.Point(774, 21);
            this.textBoxGeriSayim.Name = "textBoxGeriSayim";
            this.textBoxGeriSayim.ReadOnly = true;
            this.textBoxGeriSayim.Size = new System.Drawing.Size(100, 22);
            this.textBoxGeriSayim.TabIndex = 8;
            // 
            // labelToplamSoru
            // 
            this.labelToplamSoru.AutoSize = true;
            this.labelToplamSoru.Location = new System.Drawing.Point(76, 33);
            this.labelToplamSoru.Name = "labelToplamSoru";
            this.labelToplamSoru.Size = new System.Drawing.Size(0, 17);
            this.labelToplamSoru.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "/";
            // 
            // labelBulunanSoru
            // 
            this.labelBulunanSoru.AutoSize = true;
            this.labelBulunanSoru.Location = new System.Drawing.Point(6, 33);
            this.labelBulunanSoru.Name = "labelBulunanSoru";
            this.labelBulunanSoru.Size = new System.Drawing.Size(0, 17);
            this.labelBulunanSoru.TabIndex = 4;
            // 
            // buttonOncekiSoru
            // 
            this.buttonOncekiSoru.Location = new System.Drawing.Point(7, 412);
            this.buttonOncekiSoru.Name = "buttonOncekiSoru";
            this.buttonOncekiSoru.Size = new System.Drawing.Size(100, 28);
            this.buttonOncekiSoru.TabIndex = 2;
            this.buttonOncekiSoru.Text = "Önceki Soru";
            this.buttonOncekiSoru.UseVisualStyleBackColor = true;
            this.buttonOncekiSoru.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // richTextBoxSoruKoku
            // 
            this.richTextBoxSoruKoku.Location = new System.Drawing.Point(474, 53);
            this.richTextBoxSoruKoku.Name = "richTextBoxSoruKoku";
            this.richTextBoxSoruKoku.ReadOnly = true;
            this.richTextBoxSoruKoku.Size = new System.Drawing.Size(400, 325);
            this.richTextBoxSoruKoku.TabIndex = 1;
            this.richTextBoxSoruKoku.Text = "";
            // 
            // pictureBoxSoruGorsel
            // 
            this.pictureBoxSoruGorsel.Location = new System.Drawing.Point(6, 53);
            this.pictureBoxSoruGorsel.Name = "pictureBoxSoruGorsel";
            this.pictureBoxSoruGorsel.Size = new System.Drawing.Size(402, 325);
            this.pictureBoxSoruGorsel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSoruGorsel.TabIndex = 0;
            this.pictureBoxSoruGorsel.TabStop = false;
            // 
            // timerSinavSuresi
            // 
            this.timerSinavSuresi.Interval = 1000;
            this.timerSinavSuresi.Tick += new System.EventHandler(this.timerSinavSuresi_Tick);
            // 
            // frmOgrenciSinav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 578);
            this.Controls.Add(this.groupBoxSinav);
            this.Controls.Add(this.groupBoxSinavKurallari);
            this.Name = "frmOgrenciSinav";
            this.Text = "frmOgrenciSinav";
            this.groupBoxSinavKurallari.ResumeLayout(false);
            this.groupBoxSinav.ResumeLayout(false);
            this.groupBoxSinav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSoruGorsel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBoxSinavKurallari;
        private System.Windows.Forms.Button buttonSinaviBaslat;
        private System.Windows.Forms.GroupBox groupBoxSinav;
        private System.Windows.Forms.RadioButton radioButtonCevapBes;
        private System.Windows.Forms.RadioButton radioButtonCevapDort;
        private System.Windows.Forms.RadioButton radioButtonCevapUc;
        private System.Windows.Forms.RadioButton radioButtonCevapIki;
        private System.Windows.Forms.RadioButton radioButtonCevapBir;
        private System.Windows.Forms.Button buttonSinaviBitir;
        private System.Windows.Forms.Button buttonSonrakiSoru;
        private System.Windows.Forms.TextBox textBoxGeriSayim;
        private System.Windows.Forms.Label labelToplamSoru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBulunanSoru;
        private System.Windows.Forms.Button buttonOncekiSoru;
        private System.Windows.Forms.RichTextBox richTextBoxSoruKoku;
        private System.Windows.Forms.PictureBox pictureBoxSoruGorsel;
        private System.Windows.Forms.Timer timerSinavSuresi;
    }
}
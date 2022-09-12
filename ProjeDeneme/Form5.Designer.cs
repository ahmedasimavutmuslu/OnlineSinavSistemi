
namespace ProjeDeneme
{
    partial class frmOnlineSinavSistemi
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
            this.groupBoxDersSecimi = new System.Windows.Forms.GroupBox();
            this.buttonDersSec = new System.Windows.Forms.Button();
            this.radioButtonSayisalAnaliz = new System.Windows.Forms.RadioButton();
            this.radioButtonNDP = new System.Windows.Forms.RadioButton();
            this.radioButtonPDP = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSinavBaslat = new System.Windows.Forms.Button();
            this.buttonGeriDon = new System.Windows.Forms.Button();
            this.dataGridViewSinavListesi = new System.Windows.Forms.DataGridView();
            this.groupBoxDersSecimi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinavListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDersSecimi
            // 
            this.groupBoxDersSecimi.Controls.Add(this.buttonDersSec);
            this.groupBoxDersSecimi.Controls.Add(this.radioButtonSayisalAnaliz);
            this.groupBoxDersSecimi.Controls.Add(this.radioButtonNDP);
            this.groupBoxDersSecimi.Controls.Add(this.radioButtonPDP);
            this.groupBoxDersSecimi.Controls.Add(this.label1);
            this.groupBoxDersSecimi.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDersSecimi.Name = "groupBoxDersSecimi";
            this.groupBoxDersSecimi.Size = new System.Drawing.Size(776, 426);
            this.groupBoxDersSecimi.TabIndex = 0;
            this.groupBoxDersSecimi.TabStop = false;
            this.groupBoxDersSecimi.Enter += new System.EventHandler(this.groupBoxDersSecimi_Enter);
            // 
            // buttonDersSec
            // 
            this.buttonDersSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDersSec.Location = new System.Drawing.Point(327, 277);
            this.buttonDersSec.Name = "buttonDersSec";
            this.buttonDersSec.Size = new System.Drawing.Size(107, 34);
            this.buttonDersSec.TabIndex = 4;
            this.buttonDersSec.Text = "Ders Seç";
            this.buttonDersSec.UseVisualStyleBackColor = true;
            this.buttonDersSec.Click += new System.EventHandler(this.buttonDersSec_Click);
            // 
            // radioButtonSayisalAnaliz
            // 
            this.radioButtonSayisalAnaliz.AutoSize = true;
            this.radioButtonSayisalAnaliz.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonSayisalAnaliz.Location = new System.Drawing.Point(421, 218);
            this.radioButtonSayisalAnaliz.Name = "radioButtonSayisalAnaliz";
            this.radioButtonSayisalAnaliz.Size = new System.Drawing.Size(130, 21);
            this.radioButtonSayisalAnaliz.TabIndex = 3;
            this.radioButtonSayisalAnaliz.TabStop = true;
            this.radioButtonSayisalAnaliz.Text = "Sayısal Analiz";
            this.radioButtonSayisalAnaliz.UseVisualStyleBackColor = true;
            // 
            // radioButtonNDP
            // 
            this.radioButtonNDP.AutoSize = true;
            this.radioButtonNDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonNDP.Location = new System.Drawing.Point(239, 218);
            this.radioButtonNDP.Name = "radioButtonNDP";
            this.radioButtonNDP.Size = new System.Drawing.Size(61, 21);
            this.radioButtonNDP.TabIndex = 2;
            this.radioButtonNDP.TabStop = true;
            this.radioButtonNDP.Text = "NDP";
            this.radioButtonNDP.UseVisualStyleBackColor = true;
            // 
            // radioButtonPDP
            // 
            this.radioButtonPDP.AutoSize = true;
            this.radioButtonPDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonPDP.Location = new System.Drawing.Point(334, 218);
            this.radioButtonPDP.Name = "radioButtonPDP";
            this.radioButtonPDP.Size = new System.Drawing.Size(60, 21);
            this.radioButtonPDP.TabIndex = 1;
            this.radioButtonPDP.TabStop = true;
            this.radioButtonPDP.Text = "PDP";
            this.radioButtonPDP.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(165, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen sınavına girmek istediğiniz dersi seçiniz!";
            // 
            // buttonSinavBaslat
            // 
            this.buttonSinavBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSinavBaslat.Location = new System.Drawing.Point(488, 178);
            this.buttonSinavBaslat.Name = "buttonSinavBaslat";
            this.buttonSinavBaslat.Size = new System.Drawing.Size(118, 52);
            this.buttonSinavBaslat.TabIndex = 6;
            this.buttonSinavBaslat.Text = "Sınava Gir";
            this.buttonSinavBaslat.UseVisualStyleBackColor = true;
            this.buttonSinavBaslat.Click += new System.EventHandler(this.buttonSinavBaslat_Click);
            // 
            // buttonGeriDon
            // 
            this.buttonGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGeriDon.Location = new System.Drawing.Point(488, 254);
            this.buttonGeriDon.Name = "buttonGeriDon";
            this.buttonGeriDon.Size = new System.Drawing.Size(118, 70);
            this.buttonGeriDon.TabIndex = 7;
            this.buttonGeriDon.Text = "Ders Seçimine Geri Dön";
            this.buttonGeriDon.UseVisualStyleBackColor = true;
            this.buttonGeriDon.Click += new System.EventHandler(this.buttonGeriDon_Click);
            // 
            // dataGridViewSinavListesi
            // 
            this.dataGridViewSinavListesi.AllowUserToAddRows = false;
            this.dataGridViewSinavListesi.AllowUserToDeleteRows = false;
            this.dataGridViewSinavListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSinavListesi.Location = new System.Drawing.Point(47, 75);
            this.dataGridViewSinavListesi.Name = "dataGridViewSinavListesi";
            this.dataGridViewSinavListesi.ReadOnly = true;
            this.dataGridViewSinavListesi.RowHeadersWidth = 51;
            this.dataGridViewSinavListesi.RowTemplate.Height = 24;
            this.dataGridViewSinavListesi.Size = new System.Drawing.Size(362, 331);
            this.dataGridViewSinavListesi.TabIndex = 8;
            this.dataGridViewSinavListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSinavListesi_CellContentClick);
            // 
            // frmOnlineSinavSistemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxDersSecimi);
            this.Controls.Add(this.buttonSinavBaslat);
            this.Controls.Add(this.buttonGeriDon);
            this.Controls.Add(this.dataGridViewSinavListesi);
            this.Name = "frmOnlineSinavSistemi";
            this.Text = "Online Sınav Sistemi";
            this.Load += new System.EventHandler(this.frmOnlineSinavSistemi_Load);
            this.groupBoxDersSecimi.ResumeLayout(false);
            this.groupBoxDersSecimi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinavListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDersSecimi;
        private System.Windows.Forms.Button buttonDersSec;
        private System.Windows.Forms.RadioButton radioButtonSayisalAnaliz;
        private System.Windows.Forms.RadioButton radioButtonNDP;
        private System.Windows.Forms.RadioButton radioButtonPDP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSinavBaslat;
        private System.Windows.Forms.Button buttonGeriDon;
        private System.Windows.Forms.DataGridView dataGridViewSinavListesi;
    }
}
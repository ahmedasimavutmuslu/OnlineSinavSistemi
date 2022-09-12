
namespace ProjeDeneme
{
    partial class frmBasariGrafigi
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartBasariGrafigi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radioButtonNDP = new System.Windows.Forms.RadioButton();
            this.radioButtonPDP = new System.Windows.Forms.RadioButton();
            this.radioButtonSayisalAnaliz = new System.Windows.Forms.RadioButton();
            this.buttonDersSec = new System.Windows.Forms.Button();
            this.dataGridViewSinavListesi = new System.Windows.Forms.DataGridView();
            this.buttonGrafikGoster = new System.Windows.Forms.Button();
            this.buttonGeriDon = new System.Windows.Forms.Button();
            this.dataGridViewSonucListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chartBasariGrafigi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinavListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSonucListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // chartBasariGrafigi
            // 
            chartArea2.Name = "ChartArea1";
            this.chartBasariGrafigi.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartBasariGrafigi.Legends.Add(legend2);
            this.chartBasariGrafigi.Location = new System.Drawing.Point(12, 12);
            this.chartBasariGrafigi.Name = "chartBasariGrafigi";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartBasariGrafigi.Series.Add(series2);
            this.chartBasariGrafigi.Size = new System.Drawing.Size(478, 416);
            this.chartBasariGrafigi.TabIndex = 0;
            this.chartBasariGrafigi.Text = "chart1";
            // 
            // radioButtonNDP
            // 
            this.radioButtonNDP.AutoSize = true;
            this.radioButtonNDP.Location = new System.Drawing.Point(613, 31);
            this.radioButtonNDP.Name = "radioButtonNDP";
            this.radioButtonNDP.Size = new System.Drawing.Size(58, 21);
            this.radioButtonNDP.TabIndex = 1;
            this.radioButtonNDP.TabStop = true;
            this.radioButtonNDP.Text = "NDP";
            this.radioButtonNDP.UseVisualStyleBackColor = true;
            // 
            // radioButtonPDP
            // 
            this.radioButtonPDP.AutoSize = true;
            this.radioButtonPDP.Location = new System.Drawing.Point(694, 31);
            this.radioButtonPDP.Name = "radioButtonPDP";
            this.radioButtonPDP.Size = new System.Drawing.Size(57, 21);
            this.radioButtonPDP.TabIndex = 2;
            this.radioButtonPDP.TabStop = true;
            this.radioButtonPDP.Text = "PDP";
            this.radioButtonPDP.UseVisualStyleBackColor = true;
            // 
            // radioButtonSayisalAnaliz
            // 
            this.radioButtonSayisalAnaliz.AutoSize = true;
            this.radioButtonSayisalAnaliz.Location = new System.Drawing.Point(770, 31);
            this.radioButtonSayisalAnaliz.Name = "radioButtonSayisalAnaliz";
            this.radioButtonSayisalAnaliz.Size = new System.Drawing.Size(116, 21);
            this.radioButtonSayisalAnaliz.TabIndex = 3;
            this.radioButtonSayisalAnaliz.TabStop = true;
            this.radioButtonSayisalAnaliz.Text = "Sayısal Analiz";
            this.radioButtonSayisalAnaliz.UseVisualStyleBackColor = true;
            // 
            // buttonDersSec
            // 
            this.buttonDersSec.Location = new System.Drawing.Point(704, 71);
            this.buttonDersSec.Name = "buttonDersSec";
            this.buttonDersSec.Size = new System.Drawing.Size(90, 23);
            this.buttonDersSec.TabIndex = 4;
            this.buttonDersSec.Text = "Ders Seç";
            this.buttonDersSec.UseVisualStyleBackColor = true;
            this.buttonDersSec.Click += new System.EventHandler(this.buttonDersSec_Click);
            // 
            // dataGridViewSinavListesi
            // 
            this.dataGridViewSinavListesi.AllowUserToAddRows = false;
            this.dataGridViewSinavListesi.AllowUserToDeleteRows = false;
            this.dataGridViewSinavListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSinavListesi.Location = new System.Drawing.Point(563, 142);
            this.dataGridViewSinavListesi.Name = "dataGridViewSinavListesi";
            this.dataGridViewSinavListesi.ReadOnly = true;
            this.dataGridViewSinavListesi.RowHeadersWidth = 51;
            this.dataGridViewSinavListesi.RowTemplate.Height = 24;
            this.dataGridViewSinavListesi.Size = new System.Drawing.Size(171, 286);
            this.dataGridViewSinavListesi.TabIndex = 5;
            this.dataGridViewSinavListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSinavListesi_CellClick);
            // 
            // buttonGrafikGoster
            // 
            this.buttonGrafikGoster.Location = new System.Drawing.Point(644, 453);
            this.buttonGrafikGoster.Name = "buttonGrafikGoster";
            this.buttonGrafikGoster.Size = new System.Drawing.Size(90, 79);
            this.buttonGrafikGoster.TabIndex = 6;
            this.buttonGrafikGoster.Text = "Başarı Grafiğini Gör";
            this.buttonGrafikGoster.UseVisualStyleBackColor = true;
            this.buttonGrafikGoster.Click += new System.EventHandler(this.buttonGrafikGoster_Click);
            // 
            // buttonGeriDon
            // 
            this.buttonGeriDon.Location = new System.Drawing.Point(761, 453);
            this.buttonGeriDon.Name = "buttonGeriDon";
            this.buttonGeriDon.Size = new System.Drawing.Size(90, 79);
            this.buttonGeriDon.TabIndex = 7;
            this.buttonGeriDon.Text = "Geri Dön";
            this.buttonGeriDon.UseVisualStyleBackColor = true;
            this.buttonGeriDon.Click += new System.EventHandler(this.buttonGeriDon_Click);
            // 
            // dataGridViewSonucListesi
            // 
            this.dataGridViewSonucListesi.AllowUserToAddRows = false;
            this.dataGridViewSonucListesi.AllowUserToDeleteRows = false;
            this.dataGridViewSonucListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSonucListesi.Location = new System.Drawing.Point(761, 142);
            this.dataGridViewSonucListesi.Name = "dataGridViewSonucListesi";
            this.dataGridViewSonucListesi.ReadOnly = true;
            this.dataGridViewSonucListesi.RowHeadersWidth = 51;
            this.dataGridViewSonucListesi.RowTemplate.Height = 24;
            this.dataGridViewSonucListesi.Size = new System.Drawing.Size(171, 286);
            this.dataGridViewSonucListesi.TabIndex = 8;
            // 
            // frmBasariGrafigi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 580);
            this.Controls.Add(this.dataGridViewSonucListesi);
            this.Controls.Add(this.buttonGeriDon);
            this.Controls.Add(this.buttonGrafikGoster);
            this.Controls.Add(this.dataGridViewSinavListesi);
            this.Controls.Add(this.buttonDersSec);
            this.Controls.Add(this.radioButtonSayisalAnaliz);
            this.Controls.Add(this.radioButtonPDP);
            this.Controls.Add(this.radioButtonNDP);
            this.Controls.Add(this.chartBasariGrafigi);
            this.Name = "frmBasariGrafigi";
            this.Text = "frmBasariGrafigi";
            ((System.ComponentModel.ISupportInitialize)(this.chartBasariGrafigi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinavListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSonucListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartBasariGrafigi;
        private System.Windows.Forms.RadioButton radioButtonNDP;
        private System.Windows.Forms.RadioButton radioButtonPDP;
        private System.Windows.Forms.RadioButton radioButtonSayisalAnaliz;
        private System.Windows.Forms.Button buttonDersSec;
        private System.Windows.Forms.DataGridView dataGridViewSinavListesi;
        private System.Windows.Forms.Button buttonGrafikGoster;
        private System.Windows.Forms.Button buttonGeriDon;
        private System.Windows.Forms.DataGridView dataGridViewSonucListesi;
    }
}
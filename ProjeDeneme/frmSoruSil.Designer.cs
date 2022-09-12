
namespace ProjeDeneme
{
    partial class frmSoruSil
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
            this.bttnSoruListele = new System.Windows.Forms.Button();
            this.bttnSoruSil = new System.Windows.Forms.Button();
            this.bttnGeriDon = new System.Windows.Forms.Button();
            this.dataGridViewSoruListe = new System.Windows.Forms.DataGridView();
            this.radioButtonListeleSayisalAnaliz = new System.Windows.Forms.RadioButton();
            this.radioButtonListelePDP = new System.Windows.Forms.RadioButton();
            this.radioButtonListeleNDP = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoruListe)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnSoruListele
            // 
            this.bttnSoruListele.Location = new System.Drawing.Point(689, 297);
            this.bttnSoruListele.Name = "bttnSoruListele";
            this.bttnSoruListele.Size = new System.Drawing.Size(75, 43);
            this.bttnSoruListele.TabIndex = 0;
            this.bttnSoruListele.Text = "Listele";
            this.bttnSoruListele.UseVisualStyleBackColor = true;
            this.bttnSoruListele.Click += new System.EventHandler(this.bttnSoruListele_Click);
            // 
            // bttnSoruSil
            // 
            this.bttnSoruSil.Location = new System.Drawing.Point(689, 346);
            this.bttnSoruSil.Name = "bttnSoruSil";
            this.bttnSoruSil.Size = new System.Drawing.Size(75, 43);
            this.bttnSoruSil.TabIndex = 1;
            this.bttnSoruSil.Text = "Soruyu Sil";
            this.bttnSoruSil.UseVisualStyleBackColor = true;
            this.bttnSoruSil.Click += new System.EventHandler(this.bttnSoruSil_Click);
            // 
            // bttnGeriDon
            // 
            this.bttnGeriDon.Location = new System.Drawing.Point(689, 395);
            this.bttnGeriDon.Name = "bttnGeriDon";
            this.bttnGeriDon.Size = new System.Drawing.Size(75, 43);
            this.bttnGeriDon.TabIndex = 2;
            this.bttnGeriDon.Text = "Geri Dön";
            this.bttnGeriDon.UseVisualStyleBackColor = true;
            this.bttnGeriDon.Click += new System.EventHandler(this.bttnGeriDon_Click);
            // 
            // dataGridViewSoruListe
            // 
            this.dataGridViewSoruListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSoruListe.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewSoruListe.Name = "dataGridViewSoruListe";
            this.dataGridViewSoruListe.RowHeadersWidth = 51;
            this.dataGridViewSoruListe.RowTemplate.Height = 24;
            this.dataGridViewSoruListe.Size = new System.Drawing.Size(627, 426);
            this.dataGridViewSoruListe.TabIndex = 3;
            // 
            // radioButtonListeleSayisalAnaliz
            // 
            this.radioButtonListeleSayisalAnaliz.AutoSize = true;
            this.radioButtonListeleSayisalAnaliz.Location = new System.Drawing.Point(689, 182);
            this.radioButtonListeleSayisalAnaliz.Name = "radioButtonListeleSayisalAnaliz";
            this.radioButtonListeleSayisalAnaliz.Size = new System.Drawing.Size(116, 21);
            this.radioButtonListeleSayisalAnaliz.TabIndex = 4;
            this.radioButtonListeleSayisalAnaliz.TabStop = true;
            this.radioButtonListeleSayisalAnaliz.Text = "Sayısal Analiz";
            this.radioButtonListeleSayisalAnaliz.UseVisualStyleBackColor = true;
            // 
            // radioButtonListelePDP
            // 
            this.radioButtonListelePDP.AutoSize = true;
            this.radioButtonListelePDP.Location = new System.Drawing.Point(689, 155);
            this.radioButtonListelePDP.Name = "radioButtonListelePDP";
            this.radioButtonListelePDP.Size = new System.Drawing.Size(57, 21);
            this.radioButtonListelePDP.TabIndex = 5;
            this.radioButtonListelePDP.TabStop = true;
            this.radioButtonListelePDP.Text = "PDP";
            this.radioButtonListelePDP.UseVisualStyleBackColor = true;
            // 
            // radioButtonListeleNDP
            // 
            this.radioButtonListeleNDP.AutoSize = true;
            this.radioButtonListeleNDP.Location = new System.Drawing.Point(689, 128);
            this.radioButtonListeleNDP.Name = "radioButtonListeleNDP";
            this.radioButtonListeleNDP.Size = new System.Drawing.Size(58, 21);
            this.radioButtonListeleNDP.TabIndex = 6;
            this.radioButtonListeleNDP.TabStop = true;
            this.radioButtonListeleNDP.Text = "NDP";
            this.radioButtonListeleNDP.UseVisualStyleBackColor = true;
            // 
            // frmSoruSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonListeleNDP);
            this.Controls.Add(this.radioButtonListelePDP);
            this.Controls.Add(this.radioButtonListeleSayisalAnaliz);
            this.Controls.Add(this.dataGridViewSoruListe);
            this.Controls.Add(this.bttnGeriDon);
            this.Controls.Add(this.bttnSoruSil);
            this.Controls.Add(this.bttnSoruListele);
            this.Name = "frmSoruSil";
            this.Text = "frmSoruSil";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoruListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnSoruListele;
        private System.Windows.Forms.Button bttnSoruSil;
        private System.Windows.Forms.Button bttnGeriDon;
        private System.Windows.Forms.DataGridView dataGridViewSoruListe;
        private System.Windows.Forms.RadioButton radioButtonListeleSayisalAnaliz;
        private System.Windows.Forms.RadioButton radioButtonListelePDP;
        private System.Windows.Forms.RadioButton radioButtonListeleNDP;
    }
}
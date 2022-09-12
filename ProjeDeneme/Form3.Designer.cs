
namespace ProjeDeneme
{
    partial class frmOgretmen
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soruEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soruEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.soruSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciSeçenekleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.başarıListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testOluşturToolStripMenuItem,
            this.soruEkleToolStripMenuItem,
            this.öğrenciSeçenekleriToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testOluşturToolStripMenuItem
            // 
            this.testOluşturToolStripMenuItem.Name = "testOluşturToolStripMenuItem";
            this.testOluşturToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.testOluşturToolStripMenuItem.Text = "Test Oluştur";
            this.testOluşturToolStripMenuItem.Click += new System.EventHandler(this.testOluşturToolStripMenuItem_Click);
            // 
            // soruEkleToolStripMenuItem
            // 
            this.soruEkleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soruEkleToolStripMenuItem1,
            this.soruSilToolStripMenuItem});
            this.soruEkleToolStripMenuItem.Name = "soruEkleToolStripMenuItem";
            this.soruEkleToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.soruEkleToolStripMenuItem.Text = "Soru Seçenekleri";
            // 
            // soruEkleToolStripMenuItem1
            // 
            this.soruEkleToolStripMenuItem1.Name = "soruEkleToolStripMenuItem1";
            this.soruEkleToolStripMenuItem1.Size = new System.Drawing.Size(153, 26);
            this.soruEkleToolStripMenuItem1.Text = "Soru Ekle";
            this.soruEkleToolStripMenuItem1.Click += new System.EventHandler(this.soruEkleToolStripMenuItem1_Click);
            // 
            // soruSilToolStripMenuItem
            // 
            this.soruSilToolStripMenuItem.Name = "soruSilToolStripMenuItem";
            this.soruSilToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.soruSilToolStripMenuItem.Text = "Soru Sil";
            this.soruSilToolStripMenuItem.Click += new System.EventHandler(this.soruSilToolStripMenuItem_Click);
            // 
            // öğrenciSeçenekleriToolStripMenuItem
            // 
            this.öğrenciSeçenekleriToolStripMenuItem.Name = "öğrenciSeçenekleriToolStripMenuItem";
            this.öğrenciSeçenekleriToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.öğrenciSeçenekleriToolStripMenuItem.Text = "Öğrenci Seçenekleri";
            this.öğrenciSeçenekleriToolStripMenuItem.Click += new System.EventHandler(this.öğrenciSeçenekleriToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.başarıListesiToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // başarıListesiToolStripMenuItem
            // 
            this.başarıListesiToolStripMenuItem.Name = "başarıListesiToolStripMenuItem";
            this.başarıListesiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.başarıListesiToolStripMenuItem.Text = "Başarı Grafiği";
            this.başarıListesiToolStripMenuItem.Click += new System.EventHandler(this.başarıListesiToolStripMenuItem_Click);
            // 
            // frmOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmOgretmen";
            this.Text = "Soru Ekleme Sistemi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soruEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soruEkleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem soruSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciSeçenekleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem başarıListesiToolStripMenuItem;
    }
}
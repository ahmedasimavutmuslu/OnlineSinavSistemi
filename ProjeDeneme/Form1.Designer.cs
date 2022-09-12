
namespace ProjeDeneme
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.bttnOgretmenGiris = new System.Windows.Forms.Button();
            this.bttnOgrenciGiris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnOgretmenGiris
            // 
            this.bttnOgretmenGiris.BackColor = System.Drawing.Color.LightCoral;
            this.bttnOgretmenGiris.Location = new System.Drawing.Point(109, 265);
            this.bttnOgretmenGiris.Name = "bttnOgretmenGiris";
            this.bttnOgretmenGiris.Size = new System.Drawing.Size(161, 93);
            this.bttnOgretmenGiris.TabIndex = 0;
            this.bttnOgretmenGiris.Text = "Öğretmen Girişi";
            this.bttnOgretmenGiris.UseVisualStyleBackColor = false;
            this.bttnOgretmenGiris.Click += new System.EventHandler(this.bttnOgretmenGiris_Click);
            // 
            // bttnOgrenciGiris
            // 
            this.bttnOgrenciGiris.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttnOgrenciGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttnOgrenciGiris.Location = new System.Drawing.Point(528, 265);
            this.bttnOgrenciGiris.Name = "bttnOgrenciGiris";
            this.bttnOgrenciGiris.Size = new System.Drawing.Size(161, 93);
            this.bttnOgrenciGiris.TabIndex = 1;
            this.bttnOgrenciGiris.Text = "Öğrenci Girişi";
            this.bttnOgrenciGiris.UseVisualStyleBackColor = false;
            this.bttnOgrenciGiris.Click += new System.EventHandler(this.bttnOgrenciGiris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(109, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(528, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 152);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttnOgrenciGiris);
            this.Controls.Add(this.bttnOgretmenGiris);
            this.Name = "FrmGiris";
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnOgretmenGiris;
        private System.Windows.Forms.Button bttnOgrenciGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}



namespace Ürün_Sepeti
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.urunListesi = new System.Windows.Forms.ListBox();
            this.urunAdı = new System.Windows.Forms.TextBox();
            this.ekle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.urunSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fiyat = new System.Windows.Forms.TextBox();
            this.sonSil = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.odecenekTutar = new System.Windows.Forms.Label();
            this.kargoUcreti = new System.Windows.Forms.Label();
            this.sepetToplam = new System.Windows.Forms.Label();
            this.kdv = new System.Windows.Forms.Label();
            this.sepetTutari = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // urunListesi
            // 
            this.urunListesi.FormattingEnabled = true;
            this.urunListesi.ItemHeight = 17;
            this.urunListesi.Location = new System.Drawing.Point(15, 122);
            this.urunListesi.Name = "urunListesi";
            this.urunListesi.Size = new System.Drawing.Size(289, 310);
            this.urunListesi.TabIndex = 0;
            this.urunListesi.SelectedIndexChanged += new System.EventHandler(this.urunListesi_SelectedIndexChanged);
            // 
            // urunAdı
            // 
            this.urunAdı.Location = new System.Drawing.Point(15, 57);
            this.urunAdı.Name = "urunAdı";
            this.urunAdı.Size = new System.Drawing.Size(230, 23);
            this.urunAdı.TabIndex = 2;
            this.urunAdı.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ekle
            // 
            this.ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ekle.Location = new System.Drawing.Point(15, 91);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(289, 26);
            this.ekle.TabIndex = 3;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.urunSil);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fiyat);
            this.groupBox1.Controls.Add(this.urunListesi);
            this.groupBox1.Controls.Add(this.ekle);
            this.groupBox1.Controls.Add(this.urunAdı);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 472);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekle-Sil";
            // 
            // urunSil
            // 
            this.urunSil.Location = new System.Drawing.Point(15, 443);
            this.urunSil.Name = "urunSil";
            this.urunSil.Size = new System.Drawing.Size(289, 23);
            this.urunSil.TabIndex = 11;
            this.urunSil.Text = "Ürün Sil";
            this.urunSil.UseVisualStyleBackColor = true;
            this.urunSil.Click += new System.EventHandler(this.urunSil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fiyat (₺)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ürün Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fiyat
            // 
            this.fiyat.Location = new System.Drawing.Point(252, 57);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(52, 23);
            this.fiyat.TabIndex = 4;
            this.fiyat.TextChanged += new System.EventHandler(this.fiyat_TextChanged);
            // 
            // sonSil
            // 
            this.sonSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sonSil.Location = new System.Drawing.Point(346, 454);
            this.sonSil.Name = "sonSil";
            this.sonSil.Size = new System.Drawing.Size(249, 23);
            this.sonSil.TabIndex = 10;
            this.sonSil.Text = "Sepeti Temizle";
            this.sonSil.UseVisualStyleBackColor = true;
            this.sonSil.Click += new System.EventHandler(this.sonSil_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.odecenekTutar);
            this.groupBox2.Controls.Add(this.kargoUcreti);
            this.groupBox2.Controls.Add(this.sepetToplam);
            this.groupBox2.Controls.Add(this.kdv);
            this.groupBox2.Controls.Add(this.sepetTutari);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(346, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 443);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sepet Bilgileri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // odecenekTutar
            // 
            this.odecenekTutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.odecenekTutar.Location = new System.Drawing.Point(114, 139);
            this.odecenekTutar.Name = "odecenekTutar";
            this.odecenekTutar.Size = new System.Drawing.Size(130, 17);
            this.odecenekTutar.TabIndex = 10;
            this.odecenekTutar.Text = "0";
            this.odecenekTutar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // kargoUcreti
            // 
            this.kargoUcreti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kargoUcreti.Location = new System.Drawing.Point(114, 97);
            this.kargoUcreti.Name = "kargoUcreti";
            this.kargoUcreti.Size = new System.Drawing.Size(130, 17);
            this.kargoUcreti.TabIndex = 9;
            this.kargoUcreti.Text = "0";
            this.kargoUcreti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sepetToplam
            // 
            this.sepetToplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sepetToplam.Location = new System.Drawing.Point(114, 75);
            this.sepetToplam.Name = "sepetToplam";
            this.sepetToplam.Size = new System.Drawing.Size(130, 17);
            this.sepetToplam.TabIndex = 8;
            this.sepetToplam.Text = "0";
            this.sepetToplam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // kdv
            // 
            this.kdv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kdv.Location = new System.Drawing.Point(114, 53);
            this.kdv.Name = "kdv";
            this.kdv.Size = new System.Drawing.Size(130, 17);
            this.kdv.TabIndex = 7;
            this.kdv.Text = "0";
            this.kdv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sepetTutari
            // 
            this.sepetTutari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sepetTutari.Location = new System.Drawing.Point(114, 31);
            this.sepetTutari.Name = "sepetTutari";
            this.sepetTutari.Size = new System.Drawing.Size(130, 18);
            this.sepetTutari.TabIndex = 6;
            this.sepetTutari.Text = "0";
            this.sepetTutari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sepetTutari.Click += new System.EventHandler(this.sepetTutari_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Kargo ücreti 150₺ üzeri ücretsizdir.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ödenecek Tutar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Kargo Ücreti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sepet Toplam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "KDV (%18)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sepet Tutarı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(321, 490);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(275, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Powered by Asnus -Design By Serdar Sunman";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 516);
            this.Controls.Add(this.sonSil);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "ÜrünSepetim.com";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox urunListesi;
        private System.Windows.Forms.TextBox urunAdı;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button sonSil;
        private System.Windows.Forms.Label odecenekTutar;
        private System.Windows.Forms.Label kargoUcreti;
        private System.Windows.Forms.Label sepetToplam;
        private System.Windows.Forms.Label kdv;
        private System.Windows.Forms.Label sepetTutari;
        private System.Windows.Forms.Button urunSil;
    }
}


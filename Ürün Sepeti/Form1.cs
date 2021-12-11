using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ürün_Sepeti
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            double SepetTutari = 0;
        }

        public void string_Atama()
        {
            sepetTutari.Text = SepetTutari.ToString();
            kdv.Text = kdvT.ToString();
            sepetToplam.Text = SepetToplami.ToString();
            kargoUcreti.Text = KargoUcreti.ToString();
            odecenekTutar.Text = OdenecekTutar.ToString();
        }

        double SepetTutari = 0, kdvT = 0, SepetToplami = 0, KargoUcreti = 0, OdenecekTutar = 0;
        public void deger_Sifirlama()
        {
            SepetTutari = 0;
            kdvT = 0;
            SepetToplami = 0;
            KargoUcreti = 0;
            OdenecekTutar = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (urunAdı.Text == "" || fiyat.Text == "")
            {
                MessageBox.Show("Değerlerde hata bulunmakta. Girilen değeri kontrol ediniz.", "Uyarı!", MessageBoxButtons.OK);
            }
            else
            { 
            string urun;
            double tutar;
            urun = Convert.ToString(urunAdı.Text);
            tutar = Convert.ToDouble(fiyat.Text);
            OdenecekTutar = Math.Round(OdenecekTutar, 2);

            SepetTutari = SepetTutari + tutar;
            kdvT = SepetTutari * 18 / 100;
            SepetToplami = kdvT + SepetTutari;

            if (SepetToplami <= 150)
            {
                KargoUcreti = 6.99;
            }
            else KargoUcreti = 0;

            OdenecekTutar = SepetToplami + KargoUcreti;

            urunListesi.Items.Add(urun+" ("+tutar+"₺)");
            string_Atama();

            urunAdı.Clear();
            fiyat.Clear();
            }
        }

        private void urunSil_Click(object sender, EventArgs e)
        {
            urunListesi.Items.Remove(urunListesi.SelectedItem);


        }

        private void fiyat_TextChanged(object sender, EventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void sonSil_Click(object sender, EventArgs e)
        {
            urunListesi.Items.Clear();
            deger_Sifirlama();
            string_Atama();
        }

        private void urunListesi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sepetTutari_Click(object sender, EventArgs e)
        {

        }
    }
}

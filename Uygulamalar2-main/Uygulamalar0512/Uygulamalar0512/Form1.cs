using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uygulamalar0512.Siniflar;

namespace Uygulamalar0512
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        static int topla(int a, int b) //1.ornek iki sayının toplamı
        {
            return a + b;
        }

        static double faizHesaplama(double anapara, double faiz, int gun)   //2.örnek faiz hesalama
        {
            return (anapara * (faiz / 100) / 365) * gun;
        }

        void usHesaplama( int taban, int us) //3.örnek us hesaplama
        {
            int sonuc = 1;
            for (int i = 0; i < us; i++)
            {
                sonuc = sonuc * taban;
            }
            
            sonuclbl.Text = sonuc.ToString();

        }

        static float ikiiletopla(float sayi1) // 4.örnek hesap makinesi
        {
            return sayi1+=2 ;
        }

        static float ikiileazalt(float sayi1)
        {
            return sayi1-=2 ;
        }

        static float ikiilecarp(float sayi)
        {
            return sayi *= 2;
        }
        
        static float ikiilebol(float sayi)
        {
            return sayi /= 2;
        }
        static float biriletopla(float sayi)
        {
            return sayi +=1;
        }
        static float birileazalt(float sayi)
        {
            return sayi -=1;
        }
        static float modalma(float sayi) //4.son ornek 
        {
            return sayi %=2;
        }
        
        void sayiTahmini(int tutulan, int tahmin) // 5.ornek 
        {
            
            if (!(tahmin > 0 && tahmin <= 10))
            {
                aciklamalbl.Text = "Girilen sayı 1 ile 10 arasında olmalı ";
                sayac++;
            }


            else if (tahmin > tutulan)
            {
                aciklamalbl.Text = "Tahmin edilen sayı tutulan sayıdan büyüktür.";
                sayac++;
            }

            else if (tahmin < tutulan)
            {
                aciklamalbl.Text = "Tahmin edilen sayı tutulan sayıdan küçüktür. ";
                sayac = sayac + 1;

            }
            else
            {
                aciklamalbl.Text = "Tebrikler " + sayac + " kerede tahmin ettiniz :)";
            }
        }

        void TekmiCiftmi(int val, string girilensayi)
        {
            
            if (!Int32.TryParse(girilensayi, out val))
            {
                aciklamalbl1.Text = "Dönüşüm yapılamadı. Lütfen sayı giriniz.  ";
            }

            else
            {
                if (val < 0)
                {
                    aciklamalbl1.Text = "Girilen sayı negatiftir.";
                }

                else if (val % 2 == 0)
                {
                    aciklamalbl1.Text = "Girilen sayı çifttir";
                }
                else
                {
                    aciklamalbl1.Text = "Girilen sayı tektir.";
                }
            }
        }

        void mükemmelSayi(int sayi, int toplam)
        {
            
            for (int i = 1; i <= sayi / 2; i++)
            {

                if (sayi % i == 0)
                {
                    toplam = toplam + i;
                }
            }
            if (sayi == toplam)
            {
                aciklamalbl3.Text = "Girilen sayı mükemmel sayıdır ";
            }
            else
            {
                aciklamalbl3.Text = "Girilen sayı mükemmel sayı değildir. ";
            }
            
        }

        void notHesaplama(int not)
        {
           

            if (not <= 50 && not >= 0)
            {
                aciklamalbl4.Text = " Kaldınız: FF";
            }
            else if (not > 50 && not < 55)
            {
                aciklamalbl4.Text = " Geçtiniz: DD";
            }
            else if (not >= 55 && not < 69)
            {
                aciklamalbl4.Text = " Geçtiniz: CC";
            }
            else if (not >= 69 && not < 80)
            {
                aciklamalbl4.Text = " Geçtiniz: BC";
            }
            else if (not >= 80 && not <= 90)
            {
                aciklamalbl4.Text = "Geçtiniz: BB";
            }
            else if (not >= 90 && not <= 100)
            {
                aciklamalbl4.Text = "Geçtiniz: AA";
            }
            else
            {
                aciklamalbl4.Text = " Lütfen 1 ile 100 arasında bir sayı yazınız";
            }
        }

        void faktoriyelHesaplama(int sayi, int faktoriyel )
        {
            
            while (sayi > 0)
            {
                faktoriyel = faktoriyel * sayi;
                sayi--;
            }
            sonuclbl6.Text = faktoriyel.ToString();
        }

        void fibonacci(int a, int b, int c, int sayi)
        {

            for (byte i = 1; i <= sayi; i++)
            {
                c = a + b;
                a = b;
                b = c;
                fibonaccilbl.Text = fibonaccilbl.Text + " " + c.ToString();
            }
        }

        void siralama(int sayi1, int sayi2, int sayi3 )
        {
            if (sayi1 > sayi2 && sayi1 > sayi3)
            {
                siralamalbl.Text = "Birinci sayı en büyüktür. ";
            }
            else if (sayi2 > sayi1 && sayi2 > sayi3)
            {
                siralamalbl.Text = "İkinci sayı en büyüktür.";
            }
            else
            {
                siralamalbl.Text = "Üçüncü sayı en büyüktür.";
            }
        }

        void fahrenheit1(int kelvin, int celcius, int fahrenheit)
        {
            kelvin = celcius + 273;
            kelvinlbl.Text = kelvin.ToString();
            fahrenheit = celcius * 18 / 10 + 32;
            fahreneitlbl.Text = fahrenheit.ToString();
        }

        void ortalamaHesaplama(int sayi1,int sayi2,int sayi3,int sayi4,int sayi5,int sayi6, int sayi7, int sayi8,int sayi9 ,int sayi10, int ortalama)
        {
            ortalama = ((sayi1 + sayi2 + sayi3 + sayi4 + sayi5 + sayi6 + sayi7 + sayi8 + sayi9 +sayi10) / 10);
            ortalamalbl.Text = ortalama.ToString();
        }

        void ikilikHesaplama(int sayi, string sonuc)
        {
            while (sayi > 0)
            {
                sonuc = sayi % 2 + sonuc;
                sayi = sayi / 2;
            }
            ikiliksonuclbl.Text = sonuc.ToString();
        }

        void girisYap(string kullaniciadi, string sifre,string kayitadi, string kayitsifre)
        {

            if (kullaniciadi == "Fatma" && sifre == "123")
            {
                kaydetlbl.Text = "Kullanıcı girişi doğru. ";
                kullanicitxt.Clear();
                sifretxt.Clear();



            }
            else if (kullaniciadi == kayitadi && sifre == kayitsifre)
            {
                kaydetlbl.Text = "Kullanıcı girişi dogru .";

            }

            else
            {
                kaydetlbl.Text = "Böyle bir kullanıcı yok. Kayıt olunuz.";
            }
        }

        void kaydet(string kayitadi, string kayitsifre)
        {

            int counter = 1;
          
                
                counter++;
                if (counter > 2)
                {
                    MessageBox.Show("Max kullanıcı sayısına ulaşıldı ");
                }
                else
                {

                    kayitadi = kullanicitxt.Text;
                    kayitsifre = sifretxt.Text;
                    MessageBox.Show("Başarıyla kayıt olundu.");


                }
            
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          
            groupBox3.Visible = true; // ornek2
          
            groupBox2.Visible = false; // ornek1
            groupBox2.Dock = DockStyle.None;
            groupBox4.Visible = false;
            groupBox4.Dock = DockStyle.None;
            groupBox5.Visible = false;
            groupBox5.Dock = DockStyle.None;
            groupBox6.Visible = false;
            groupBox6.Dock = DockStyle.None;
            groupBox7.Visible = false;
            groupBox7.Dock = DockStyle.None;
            groupBox8.Visible = false;
            groupBox8.Dock = DockStyle.None;
            groupBox9.Visible = false;
            groupBox9.Dock = DockStyle.None;
            groupBox10.Visible = false;
            groupBox10.Dock = DockStyle.None;
            groupBox11.Visible = false;
            groupBox11.Dock = DockStyle.None;
            groupBox12.Visible = false;
            groupBox12.Dock = DockStyle.None;
            groupBox13.Visible = false;
            groupBox13.Dock = DockStyle.None;
            groupBox14.Visible = false;
            groupBox14.Dock = DockStyle.None;
            groupBox15.Visible = false;
            groupBox15.Dock = DockStyle.None;
            groupBox16.Visible = false;
            groupBox16.Dock = DockStyle.None;




        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox2.Visible = true;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;
            groupBox16.Visible = false;

        }

        private void hesaplabtn_Click(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                sonuctxt.Text = (int.Parse(sayi1txt.Text) + int.Parse(sayi2txt.Text)).ToString();
            }

            else if (radioButton17.Checked == true)
            {
                int sonuc = 0;
                int sayi1 = int.Parse(sayi1txt.Text);
                int sayi2 = int.Parse(sayi2txt.Text);
                sonuc = topla(sayi1, sayi2);
                sonuctxt.Text=sonuc.ToString();
            }
            else if (radioButton18.Checked == true)
            {
                int topla = 0;
                Uygulamalar uygulamalar = new Uygulamalar();
                uygulamalar.sayi =Convert.ToInt32(sayi1txt.Text);
                uygulamalar.sayi2 =Convert.ToInt32(sayi2txt.Text);
                topla = Convert.ToInt32(uygulamalar.Hesapla(0, uygulamalar.sayi, uygulamalar.sayi2));
                sonuctxt.Text = topla.ToString();

               
            }
        }
        private void hesaplabtn1_Click(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                getiritxt.Text = ((double.Parse(anaparatxt.Text) * ((double.Parse(faiztxt.Text)) / 100) / 365) * (double.Parse(guntxt.Text))).ToString();
            }

            else if (radioButton17.Checked == true)
            {
                double sonuc = 0;
                double sayi1 = Convert.ToDouble(anaparatxt.Text);
                double sayi2 = Convert.ToDouble(faiztxt.Text);
                int gun = Convert.ToInt32(guntxt.Text);
                sonuc = faizHesaplama(sayi1, sayi2,gun);
                getiritxt.Text = sonuc.ToString();
            }

            else if (radioButton18.Checked == true)
            {

                Ornekler ornekler = new Ornekler();
                ornekler.anapara = Convert.ToDouble(anaparatxt.Text);
                ornekler.faiz = Convert.ToDouble(faiztxt.Text);
                ornekler.gun = Convert.ToInt32(guntxt.Text);
                getiritxt.Text = ornekler.faizHesapla().ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox10.Visible = false;
            groupBox11.Visible = false;
            groupBox12.Visible = false;
            groupBox13.Visible = false;
            groupBox14.Visible = false;
            groupBox15.Visible = false;
            groupBox16.Visible = false;


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
          
            groupBox3.Visible = false;
            groupBox3.Dock = DockStyle.None;
            groupBox2.Visible = false;
            groupBox2.Dock = DockStyle.None;
            groupBox4.Visible = true;
           
            groupBox5.Visible = false;
            groupBox4.Dock = DockStyle.None;
            groupBox6.Visible = false;
            groupBox6.Dock = DockStyle.None;
            groupBox7.Visible = false;
            groupBox7.Dock = DockStyle.None;
            groupBox8.Visible = false;
            groupBox8.Dock = DockStyle.None;
            groupBox9.Visible = false;
            groupBox9.Dock = DockStyle.None;
            groupBox10.Visible = false;
            groupBox10.Dock = DockStyle.None;
            groupBox11.Visible = false;
            groupBox11.Dock = DockStyle.None;
            groupBox12.Visible = false;
            groupBox12.Dock = DockStyle.None;
            groupBox13.Visible = false;
            groupBox13.Dock = DockStyle.None;
            groupBox14.Visible = false;
            groupBox14.Dock = DockStyle.None;
            groupBox15.Visible = false;
            groupBox15.Dock = DockStyle.None;
            groupBox16.Visible = false;
            groupBox16.Dock = DockStyle.None;


        }

        private void hesaplabtn2_Click(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                int sonuc = 1;
                int taban = Convert.ToInt32(tabantxt.Text);
                int us = Convert.ToInt32(usttxt.Text);

                for (int i = 0; i < us; i++)
                {
                    sonuc = sonuc * taban;
                }

                sonuclbl.Text = sonuc.ToString();
            }

            else if (radioButton17.Checked == true)
            {
               
                int taban =Convert.ToInt32(tabantxt.Text);
                int us = Convert.ToInt32(usttxt.Text);

                usHesaplama(taban, us);
                  
            }
            else if (radioButton18.Checked == true)
            {
                int sonuc1 = 0;
                Uygulamalar uygulamalar = new Uygulamalar();
                uygulamalar.sayi = Convert.ToInt32(usttxt.Text);
                uygulamalar.sayi2 = Convert.ToInt32(tabantxt.Text);
                sonuc1 = Convert.ToInt32(uygulamalar.Hesapla(2, uygulamalar.sayi, uygulamalar.sayi2));
                sonuclbl.Text = sonuc1.ToString();

            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox3.Dock = DockStyle.None;
            groupBox2.Visible = false;
            groupBox2.Dock = DockStyle.None;
            groupBox4.Visible = false;
            groupBox4.Dock = DockStyle.None;
            groupBox5.Visible = true;
            groupBox6.Visible = false;
            groupBox6.Dock = DockStyle.None;
            groupBox7.Visible = false;
            groupBox7.Dock = DockStyle.None;
            groupBox8.Visible = false;
            groupBox8.Dock = DockStyle.None;
            groupBox9.Visible = false;
            groupBox9.Dock = DockStyle.None;
            groupBox10.Visible = false;
            groupBox10.Dock = DockStyle.None;
            groupBox11.Visible = false;
            groupBox11.Dock = DockStyle.None;
            groupBox12.Visible = false;
            groupBox12.Dock = DockStyle.None;
            groupBox13.Visible = false;
            groupBox13.Dock = DockStyle.None;
            groupBox14.Visible = false;
            groupBox14.Dock = DockStyle.None;
            groupBox15.Visible = false;
            groupBox15.Dock = DockStyle.None;
            groupBox16.Visible = false;
            groupBox16.Dock = DockStyle.None;


        }

        private void topla2btn_Click(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                float sayi = Convert.ToSingle(sayitxt.Text);
                sayi += 2;
                sonuclbl1.Text = sayi.ToString();
            }

            else if (radioButton17.Checked == true)
            {

                float sayi1 = Convert.ToSingle(sayitxt.Text);
                float sonuc = ikiiletopla(sayi1);
                sonuclbl1.Text = sonuc.ToString();
            }
            else if (radioButton18.Checked == true)
            {
                int sonuc = 0;
                Uygulamalar uygulamalar = new Uygulamalar();
                uygulamalar.sayi = Convert.ToInt32(sayitxt.Text);
                sonuc = Convert.ToInt32(uygulamalar.Hesapla(3, uygulamalar.sayi));
                sonuclbl1.Text = sonuc.ToString();
            }

        }

        private void azalt2btn_Click(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                float sayi = Convert.ToSingle(sayitxt.Text);
                sayi -= 2;
                sonuclbl1.Text = sayi.ToString();
            }

            else if (radioButton17.Checked == true)
            {
                float sayi1 = Convert.ToSingle(sayitxt.Text);
                float sonuc = ikiileazalt(sayi1);
                sonuclbl1.Text = sonuc.ToString();

            }
            else if (radioButton18.Checked == true)
            {
                int sonuc = 0;
                Uygulamalar uygulamalar = new Uygulamalar();
                uygulamalar.sayi = Convert.ToInt32(sayitxt.Text);
                sonuc = Convert.ToInt32(uygulamalar.Hesapla(4, uygulamalar.sayi));
                sonuclbl1.Text = sonuc.ToString();
            }

        }

        private void carpbtn_Click(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                float sayi = Convert.ToSingle(sayitxt.Text);
                sayi *= 2;
                sonuclbl1.Text = sayi.ToString();
            }

            else if (radioButton17.Checked == true)
            {
                float sayi1 = Convert.ToSingle(sayitxt.Text);
                float sonuc = ikiilecarp(sayi1);
                sonuclbl1.Text = sonuc.ToString();

            }
            else if (radioButton18.Checked == true)
            {
                int sonuc = 0;
                Uygulamalar uygulamalar = new Uygulamalar();
                uygulamalar.sayi = Convert.ToInt32(sayitxt.Text);
                sonuc = Convert.ToInt32(uygulamalar.Hesapla(5,uygulamalar.sayi));
                sonuclbl1.Text = sonuc.ToString();
            }

        }

        private void bolbtn_Click(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                float sayi = Convert.ToSingle(sayitxt.Text);
                sayi /= 2;
                sonuclbl1.Text = sayi.ToString();
            }

            else if (radioButton17.Checked == true)
            {
                float sayi = Convert.ToSingle(sayitxt.Text);
                float sonuc = ikiilebol(sayi);
                sonuclbl1.Text = sonuc.ToString();

            }
            else if (radioButton18.Checked == true)
            {
                int sonuc = 0;
                Uygulamalar uygulamalar = new Uygulamalar();
                uygulamalar.sayi = Convert.ToInt32(sayitxt.Text);
                sonuc = Convert.ToInt32(uygulamalar.Hesapla(6, uygulamalar.sayi));
                sonuclbl1.Text = sonuc.ToString();
            }
        }

        private void topla1btn_Click(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                float sayi = Convert.ToSingle(sayitxt.Text);
                sayi++;
                sonuclbl1.Text = sayi.ToString();
            }

            else if (radioButton17.Checked == true)
            {
                float sayi = Convert.ToSingle(sayitxt.Text);
                float sonuc = biriletopla(sayi);
                sonuclbl1.Text = sonuc.ToString();

            }
            else if (radioButton18.Checked == true)
            {
                int sonuc = 0;
                Uygulamalar uygulamalar = new Uygulamalar();
                uygulamalar.sayi = Convert.ToInt32(sayitxt.Text);
                sonuc = Convert.ToInt32(uygulamalar.Hesapla(7, uygulamalar.sayi));
                sonuclbl1.Text = sonuc.ToString();
            }

        }

        private void azalt1btn_Click(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                float sayi = Convert.ToSingle(sayitxt.Text);
                sayi--;
                sonuclbl1.Text = sayi.ToString();
            }

            else if (radioButton17.Checked == true)
            {
                float sayi = Convert.ToSingle(sayitxt.Text);
                float sonuc = birileazalt(sayi);
                sonuclbl1.Text = sonuc.ToString();

            }
            else if (radioButton18.Checked == true)
            {
                int sonuc = 0;
                Uygulamalar uygulamalar = new Uygulamalar();
                uygulamalar.sayi = Convert.ToInt32(sayitxt.Text);
                sonuc = Convert.ToInt32(uygulamalar.Hesapla(8, uygulamalar.sayi));
                sonuclbl1.Text = sonuc.ToString();
            }

        }

        private void modbtn_Click(object sender, EventArgs e)
        {

            if (radioButton16.Checked == true)
            {
                float sayi = Convert.ToSingle(sayitxt.Text);
                sayi = sayi % 2;
                sonuclbl1.Text = sayi.ToString();
            }

            else if (radioButton17.Checked == true)
            {
                float sayi = Convert.ToSingle(sayitxt.Text);
                float sonuc = modalma(sayi);
                sonuclbl1.Text = sonuc.ToString();

            }

            else if (radioButton18.Checked == true)
            {
                int sonuc = 0;
                Uygulamalar uygulamalar = new Uygulamalar();
                uygulamalar.sayi = Convert.ToInt32(sayitxt.Text);
                sonuc = Convert.ToInt32(uygulamalar.Hesapla(9, uygulamalar.sayi));
                sonuclbl1.Text = sonuc.ToString();
            }

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox3.Dock = DockStyle.None;
            groupBox2.Visible = false;
            groupBox2.Dock = DockStyle.None;
            groupBox4.Visible = false;
            groupBox4.Dock = DockStyle.None;
            groupBox5.Visible = false;
            groupBox5.Dock = DockStyle.None;
            groupBox6.Visible = true;
            groupBox7.Visible = false;
            groupBox7.Dock = DockStyle.None;
            groupBox8.Visible = false;
            groupBox8.Dock = DockStyle.None;
            groupBox9.Visible = false;
            groupBox9.Dock = DockStyle.None;
            groupBox10.Visible = false;
            groupBox10.Dock = DockStyle.None;
            groupBox11.Visible = false;
            groupBox11.Dock = DockStyle.None;
            groupBox12.Visible = false;
            groupBox12.Dock = DockStyle.None;
            groupBox13.Visible = false;
            groupBox13.Dock = DockStyle.None;
            groupBox14.Visible = false;
            groupBox14.Dock = DockStyle.None;
            groupBox15.Visible = false;
            groupBox15.Dock = DockStyle.None;
            groupBox16.Visible = false;
            groupBox16.Dock = DockStyle.None;


        }

        int sayac = 1;
        private void tahminbtn_Click(object sender, EventArgs e)
        {

            if (radioButton16.Checked == true)
            {
                int tutulan = 7;
                int tahmin = Convert.ToInt32(sayitxt1.Text);


                if (!(tahmin > 0 && tahmin <= 10))
                {
                    aciklamalbl.Text = "Girilen sayı 1 ile 10 arasında olmalı ";
                    sayac++;
                }


                else if (tahmin > tutulan)
                {
                    aciklamalbl.Text = "Tahmin edilen sayı tutulan sayıdan büyüktür.";
                    sayac++;
                }

                else if (tahmin < tutulan)
                {
                    aciklamalbl.Text = "Tahmin edilen sayı tutulan sayıdan küçüktür. ";
                    sayac = sayac + 1;

                }
                else
                {
                    aciklamalbl.Text = "Tebrikler " + sayac + " kerede tahmin ettiniz :)";
                }
            }

            else if (radioButton17.Checked == true)
            {
                int sayac = 1;
                int tutulan;
                int tahmin = Convert.ToInt32(sayitxt1.Text);
                sayiTahmini(7, tahmin);
                
            }
            else if (radioButton18.Checked == true)
            {
                
                Uygulamalar uygulamalar = new Uygulamalar();
                uygulamalar.sayi = Convert.ToInt32(sayitxt1.Text);
                string sonuc = uygulamalar.Hesapla(10, uygulamalar.sayi);
                aciklamalbl.Text = sonuc;
            }
             

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox3.Dock = DockStyle.None;
            groupBox2.Visible = false;
            groupBox2.Dock = DockStyle.None;
            groupBox4.Visible = false;
            groupBox4.Dock = DockStyle.None;
            groupBox5.Visible = false;
            groupBox5.Dock = DockStyle.None;
            groupBox6.Visible = false;
            groupBox6.Dock = DockStyle.None;
            groupBox7.Visible = true;
            groupBox8.Visible = false;
            groupBox8.Dock = DockStyle.None;
            groupBox9.Visible = false;
            groupBox9.Dock = DockStyle.None;
            groupBox10.Visible = false;
            groupBox10.Dock = DockStyle.None;
            groupBox11.Visible = false;
            groupBox11.Dock = DockStyle.None;
            groupBox12.Visible = false;
            groupBox12.Dock = DockStyle.None;
            groupBox13.Visible = false;
            groupBox13.Dock = DockStyle.None;
            groupBox14.Visible = false;
            groupBox14.Dock = DockStyle.None;
            groupBox15.Visible = false;
            groupBox15.Dock = DockStyle.None;
            groupBox16.Visible = false;
            groupBox16.Dock = DockStyle.None;


        }

        private void btn_Click(object sender, EventArgs e)
        {
            int val;
            string girilensayi = " ";

            if (radioButton16.Checked == true)
            {
               
                //int girilensayi = Convert.ToInt32(sayitxt2.Text);

                girilensayi = sayitxt2.Text;
                if (!Int32.TryParse(girilensayi, out val))
                {
                    aciklamalbl1.Text = "Dönüşüm yapılamadı. Lütfen sayı giriniz.  ";
                }

                else
                {
                    if (val < 0)
                    {
                        aciklamalbl1.Text = "Girilen sayı negatiftir.";
                    }

                    else if (val % 2 == 0)
                    {
                        aciklamalbl1.Text = "Girilen sayı çifttir";
                    }
                    else
                    {
                        aciklamalbl1.Text = "Girilen sayı tektir.";
                    }
                }
            }

            else if (radioButton17.Checked == true)
            {
              
                val =0 ;
                girilensayi = sayitxt2.Text;

                TekmiCiftmi(val,girilensayi);
                
            }

            else if (radioButton18.Checked == true)
            {
                Uygulamalar uygulamalar = new Uygulamalar();
                uygulamalar.sayi = Convert.ToInt32(sayitxt2.Text);
                string sonuc = uygulamalar.Hesapla(11, uygulamalar.sayi);
                aciklamalbl1.Text = sonuc;
            }



        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox3.Dock = DockStyle.None;
            groupBox2.Visible = false;
            groupBox2.Dock = DockStyle.None;
            groupBox4.Visible = false;
            groupBox4.Dock = DockStyle.None;
            groupBox5.Visible = false;
            groupBox5.Dock = DockStyle.None;
            groupBox6.Visible = false;
            groupBox6.Dock = DockStyle.None;
            groupBox7.Visible = false;
            groupBox7.Dock = DockStyle.None;
            groupBox8.Visible = true;
            Controls.Add(groupBox8);
            groupBox9.Visible = false;
            groupBox9.Dock = DockStyle.None;
            groupBox10.Visible = false;
            groupBox10.Dock = DockStyle.None;
            groupBox11.Visible = false;
            groupBox11.Dock = DockStyle.None;
            groupBox12.Visible = false;
            groupBox12.Dock = DockStyle.None;
            groupBox13.Visible = false;
            groupBox13.Dock = DockStyle.None;
            groupBox14.Visible = false;
            groupBox14.Dock = DockStyle.None;
            groupBox15.Visible = false;
            groupBox15.Dock = DockStyle.None;
            groupBox16.Visible = false;
            groupBox16.Dock = DockStyle.None;

        }

       
        private void mukemmelbtn_Click(object sender, EventArgs e)
        {

            if (radioButton16.Checked == true)
            {
                int sayi;
                sayi = Convert.ToInt32(sayigiristxt.Text);
                int toplam = 0;
                for (int i = 1; i <= sayi / 2; i++)
                {

                    if (sayi % i == 0)
                    {
                        toplam = toplam + i;
                    }
                }
                if (sayi == toplam)
                {
                    aciklamalbl3.Text = "Girilen sayı mükemmel sayıdır ";
                }
                else
                {
                    aciklamalbl3.Text = "Girilen sayı mükemmel sayı değildir. ";
                }
            }

            else if (radioButton17.Checked == true)
            {
                int toplam =0;
                int sayi = Convert.ToInt32(sayigiristxt.Text);

                mükemmelSayi(sayi, toplam);
            }

            else if (radioButton18.Checked == true)
            {
                
                Uygulamalar uygulamalar = new Uygulamalar();
                uygulamalar.sayi = Convert.ToInt32(sayigiristxt.Text);
                string sonuc = uygulamalar.Hesapla(12,uygulamalar.sayi);
                aciklamalbl3.Text = sonuc;
            }

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox3.Dock = DockStyle.None;
            groupBox2.Visible = false;
            groupBox2.Dock = DockStyle.None;
            groupBox4.Visible = false;
            groupBox4.Dock = DockStyle.None;
            groupBox5.Visible = false;
            groupBox5.Dock = DockStyle.None;
            groupBox6.Visible = false;
            groupBox6.Dock = DockStyle.None;
            groupBox7.Visible = false;
            groupBox7.Dock = DockStyle.None;
            groupBox8.Visible = false;
            groupBox8.Dock = DockStyle.None;
            groupBox9.Visible = true;
            groupBox10.Visible = false;
            groupBox10.Dock = DockStyle.None;
            groupBox11.Visible = false;
            groupBox11.Dock = DockStyle.None;
            groupBox12.Visible = false;
            groupBox12.Dock = DockStyle.None;
            groupBox13.Visible = false;
            groupBox13.Dock = DockStyle.None;
            groupBox14.Visible = false;
            groupBox14.Dock = DockStyle.None;
            groupBox15.Visible = false;
            groupBox15.Dock = DockStyle.None;
            groupBox16.Visible = false;
            groupBox16.Dock = DockStyle.None;

        }

        private void hesaplabtn3_Click(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                int not = Convert.ToInt32(nottxt.Text);

                if (not <= 50 && not >= 0)
                {
                    aciklamalbl4.Text = " Kaldınız: FF";
                }
                else if (not > 50 && not < 55)
                {
                    aciklamalbl4.Text = " Geçtiniz: DD";
                }
                else if (not >= 55 && not < 69)
                {
                    aciklamalbl4.Text = " Geçtiniz: CC";
                }
                else if (not >= 69 && not < 80)
                {
                    aciklamalbl4.Text = " Geçtiniz: BC";
                }
                else if (not >= 80 && not <= 90)
                {
                    aciklamalbl4.Text = "Geçtiniz: BB";
                }
                else if (not >= 90 && not <= 100)
                {
                    aciklamalbl4.Text = "Geçtiniz: AA";
                }
                else
                {
                    aciklamalbl4.Text = " Lütfen 1 ile 100 arasında bir sayı yazınız";
                }
            }

            else if (radioButton17.Checked == true)
            {
                int not = Convert.ToInt32(nottxt.Text);
                notHesaplama(not);
            }

            else if (radioButton18.Checked == true)
            {
                Uygulamalar uygulamalar = new Uygulamalar();
                uygulamalar.sayi = Convert.ToInt32(nottxt.Text);
                string sonuc = uygulamalar.Hesapla(13, uygulamalar.sayi);
                aciklamalbl4.Text = sonuc;
            }



        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox3.Dock = DockStyle.None;
            groupBox2.Visible = false;
            groupBox2.Dock = DockStyle.None;
            groupBox4.Visible = false;
            groupBox4.Dock = DockStyle.None;
            groupBox5.Visible = false;
            groupBox5.Dock = DockStyle.None;
            groupBox6.Visible = false;
            groupBox6.Dock = DockStyle.None;
            groupBox7.Visible = false;
            groupBox7.Dock = DockStyle.None;
            groupBox8.Visible = false;
            groupBox8.Dock = DockStyle.None;
            groupBox9.Visible = false;
            groupBox9.Dock = DockStyle.None;
            groupBox10.Visible = true;
            groupBox11.Visible = false;
            groupBox11.Dock = DockStyle.None;
            groupBox12.Visible = false;
            groupBox12.Dock = DockStyle.None;
            groupBox13.Visible = false;
            groupBox13.Dock = DockStyle.None;
            groupBox14.Visible = false;
            groupBox14.Dock = DockStyle.None;
            groupBox15.Visible = false;
            groupBox15.Dock = DockStyle.None;
            groupBox16.Visible = false;
            groupBox16.Dock = DockStyle.None;


        }

        private void fakthesapla_Click(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                int sayi = Convert.ToInt32(girilensayitxt.Text);
                int faktoriyel = 1;
                while (sayi > 0)
                {
                    faktoriyel = faktoriyel * sayi;
                    sayi--;
                }
                sonuclbl6.Text = faktoriyel.ToString();
            }

            else if (radioButton17.Checked == true)
            {
                int sayi = Convert.ToInt32(girilensayitxt.Text);
                int faktoriyel = 1;

                faktoriyelHesaplama(sayi, faktoriyel);
            }

            else if (radioButton18.Checked == true)
            {
                int sonuc =0;
                Uygulamalar uygulamalar = new Uygulamalar();
                uygulamalar.sayi = Convert.ToInt32(girilensayitxt.Text);
                sonuc = Convert.ToInt32(uygulamalar.Hesapla(14, uygulamalar.sayi));
                sonuclbl6.Text = sonuc.ToString();

                
            }

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox3.Dock = DockStyle.None;
            groupBox2.Visible = false;
            groupBox2.Dock = DockStyle.None;
            groupBox4.Visible = false;
            groupBox4.Dock = DockStyle.None;
            groupBox5.Visible = false;
            groupBox5.Dock = DockStyle.None;
            groupBox6.Visible = false;
            groupBox6.Dock = DockStyle.None;
            groupBox7.Visible = false;
            groupBox7.Dock = DockStyle.None;
            groupBox8.Visible = false;
            groupBox8.Dock = DockStyle.None;
            groupBox9.Visible = false;
            groupBox9.Dock = DockStyle.None;
            groupBox10.Visible = false;
            groupBox10.Dock = DockStyle.None;
            groupBox11.Visible = true;
            groupBox12.Visible = false;
            groupBox12.Dock = DockStyle.None;
            groupBox13.Visible = false;
            groupBox13.Dock = DockStyle.None;
            groupBox14.Visible = false;
            groupBox14.Dock = DockStyle.None;
            groupBox15.Visible = false;
            groupBox15.Dock = DockStyle.None;
            groupBox16.Visible = false;
            groupBox16.Dock = DockStyle.None;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                fibonaccilbl.Text = "";
                int a = 1, b = 0, c = 0;
                int sayi = Convert.ToInt32(textBox1.Text);

                for (byte i = 1; i <= sayi; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                    fibonaccilbl.Text = fibonaccilbl.Text + " " + c.ToString();
                }
            }

            else if (radioButton17.Checked == true)
            {

                fibonaccilbl.Text = "";
                int a = 1, b = 0, c = 0;
                int sayi = Convert.ToInt32 (textBox1.Text);
                fibonacci(a,b,c,sayi);
            }

            else if (radioButton18.Checked == true)
            {

                Uygulamalar uygulamalar = new Uygulamalar();
                uygulamalar.sayi= Convert.ToInt32(textBox1.Text);
                string sonuc = uygulamalar.Hesapla(15, uygulamalar.sayi, uygulamalar.sayi2, uygulamalar.sayi3);
                fibonaccilbl.Text = sonuc;
            }


        }
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox3.Dock = DockStyle.None;
            groupBox2.Visible = false;
            groupBox2.Dock = DockStyle.None;
            groupBox4.Visible = false;
            groupBox4.Dock = DockStyle.None;
            groupBox5.Visible = false;
            groupBox5.Dock = DockStyle.None;
            groupBox6.Visible = false;
            groupBox6.Dock = DockStyle.None;
            groupBox7.Visible = false;
            groupBox7.Dock = DockStyle.None;
            groupBox8.Visible = false;
            groupBox8.Dock = DockStyle.None;
            groupBox9.Visible = false;
            groupBox9.Dock = DockStyle.None;
            groupBox10.Visible = false;
            groupBox10.Dock = DockStyle.None;
            groupBox11.Visible = false;
            groupBox11.Dock = DockStyle.None;
            groupBox12.Visible = true;
            groupBox13.Visible = false;
            groupBox13.Dock = DockStyle.None;
            groupBox14.Visible = false;
            groupBox14.Dock = DockStyle.None;
            groupBox15.Visible = false;
            groupBox15.Dock = DockStyle.None;
            groupBox16.Visible = false;
            groupBox16.Dock = DockStyle.None;

        }

        private void siralamabtn_Click(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                int sayi1 = Convert.ToInt32(birincisayitxt.Text);
                int sayi2 = Convert.ToInt32(ikincisayitxt.Text);
                int sayi3 = Convert.ToInt32(ucuncusayitxt.Text);

                if (sayi1 > sayi2 && sayi1 > sayi3)
                {
                    siralamalbl.Text = "Birinci sayı en büyüktür. ";
                }
                else if (sayi2 > sayi1 && sayi2 > sayi3)
                {
                    siralamalbl.Text = "İkinci sayı en büyüktür.";
                }
                else
                {
                    siralamalbl.Text = "Üçüncü sayı en büyüktür.";
                }
            }

            else if (radioButton17.Checked == true)
            {


                int sayi1 = Convert.ToInt32(birincisayitxt.Text);
                int sayi2 = Convert.ToInt32(ikincisayitxt.Text);
                int sayi3 = Convert.ToInt32(ucuncusayitxt.Text);

                siralama(sayi1,sayi2,sayi3);
            }

            else if (radioButton18.Checked == true)
            {
                Uygulamalar uygulamalar = new Uygulamalar();
                uygulamalar.sayi = Convert.ToInt32(birincisayitxt.Text);
                uygulamalar.sayi2 = Convert.ToInt32(ikincisayitxt.Text);
                uygulamalar.sayi3 = Convert.ToInt32(ucuncusayitxt.Text);
                string sonuc = uygulamalar.Hesapla(16, uygulamalar.sayi,uygulamalar.sayi2, uygulamalar.sayi3);
                siralamalbl.Text = sonuc;

            }


        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox3.Dock = DockStyle.None;
            groupBox2.Visible = false;
            groupBox2.Dock = DockStyle.None;
            groupBox4.Visible = false;
            groupBox4.Dock = DockStyle.None;
            groupBox5.Visible = false;
            groupBox5.Dock = DockStyle.None;
            groupBox6.Visible = false;
            groupBox6.Dock = DockStyle.None;
            groupBox7.Visible = false;
            groupBox7.Dock = DockStyle.None;
            groupBox8.Visible = false;
            groupBox8.Dock = DockStyle.None;
            groupBox9.Visible = false;
            groupBox9.Dock = DockStyle.None;
            groupBox10.Visible = false;
            groupBox10.Dock = DockStyle.None;
            groupBox11.Visible = false;
            groupBox11.Dock = DockStyle.None;
            groupBox12.Visible = false;
            groupBox12.Dock = DockStyle.None;
            groupBox13.Visible = true;
            groupBox14.Visible = false;
            groupBox14.Dock = DockStyle.None;
            groupBox15.Visible = false;
            groupBox15.Dock = DockStyle.None;
            groupBox16.Visible = false;
            groupBox16.Dock = DockStyle.None;


        }

        private void hesaplabtn11_Click(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                int celcius = Convert.ToInt32(celciustxt.Text);
                int fahrenheit;
                int kelvin;

                kelvin = celcius + 273;
                kelvinlbl.Text = kelvin.ToString();
                fahrenheit = celcius * 18 / 10 + 32;
                fahreneitlbl.Text = fahrenheit.ToString();
            }

            else if (radioButton17.Checked == true)
            {

                int celcius = Convert.ToInt32(celciustxt.Text);
                int fahrenheit =0;
                int kelvin=0;

                fahrenheit1(kelvin, celcius, fahrenheit);

            }

            else if (radioButton18.Checked == true)
            {
                Uygulamalar uygulamalar = new Uygulamalar();
                uygulamalar.sayi = Convert.ToInt32(celciustxt.Text);
                uygulamalar.Hesapla(17, uygulamalar.sayi, uygulamalar.sayi2, uygulamalar.sayi3);
                string sonuc1 = uygulamalar.sayi2.ToString();
                string sonuc2 = uygulamalar.sayi3.ToString();
                kelvinlbl.Text = sonuc1;
                fahreneitlbl.Text = sonuc2;

            }


        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox3.Dock = DockStyle.None;
            groupBox2.Visible = false;
            groupBox2.Dock = DockStyle.None;
            groupBox4.Visible = false;
            groupBox4.Dock = DockStyle.None;
            groupBox5.Visible = false;
            groupBox5.Dock = DockStyle.None;
            groupBox6.Visible = false;
            groupBox6.Dock = DockStyle.None;
            groupBox7.Visible = false;
            groupBox7.Dock = DockStyle.None;
            groupBox8.Visible = false;
            groupBox8.Dock = DockStyle.None;
            groupBox9.Visible = false;
            groupBox9.Dock = DockStyle.None;
            groupBox10.Visible = false;
            groupBox10.Dock = DockStyle.None;
            groupBox11.Visible = false;
            groupBox11.Dock = DockStyle.None;
            groupBox12.Visible = false;
            groupBox12.Dock = DockStyle.None;
            groupBox13.Visible = false;
            groupBox13.Dock = DockStyle.None;
            groupBox14.Visible = true;
            groupBox15.Visible = false;
            groupBox15.Dock = DockStyle.None;
            groupBox16.Visible = false;
            groupBox16.Dock = DockStyle.None;

        }

        private void orthesaplabtn_Click(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                int ortalama;
                int sayi1 = Convert.ToInt32(saayi1txt.Text);
                int sayi2 = Convert.ToInt32(saayi2txt.Text);
                int sayi3 = Convert.ToInt32(saayi3txt.Text);
                int sayi4 = Convert.ToInt32(saayi4txt.Text);
                int sayi5 = Convert.ToInt32(saayi5txt.Text);
                int sayi6 = Convert.ToInt32(saayi6txt.Text);
                int sayi7 = Convert.ToInt32(saayi7txt.Text);
                int sayi8 = Convert.ToInt32(saayi8txt.Text);
                int sayi9 = Convert.ToInt32(saayi9txt.Text);
                int sayi10 = Convert.ToInt32(saayi10txt.Text);

                ortalama = ((sayi1 + sayi2 + sayi3 + sayi4 + sayi5 + sayi6 + sayi7 + sayi8 +sayi9 + sayi10) / 10);
                ortalamalbl.Text = ortalama.ToString();
            }

            else if (radioButton17.Checked == true)
            {
                int ortalama = 0;
                int sayi1 = Convert.ToInt32(saayi1txt.Text);
                int sayi2 = Convert.ToInt32(saayi2txt.Text);
                int sayi3 = Convert.ToInt32(saayi3txt.Text);
                int sayi4 = Convert.ToInt32(saayi4txt.Text);
                int sayi5 = Convert.ToInt32(saayi5txt.Text);
                int sayi6 = Convert.ToInt32(saayi6txt.Text);
                int sayi7 = Convert.ToInt32(saayi7txt.Text);
                int sayi8 = Convert.ToInt32(saayi8txt.Text);
                int sayi9 = Convert.ToInt32(saayi9txt.Text);
                int sayi10 = Convert.ToInt32(saayi10txt.Text);
                

                ortalamaHesaplama(sayi1,sayi2,sayi3,sayi4,sayi5,sayi6, sayi7,sayi8,sayi9,sayi10,ortalama);

            }

            else if (radioButton18.Checked == true)
            {
               
               Ornekler ornekler = new Ornekler();
               ornekler.sayi = Convert.ToInt32(saayi1txt.Text);
               ornekler.sayi = Convert.ToInt32(saayi2txt.Text);
               ornekler.sayi = Convert.ToInt32(saayi3txt.Text);
               ornekler.sayi = Convert.ToInt32(saayi4txt.Text);
               ornekler.sayi = Convert.ToInt32(saayi5txt.Text);
               ornekler.sayi = Convert.ToInt32(saayi6txt.Text);
               ornekler.sayi = Convert.ToInt32(saayi7txt.Text);
               ornekler.sayi = Convert.ToInt32(saayi8txt.Text);
               ornekler.sayi = Convert.ToInt32(saayi9txt.Text);
               ornekler.sayi = Convert.ToInt32(saayi10txt.Text);
               ortalamalbl.Text = ornekler.sayiortalama().ToString();
            }

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox3.Dock = DockStyle.None;
            groupBox2.Visible = false;
            groupBox2.Dock = DockStyle.None;
            groupBox4.Visible = false;
            groupBox4.Dock = DockStyle.None;
            groupBox5.Visible = false;
            groupBox5.Dock = DockStyle.None;
            groupBox6.Visible = false;
            groupBox6.Dock = DockStyle.None;
            groupBox7.Visible = false;
            groupBox7.Dock = DockStyle.None;
            groupBox8.Visible = false;
            groupBox8.Dock = DockStyle.None;
            groupBox9.Visible = false;
            groupBox9.Dock = DockStyle.None;
            groupBox10.Visible = false;
            groupBox10.Dock = DockStyle.None;
            groupBox11.Visible = false;
            groupBox11.Dock = DockStyle.None;
            groupBox12.Visible = false;
            groupBox12.Dock = DockStyle.None;
            groupBox13.Visible = false;
            groupBox13.Dock = DockStyle.None;
            groupBox14.Visible = false;
            groupBox14.Dock = DockStyle.None;
            groupBox15.Visible = true;
            Controls.Add(groupBox15);
            groupBox16.Visible = false;
            groupBox16.Dock = DockStyle.None;

        }

        private void ikilikhesaplamabtn_Click(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                int sayi = Convert.ToInt32(sayitxt16.Text);

                string sonuc = "";

                while (sayi > 0)
                {
                    sonuc = sayi % 2 + sonuc;
                    sayi = sayi / 2;
                }
                ikiliksonuclbl.Text = sonuc.ToString();
            }

            else if (radioButton17.Checked == true)
            {
                int sayi = Convert.ToInt32(sayitxt16.Text);
                string sonuc = "";

                ikilikHesaplama(sayi, sonuc);

            }
            else if (radioButton18.Checked == true)
            {
                Uygulamalar uygulamalar = new Uygulamalar();
                uygulamalar.sayi = Convert.ToInt32(sayitxt16.Text); 
                string sonuc = uygulamalar.Hesapla(19, uygulamalar.sayi);
                ikiliksonuclbl.Text = sonuc;
            }

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox3.Dock = DockStyle.None;
            groupBox2.Visible = false;
            groupBox2.Dock = DockStyle.None;
            groupBox4.Visible = false;
            groupBox4.Dock = DockStyle.None;
            groupBox5.Visible = false;
            groupBox5.Dock = DockStyle.None;
            groupBox6.Visible = false;
            groupBox6.Dock = DockStyle.None;
            groupBox7.Visible = false;
            groupBox7.Dock = DockStyle.None;
            groupBox8.Visible = false;
            groupBox8.Dock = DockStyle.None;
            groupBox9.Visible = false;
            groupBox9.Dock = DockStyle.None;
            groupBox10.Visible = false;
            groupBox10.Dock = DockStyle.None;
            groupBox11.Visible = false;
            groupBox11.Dock = DockStyle.None;
            groupBox12.Visible = false;
            groupBox12.Dock = DockStyle.None;
            groupBox13.Visible = false;
            groupBox13.Dock = DockStyle.None;
            groupBox14.Visible = false;
            groupBox14.Dock = DockStyle.None;
            groupBox15.Visible = false;
            groupBox15.Dock = DockStyle.None;
            groupBox16.Visible = true;
            Controls.Add(groupBox16);


        }

       

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            string kayitadi="";
            string kayitsifre="";
            string kullaniciadi = kullanicitxt.Text;
            string sifre = sifretxt.Text;

            if (radioButton16.Checked == true)
            {
                
                if (kullaniciadi == "Fatma" && sifre == "123")
                {
                    kaydetlbl.Text = "Kullanıcı girişi doğru. ";
                    kullanicitxt.Clear();
                    sifretxt.Clear();



                }
                else if (kullaniciadi == kayitadi && sifre == kayitsifre)
                {
                    kaydetlbl.Text = "Kullanıcı girişi dogru .";

                }

                else
                {
                    kaydetlbl.Text = "Böyle bir kullanıcı yok. Kayıt olunuz.";
                }
            }

            else if (radioButton17.Checked == true)
            {
                
                girisYap(kullaniciadi,sifre,kayitadi,kayitsifre);

            }

            else if (radioButton18.Checked == true)
            {
                

                Kullanici kullanici = new Kullanici();
                kullanici.kullaniciadi = kullanicitxt.Text;
                kullanici.kayitsifre = sifretxt.Text;
                kullanici.GirisYap(kullaniciadi, sifre, kayitadi, kayitsifre);
            }

        }


        

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                int counter = 1;
                string kayitadi;
                string kayitsifre;


                counter++;
                if (counter > 2)
                {
                    MessageBox.Show("Max kullanıcı sayısına ulaşıldı ");
                }
                else
                {

                    kayitadi = kullanicitxt.Text;
                    kayitsifre = sifretxt.Text;
                    MessageBox.Show("Başarıyla kayıt olundu.");


                }
            }

            else if (radioButton17.Checked == true)
            {

                string kayitadi = "";
                string kayitsifre = "";
                kaydet(kayitadi, kayitsifre);

            }

            else if (radioButton18.Checked == true)
            {

            }
           
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
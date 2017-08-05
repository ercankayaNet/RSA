using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Collections;
namespace RSA
{
    public partial class Form1 : Form
    {
        //Genel Değişkenler
        BigInteger n = 0;
        BigInteger fiN = 0;
        BigInteger ee = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //Asal Sayı kontrol fonksiyonu
        public bool AsalSayiMi(BigInteger sayi)
        {
            if (sayi == 2)
                return true;
            if (sayi < 2)
                return false;
            if (sayi % 2 == 0)
                return false;
            BigInteger i = 2;
            for (i = 3; i < sayi / 2; i = i + 2)
            {
                if (sayi % i == 0)
                    return false;
            }
            return true;
        }

        // Aralarında Asallık Fonksiyonu
        public bool aralarindaAsallik(BigInteger sayi1, BigInteger sayi2)
        {
            BigInteger sayac = 0;
            if (sayi1 % 2 == 0 && sayi2 % 2 == 0)
                return false;
            for (sayac = 3; sayac <= sayi2; sayac = sayac + 2)
            {
                if (sayi1 % sayac == 0 && sayi2 % sayac == 0)
                    return false;
            }
            if (sayi2 < 2 || sayi2 >= sayi1)
                return false;
            else
                return true;
        }

        //Alınan 2 sayı kontrol edilerek N sayısı ve FiN sayısı hesaplanıyor.
        private void btnOk_Click(object sender, EventArgs e)
        {
            //Sayıların Asal olup olmadığı kontrol ediliyor.
            if (rtbSayi1.Text == "" || rtbSayi2.Text == "")
                MessageBox.Show("Sayı girmeyi unutmayın", "Eksik Veri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (!AsalSayiMi(BigInteger.Parse(rtbSayi2.Text)) && !AsalSayiMi(BigInteger.Parse(rtbSayi1.Text)))
                MessageBox.Show("1. ve 2. Sayı Asal Sayı Değildir.", "Hatalı Veri Girişi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!AsalSayiMi(BigInteger.Parse(rtbSayi1.Text)))
                MessageBox.Show("1. Sayı Asal Sayı Değildir.", "Hatalı Veri Girişi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!AsalSayiMi(BigInteger.Parse(rtbSayi2.Text)))
                MessageBox.Show("2. Sayı Asal Sayı Değildir.", "Hatalı Veri Girişi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (AsalSayiMi(BigInteger.Parse(rtbSayi1.Text)) && AsalSayiMi(BigInteger.Parse(rtbSayi2.Text)))
            {
                lbAcıkAnahtarSinir.Text = "1 < E < " + (BigInteger.Parse(rtbSayi1.Text) - 1) * (BigInteger.Parse(rtbSayi2.Text) - 1);
                n = (BigInteger.Parse(rtbSayi1.Text)) * (BigInteger.Parse(rtbSayi2.Text));
                fiN = (BigInteger.Parse(rtbSayi1.Text) - 1) * (BigInteger.Parse(rtbSayi2.Text) - 1);
                lbFiN.Text = fiN.ToString();

            }

        }

        // Gizli anahtar üretimi
        private void btnGizliAnahtarUret_Click(object sender, EventArgs e)
        {
            if (rtbE.Text != "")
                ee = BigInteger.Parse(rtbE.Text);
            
            if (aralarindaAsallik(fiN, ee))
            {
                BigInteger x1 = 1, x2 = 0, x3 = fiN, y1 = 0, y2 = 1, y3 = ee, t1 = 0, t2 = 0, t3 = 0, q = 0;
                int i = 1;

                do
                {
                    if (i == 1)
                    {
                        q = x3 / y3;
                        t1 = x1 - (q * y1);
                        t2 = x2 - (q * y2);
                        t3 = x3 - (q * y3);
                    }
                    else
                    {
                        x1 = y1; x2 = y2; x3 = y3;
                        y1 = t1; y2 = t2; y3 = t3;
                        if (y3 == 0)
                        {
                            break;
                        }
                        q = x3 / y3;
                        t1 = x1 - (q * y1);
                        t2 = x2 - (q * y2);
                        t3 = x3 - (q * y3);
                    }
                    i++;
                } while (y3 != 1);

                if (y3 == 0)
                {
                    MessageBox.Show("Sayının Tersi yoktur. \nBaşka sayı seçiniz lütfen.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (y2 < 0)
                    {
                        rtbGizli.Text = "Gizli Anahtar : " + (y2 + fiN).ToString() + "\n";
                        rtbGizli.Text += "N sayısı : " + n + "\n";
                        rtbGizli.Text += "E Açık Anahtar : " + ee + "\n";
                        rtbGizli.Text += "1. Asal sayınız : " + rtbSayi1.Text + "\n";
                        rtbGizli.Text += "2. Asal sayınız : " + rtbSayi2.Text + "\n";
                    }
                    else
                    {
                        rtbGizli.Text = "Gizli Anahtar : " + y2.ToString() + "\n";
                        rtbGizli.Text += "N sayısı : " + n + "\n";
                        rtbGizli.Text += "E Açık Anahtar : " + ee + "\n";
                        rtbGizli.Text += "1. Asal sayınız : " + rtbSayi1.Text + "\n";
                        rtbGizli.Text += "2. Asal sayınız : " + rtbSayi2.Text + "\n";
                    }
                }
            }

            else
            {
                MessageBox.Show("E saysı Fi(n) ile arasında asal olmalıdır. \nE sayısı Fi(n)'den küçük olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSifreleDesifrele_Click(object sender, EventArgs e)
        {
            if (rtbMetin.Text == "" || rtbAnahtar.Text == "" || rtbNsayisi.Text == "")
                MessageBox.Show("Sayı girmeyi unutmayın", "Eksik Veri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (BigInteger.Parse(rtbMetin.Text) < BigInteger.Parse(rtbNsayisi.Text))
            {
                ArrayList bit = new ArrayList();
                ArrayList RealBit = new ArrayList();
                BigInteger anahtar = BigInteger.Parse(rtbAnahtar.Text);
                BigInteger metin = BigInteger.Parse(rtbMetin.Text);
                BigInteger nSayisi = BigInteger.Parse(rtbNsayisi.Text);

                //Anahtarı bit olarak yazma.
                BigInteger bolumEski = 0;
                BigInteger bolumYeni = 0;

                if (anahtar >= 2)
                {
                    bit.Add(anahtar % 2);
                    bolumYeni = anahtar / 2;
                    while (bolumYeni > 1)
                    {
                        bit.Add(bolumYeni % 2);
                        bolumEski = bolumYeni;
                        bolumYeni = bolumEski / 2;

                    }
                    bit.Add(bolumYeni);

                    if (bit.Count % 3 != 0)
                    {
                        int i = 3 - bit.Count % 3;
                        for (int k = 0; k < i; k++)
                        {
                            bit.Add(0);
                        }
                    }
                    for (int j = bit.Count - 1; j >= 0; j--)
                    {
                        RealBit.Add(bit[j]);
                    }
                }
                else
                    MessageBox.Show("Anahtarı 1 den büyük veriniz.");
                //***Anahtarı bit olarak yazma.


                //marry yöntemi 
                ArrayList temp = new ArrayList();
                ArrayList sonuclar = new ArrayList();
                BigInteger step8a = 0;
                temp.Add(1);
                temp.Add(metin);
                for (int sayac = 1; sayac < 7; sayac++)
                {
                    temp.Add((metin * BigInteger.Parse(temp[sayac].ToString())) % nSayisi);
                }

                string ucBit = RealBit[0].ToString() + RealBit[1].ToString() + RealBit[2].ToString();
                sonuclar.Add(temp[Convert.ToInt32(ucBit, 2)]);

                for (int sayac = 1; sayac < (RealBit.Count / 3); sayac++)
                {
                    ucBit = RealBit[sayac * 3].ToString() + RealBit[(sayac * 3) + 1].ToString() + RealBit[(sayac * 3) + 2].ToString();
                    step8a = BigInteger.Pow(BigInteger.Parse(sonuclar[(sayac - 1)].ToString()), 8) % nSayisi;
                    sonuclar.Add((step8a * BigInteger.Parse(temp[Convert.ToInt32(ucBit, 2)].ToString())) % nSayisi);
                }

                rtbOlusanMetin.Text = sonuclar[(sonuclar.Count - 1)].ToString();
                //*** marry yöntemi

            }
            else
                MessageBox.Show("Metin N sayısından büyük olmaaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //İçerik kontrolleri yapılıyor
        // numara ve kontrol 
        private void rtbSayi1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void rtbSayi2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void rtbE_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void rtbGizli_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar);
        }

        private void rtbAnahtar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void rtbNsayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void rtbMetin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void rtbOlusanMetin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Okul No: 1131602028 \nkayacoder@gmail.com", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}




//Kaynaklar
//http://bilgisayarkavramlari.sadievrenseker.com/2008/03/20/uzatilmis-oklit-algoritmasi-extended-euclid-algorithm/
//
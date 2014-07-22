using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DisliHesabi
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void BtnHesapla1_Click(object sender, EventArgs e)
        {
            if (textBoxHelis1.Text == string.Empty)
            {
                MessageBox.Show("Mod Boş Bırakılamaz..!", "UYARI..!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxMod.Text == string.Empty)
            {
                MessageBox.Show("Pinyon Diş Sayısı Boş Bırakılmaz..!", "UYARI..!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxKavrama1.Text == string.Empty)
            {
                MessageBox.Show("Çark Diş Sayısı Boş Bırakılamaz..!", "UYARI..!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxPinyon1.Text == string.Empty)
            {
                MessageBox.Show("Kavrama Açısı Boş Bırakılamaz..!", "UYARI..!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxCark1.Text == string.Empty)
            {
                MessageBox.Show("Helis Açısı Boş Bırakılamaz..!", "UYARI..!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            double sayi1 = Convert.ToDouble(textBoxMod.Text);
            double carpim = sayi1 * System.Math.PI / 180;
            textBoxKavrama3.Text = Convert.ToString(carpim);



            double sayi2 = Convert.ToDouble(textBoxHelis1.Text);
            double carpim2 = sayi1 * System.Math.PI / 180;
            textBoxHelis3.Text = Convert.ToString(carpim);


            double sayi3 = Convert.ToDouble(textBoxPinyon1.Text);
            double sayi4 = Convert.ToDouble(textBoxCark1.Text);
            double sayi5 = Convert.ToDouble(textBoxKavrama3.Text);
            double sayi6 = Convert.ToDouble(textBoxDonmeDairesi.Text);
            double sayi7 = sayi6 * System.Math.PI / 180;
            double hesap = (sayi3 + sayi4) / 2 * System.Math.Cos(sayi5) / System.Math.Cos(sayi7) - 1;
            textBoxY3.Text = Convert.ToString(hesap);



          //  textBoxY3.Text = (textBoxPinyon1.Text+textBoxCark1.Text)/2*((COS(textBoxKavrama3.Text)/COS(textBoxDonmeDairesi.Text))-1)


        }


     
     












        private void BtnHesapla2_Click(object sender, EventArgs e)
        {

           

            if (textBoxDiameter.Text == string.Empty)
            {
                MessageBox.Show("Diameter Pitch Boş Bırakılamaz..!", "UYARI..!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxPinyon2.Text == string.Empty)
            {
                MessageBox.Show("Pinyon Diş Sayısı Boş Bırakılmaz..!", "UYARI..!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxCark2.Text == string.Empty)
            {
                MessageBox.Show("Çark Diş Sayısı Boş Bırakılamaz..!", "UYARI..!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxKavrama2.Text == string.Empty)
            {
                MessageBox.Show("Kavrama Açısı Boş Bırakılamaz..!", "UYARI..!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxHelis2.Text == string.Empty)
            {
                MessageBox.Show("Helis Açısı Boş Bırakılamaz..!", "UYARI..!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            double dpsayi1 = Convert.ToDouble(textBoxDiameter.Text);                // Diamater Pitch
            double dpsayi2 = Convert.ToDouble(textBoxPinyon2.Text);                 // DP Pinyon Diş Sayısı
            double dpsayi3 = Convert.ToDouble(textBoxCark2.Text);                   // DP Çark Diş Sayısı
            double dpsayi4 = Convert.ToDouble(textBoxKavrama2.Text);                // DP Kavrama Açısı  
            double dpsayi5 = Convert.ToDouble(textBoxHelis2.Text);                  // DP Helis Açısı
            double dpsayi6 = Convert.ToDouble(textBoxDp1.Text);                     // DP Helis Yönü
            double dpsayi7 = Convert.ToDouble(textBoxDpProfilKaydırmaPinyon.Text);  // DP Profil Kaydırma Miktarı Pinyon
            double dpsayi39 = Convert.ToDouble(textBoxProfilKaydırmaCark.Text);     // DP Profil Kaydırma Miktarı Çark
            double dpsayi34 = Convert.ToDouble(textBoxDpTaksimatPinyon.Text);       // DP Taksimat Pinyon  Dairesi Çapı
            double dpsayi8 = Convert.ToDouble(textBoxDpTaksimatCark.Text);          // DP Taksimat Çark Dairesi Çapı
          
            double dpsayi9 = Convert.ToDouble(textBoxDpDisUstuCark.Text);           // DP  Diş üstü çapı Çark
            double dpsayi10 = Convert.ToDouble(textBoxDpDisDibiCark.Text);          // DP Diş dbi çapı Çark
            double dpsayi47 = Convert.ToDouble(textBoxDpDisUstuPinyon.Text);          // DP  Diş üstü çapı Pinyon
            double dpsayi48 = Convert.ToDouble(textBoxDpDisDibiPinyon.Text);          // DP  Diş Dibi çapı Pinyon



            double dpsayi38 = Convert.ToDouble(textBoxDpKontrolDisPinyon.Text);     // DP Kontrol Pinyon diş sayısı           
            double dpsayi11 = Convert.ToDouble(textBoxDpKontrolDisCark.Text);       // DP Kontrol çark diş sayısı
            double dpsayi35 = Convert.ToDouble(textBoxKontrolMikrPinyon.Text);      // DP  kontrol mikr. pinyon ölçüsü
            double dpsayi12 = Convert.ToDouble(textBoxDpKontrolMikrCark.Text);      // DP  kontrol mikr. çark ölçüsü
            double dpsayi13 = Convert.ToDouble(textBoxDpEksenlerArasiMesafe.Text);  // DP  Eksenler arası mesafe
            double dpsayi14 = Convert.ToDouble(textBoxDpProfilKayEksMes.Text);      // DP Profil Kaydırma İle Eks. Ara. Mes




            // Yardımcı Formüller
            double dpsayi15 = Convert.ToDouble(textBoxKavrama4.Text);               // DP Kavrama Açısı (Radyan)    
            double dpsayi16 = Convert.ToDouble(textBoxHelis4.Text);                 // DP Helis Açısı (Radyan) 
            double dpsayi17 = Convert.ToDouble(textBoxGercekKavrama4.Text);         // DP Gerçek Kavrama Açısı
            double dpsayi18 = Convert.ToDouble(textBoxDonmeDairesi4.Text);          // DP Dönme dai. bas. açısı 
            double dpsayi19 = Convert.ToDouble(textBoxEv4.Text);                    // DP ev(an)
            double dpsayi20 = Convert.ToDouble(textBoxEv5.Text);                    // DP ev(as)
            double dpsayi21 = Convert.ToDouble(textBoxHesap4.Text);                 // DP Hesap 
            double dpsayi22 = Convert.ToDouble(textBoxY4.Text);                     // DP y değeri
            //--------------------           

            double dpsayi23 = dpsayi1 * System.Math.PI / 180;
            dpsayi23 = Math.Round(dpsayi23, 4);
            textBoxKavrama4.Text = Convert.ToString(dpsayi23); // DP Kavrama Açısının radyan hesabı yapıldı

            double dpsayi24 = dpsayi5 * System.Math.PI / 180;
            dpsayi24 = Math.Round(dpsayi24, 4);
            textBoxHelis4.Text = Convert.ToString(dpsayi24); // DP Helis Açısı'nın radyan hesabı yapıldı

            double dpsayi25 = System.Math.Atan(System.Math.Tan(dpsayi23) / System.Math.Cos(dpsayi24));
            dpsayi25 = Math.Round(dpsayi25, 4);
            textBoxGercekKavrama4.Text = Convert.ToString(dpsayi25);  // DP Gerçek Kavrama Açısı hesabı yapıldı

            double dpsayi26 = System.Math.Tan(dpsayi23) - dpsayi23;
            dpsayi26 = Math.Round(dpsayi26, 4);
            textBoxEv4.Text = Convert.ToString(dpsayi26); // DP ev(an) hesabı yapıldı

            double dpsayi27 = System.Math.Tan(dpsayi25) - dpsayi25;
            dpsayi27 = Math.Round(dpsayi27, 4);
            textBoxEv5.Text = Convert.ToString(dpsayi27); // DP ev(an) hesabı yapıldı

            double dpsayi28 = 2 * System.Math.Tan(dpsayi15) * (dpsayi7 / (dpsayi2 + dpsayi3)) + dpsayi26;
            dpsayi28 = Math.Round(dpsayi28, 4);
            textBoxHesap4.Text = Convert.ToString(dpsayi28);  // Dp hesap işlemi yapıldı

            double dpsayi29 = dpsayi18 * System.Math.PI / 180;  // Dönme dai. bas.  açısının radyan değeri
            dpsayi29 = Math.Round(dpsayi29, 4);
            double dpsayi30 = (dpsayi2 + dpsayi3) / 2 * ((System.Math.Cos(dpsayi4) / System.Math.Cos(dpsayi29 )) - 1); // y değeri'nin hesabı
            textBoxY4.Text = Convert.ToString(dpsayi30);


            double milimeter = Convert.ToDouble("25,4"); // milimetre hesaplaması

            

            double dpsayi32 = (dpsayi13 + dpsayi30 / dpsayi1) * milimeter;
            dpsayi32 = Math.Round(dpsayi32, 3);
            textBoxDpProfilKayEksMes.Text = Convert.ToString(dpsayi32);  // Profil Kaydırma İle Eks. Ara. Mes.   Hesaplandı

            double dpsayi33 = (dpsayi34 + dpsayi8) / 2 * milimeter;
            dpsayi33 = Math.Round(dpsayi33,3);
            textBoxDpEksenlerArasiMesafe.Text = Convert.ToString(dpsayi33);  // Eksenler Arası Mesafe   Hesaplandı

         
            double yarim = Convert.ToDouble("0,5"); // Yarım hesabı
            double dpsayi36= 1 / dpsayi2 * System.Math.Cos(dpsayi23) * ((dpsayi38 - yarim) * System.Math.PI+(dpsayi2 * dpsayi20) + (2 * dpsayi7 * System.Math.Sin(dpsayi15)))*milimeter;
            dpsayi36 = Math.Round(dpsayi36, 3);
            textBoxKontrolMikrPinyon.Text=Convert.ToString(dpsayi36);


            double dpsayi37 = 1 / dpsayi1 * System.Math.Cos(dpsayi15) * ((dpsayi11 - yarim) * System.Math.PI + dpsayi3 * dpsayi20 + 2 * dpsayi39 * System.Math.Sin(dpsayi15))*milimeter;
            dpsayi37 = Math.Round(dpsayi37, 3);
            textBoxDpKontrolMikrCark.Text=Convert.ToString(dpsayi37);


            double dpsayi40=  (dpsayi34 + dpsayi8) / 2*milimeter;
            dpsayi40 = Math.Round(dpsayi40,3);
            textBoxDpEksenlerArasiMesafe.Text = Convert.ToString(dpsayi40);


            double dpsayi41 = dpsayi2 * (dpsayi20 / dpsayi19 * dpsayi4 / 180);
            dpsayi41 = Math.Round(dpsayi41, 3);
            textBoxDpKontrolDisPinyon.Text = Convert.ToString(dpsayi41);


            double dpsayi42 = dpsayi3 * (dpsayi20 / dpsayi19 * dpsayi4 / 180);
            dpsayi42 = Math.Round(dpsayi42, 3);
            textBoxDpKontrolDisCark.Text = Convert.ToString(dpsayi42);

            double k = Convert.ToDouble("1,25");
            double dpsayi43 = (dpsayi2 / System.Math.Cos(dpsayi16) - 2 * (k - dpsayi7)) / (dpsayi1);
            dpsayi43 = Math.Round(dpsayi43, 3);
            textBoxDpDisDibiPinyon.Text = Convert.ToString(dpsayi43);


            double dpsayi44 = (dpsayi3 / System.Math.Cos(dpsayi16) - 2 * (k - dpsayi39)) / (dpsayi1);
            dpsayi44 = Math.Round(dpsayi44, 3);
            textBoxDpDisDibiCark.Text = Convert.ToString(dpsayi44);

            double dpsayi45 = (dpsayi2 / System.Math.Cos(dpsayi16) + 2 * (dpsayi7+1)) / (dpsayi1);
            dpsayi45 = Math.Round(dpsayi45, 3);
            textBoxDpDisUstuPinyon.Text = Convert.ToString(dpsayi45);

            double dpsayi46 = (dpsayi3 / System.Math.Cos(dpsayi16) + 2 * (1+dpsayi39)) / (dpsayi1);
            dpsayi46 = Math.Round(dpsayi46, 3);
            textBoxDpDisUstuCark.Text = Convert.ToString(dpsayi46);

            double dpsayi31 = dpsayi2 / (dpsayi1 * System.Math.Cos(dpsayi16)) * milimeter;
            dpsayi31 = Math.Round(dpsayi31, 3);
            textBoxDpTaksimatCark.Text = Convert.ToString(dpsayi31);             // Taksimat Dairesi Çapı Çark Hesabı

            double dpsayi49 = dpsayi3 / (dpsayi1 * System.Math.Cos(dpsayi16)) * milimeter;
            dpsayi49 = Math.Round(dpsayi49, 3);
            textBoxDpTaksimatCark.Text = Convert.ToString(dpsayi49);              // Taksimat Dairesi Çapı Pinyon  hesabı

        }      





















                
        private void BtnCikis1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCikis2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnTemizle1_Click(object sender, EventArgs e)
        {
            textBoxMod.Clear();
            textBoxPinyon1.Clear();
            textBoxCark1.Clear();
            textBoxKavrama1.Clear();
            textBoxHelis1.Clear();
            // Sonuçları Temizleme--Düz Mod
            textBoxMod1.Clear();
            textBoxMod2.Clear();
            textBoxMod3.Clear();
            textBoxMod4.Clear();
            textBoxMod5.Clear();
            textBoxMod6.Clear();
            textBoxMod7.Clear();
            textBoxMod8.Clear();
            textBoxMod9.Clear();
            textBoxMod10.Clear();
            // Yardımcı Hesap Kısmı-Düz
            textBoxKavrama3.Clear();
            textBoxHelis3.Clear();
            textBoxGercekKavrama.Clear();
            textBoxDonmeDairesi.Clear();
            textBoxEv1.Clear();
            textBoxEv1.Clear();
            textBoxHesap3.Clear();
            textBoxY3.Clear();


        }
        private void BtnTemizle2_Click(object sender, EventArgs e)
        {
            textBoxDiameter.Clear();
            textBoxPinyon2.Clear();
            textBoxCark2.Clear();
            textBoxKavrama2.Clear();
            textBoxHelis2.Clear();
            //Sonuçları Temizleme-- Dp
            textBoxDp1.Clear();
            textBoxDpProfilKaydırmaPinyon.Clear();
            textBoxDpTaksimatCark.Clear();
            textBoxDpDisUstuCark.Clear();
            textBoxDpDisDibiCark.Clear();
            textBoxDpKontrolDisCark.Clear();
            textBoxDpKontrolMikrCark.Clear();
            textBoxDpEksenlerArasiMesafe.Clear();
            textBoxDpProfilKayEksMes.Clear();
            // Yardımcı Hesap Kısmı-Dp
            textBoxKavrama4.Clear();
            textBoxHelis4.Clear();
            textBoxGercekKavrama4.Clear();
            textBoxDonmeDairesi4.Clear();
            textBoxEv4.Clear();
            textBoxEv4.Clear();
            textBoxHesap4.Clear();
            textBoxY4.Clear();
        }

        private void textBoxDiameter_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (char.IsLetter(e.KeyChar))  // harf girilmesi engellendi
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        

        

        
    }
}

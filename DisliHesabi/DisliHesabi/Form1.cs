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
            if (textBoxMod.Text == string.Empty)
            {
                MessageBox.Show("Mod Boş Bırakılamaz..!", "UYARI..!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxModPinyonDisSayisi.Text == string.Empty)
            {
                MessageBox.Show("Pinyon Diş Sayısı Boş Bırakılmaz..!", "UYARI..!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxModCarkDisSayisi.Text == string.Empty)
            {
                MessageBox.Show("Çark Diş Sayısı Boş Bırakılamaz..!", "UYARI..!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxModKavramaAcisi.Text == string.Empty)
            {
                MessageBox.Show("Kavrama Açısı Boş Bırakılamaz..!", "UYARI..!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxModHelisAcisi.Text == string.Empty)
            {
                MessageBox.Show("Helis Açısı Boş Bırakılamaz..!", "UYARI..!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            double mod = Convert.ToDouble(textBoxMod.Text);                                                     // MOD
           
            double pinyon_dis_sayisi_mod = Convert.ToDouble(textBoxModPinyonDisSayisi.Text);                    // MOD Pinyon Diş Sayısı
            double cark_dis_sayisi_mod = Convert.ToDouble(textBoxModCarkDisSayisi.Text);                        // MOD Çark Diş Sayısı

            double kavrama_acisi_mod = Convert.ToDouble(textBoxModKavramaAcisi.Text);                           // MOD Kavrama Açısı  

            double helis_acisi_mod = Convert.ToDouble(textBoxModHelisAcisi.Text);                               // MOD Helis Açısı
            double helis_yonu_mod = Convert.ToDouble(textBoxHelisYonu.Text);                                    // MOD Helis Yönü

            double profil_kay_mik_pinyon_mod = Convert.ToDouble(textBoxModProfilKaydırmaPinyon.Text);       // MOD Profil Kaydırma Miktarı Pinyon
            double profil_kay_mik_cark_mod = Convert.ToDouble(textBoxModProfilKaydırmaCark.Text);           // MOD Profil Kaydırma Miktarı Çark
            double alin_modulu_mod = Convert.ToDouble(textBoxModAlinModulu.Text);                               // MOD alın modulu
            /*hesaplanmadı*/
            double sayi19 = Convert.ToDouble(textBoxModDonmeDairesi.Text);                                      // MOD  Dönme dai. bas. açısı 

            double kavrama_acisi_radyan_mod = kavrama_acisi_mod * System.Math.PI / 180;
            kavrama_acisi_radyan_mod = Math.Round(kavrama_acisi_radyan_mod, 4);
            textBoxModKavramaAcisiRadyan.Text = Convert.ToString(kavrama_acisi_radyan_mod);                     // MOD  Kavrama Açısının radyan hesabı yapıldı

            double helis_acisi_radyan_mod = helis_acisi_mod * System.Math.PI / 180;
            helis_acisi_radyan_mod = Math.Round(helis_acisi_radyan_mod, 4);
            textBoxModHelisAcisRadyan.Text = Convert.ToString(helis_acisi_radyan_mod);                          // MOD Helis Açısı'nın radyan hesabı yapıldı

            double gercek_kavrama_acisi_mod = System.Math.Atan(System.Math.Tan(kavrama_acisi_radyan_mod) / System.Math.Cos(helis_acisi_radyan_mod));
            gercek_kavrama_acisi_mod = Math.Round(gercek_kavrama_acisi_mod, 4);
            textBoxModGercekKavramaAcisi.Text = Convert.ToString(gercek_kavrama_acisi_mod);                     // MOD Gerçek Kavrama Açısı hesabı yapıldı

            double ev_an_mod = System.Math.Tan(kavrama_acisi_radyan_mod) - kavrama_acisi_radyan_mod;
            ev_an_mod = Math.Round(ev_an_mod, 4);
            textBoxModEvAn.Text = Convert.ToString(ev_an_mod);                                                  // MOD ev(an) hesabı yapıldı

            double ev_as_mod = System.Math.Tan(gercek_kavrama_acisi_mod) - gercek_kavrama_acisi_mod;
            ev_as_mod = Math.Round(ev_as_mod, 4);
            textBoxModEvAs.Text = Convert.ToString(ev_as_mod);                                                  // MOD ev(as) hesabı yapıldı



            double dp_hesap_mod = 2 * System.Math.Tan(kavrama_acisi_radyan_mod) * ((profil_kay_mik_cark_mod + profil_kay_mik_pinyon_mod) / (pinyon_dis_sayisi_mod + cark_dis_sayisi_mod)) + ev_an_mod;
            dp_hesap_mod = Math.Round(dp_hesap_mod, 4);
            textBoxModHesap.Text = Convert.ToString(dp_hesap_mod);                                              // MOD hesap işlemi yapıldı



            double donme_dai_bas_acisi_radyan_mod = (sayi19 * System.Math.PI / 180);                            // Dönme dai. bas.  açısının radyan değeri

            double y_degeri_mod = (pinyon_dis_sayisi_mod + cark_dis_sayisi_mod) / 2 * (System.Math.Cos(kavrama_acisi_radyan_mod) / System.Math.Cos(donme_dai_bas_acisi_radyan_mod) - 1); // y değeri'nin hesabı
            y_degeri_mod = Math.Round(y_degeri_mod, 4);
            textBoxModYDegeri.Text = Convert.ToString(y_degeri_mod);



            double milimeter_mod = Convert.ToDouble("25,4");                                                 // milimetre hesaplaması 	

            double taksimat_dairesi_capi_pinyon_mod = alin_modulu_mod*pinyon_dis_sayisi_mod;
            taksimat_dairesi_capi_pinyon_mod = Math.Round(taksimat_dairesi_capi_pinyon_mod, 3);
            labelModTaksimatPinyon.Text = Convert.ToString(taksimat_dairesi_capi_pinyon_mod);          // Taksimat Dairesi Çapı Pinyon  hesabı    

            double taksimat_dairesi_capi_cark_mod = alin_modulu_mod*cark_dis_sayisi_mod;
            taksimat_dairesi_capi_cark_mod = Math.Round(taksimat_dairesi_capi_cark_mod, 3);
            labelModTaksimatCark.Text = Convert.ToString(taksimat_dairesi_capi_cark_mod);               // Taksimat Dairesi Çapı Çark Hesabı                      


            double k_mod = Convert.ToDouble("1,25");                                                



            double dis_ustu_capi_pinyon_mod = mod * (pinyon_dis_sayisi_mod / System.Math.Cos(helis_acisi_radyan_mod) + 2 * (1 + profil_kay_mik_pinyon_mod));
            dis_ustu_capi_pinyon_mod = Math.Round(dis_ustu_capi_pinyon_mod, 3);
            labelModDisUstuPinyon.Text = Convert.ToString(dis_ustu_capi_pinyon_mod);

            double dis_ustu_capi_cark_mod =mod * (cark_dis_sayisi_mod / System.Math.Cos(helis_acisi_radyan_mod) + 2 * (1 + profil_kay_mik_cark_mod));
            dis_ustu_capi_cark_mod = Math.Round(dis_ustu_capi_cark_mod, 3);
            labelModDisUstuCark.Text = Convert.ToString(dis_ustu_capi_cark_mod);



            double dis_dibi_capi_pinyon_mod = mod*(pinyon_dis_sayisi_mod / System.Math.Cos(helis_acisi_radyan_mod) -2 * (k_mod - profil_kay_mik_pinyon_mod));
            dis_dibi_capi_pinyon_mod = Math.Round(dis_dibi_capi_pinyon_mod, 3);
            labelModDisDibiPinyon.Text = Convert.ToString(dis_dibi_capi_pinyon_mod);

            double dis_dibi_capi_cark_mod = mod*(cark_dis_sayisi_mod / System.Math.Cos(helis_acisi_radyan_mod) -2 * (k_mod - profil_kay_mik_cark_mod));
            dis_dibi_capi_cark_mod = Math.Round(dis_dibi_capi_cark_mod, 3);
            labelModDisDibiCark.Text = Convert.ToString(dis_dibi_capi_cark_mod);



            double kontrol_dis_sayisi_pinyon_mod =( pinyon_dis_sayisi_mod * (ev_as_mod / ev_an_mod * kavrama_acisi_mod / 180));
            kontrol_dis_sayisi_pinyon_mod = Math.Round(kontrol_dis_sayisi_pinyon_mod, 0);
            labelModKontrolDisPinyon.Text = Convert.ToString(kontrol_dis_sayisi_pinyon_mod);             // Kontrol Pinyon Dis Sayısı

            double kontrol_dis_sayisi_cark_mod = (cark_dis_sayisi_mod * (ev_as_mod / ev_an_mod * kavrama_acisi_mod / 180));
            kontrol_dis_sayisi_cark_mod = Math.Round(kontrol_dis_sayisi_cark_mod, 0);
            labelModKontrolDisCark.Text = Convert.ToString(kontrol_dis_sayisi_cark_mod);                 // Kontrol Çark Dis Sayısı



            double yarim_mod = Convert.ToDouble("0,5");                                               // Yarım hesabı
            double kontrol_mikr_pinyon_mod = mod * System.Math.Cos(kavrama_acisi_radyan_mod) * ((kontrol_dis_sayisi_pinyon_mod - yarim_mod) * System.Math.PI + pinyon_dis_sayisi_mod * ev_as_mod + 2 * profil_kay_mik_pinyon_mod * System.Math.Sin(kavrama_acisi_radyan_mod));
            kontrol_mikr_pinyon_mod = Math.Round(kontrol_mikr_pinyon_mod, 3);
            labelModKontrolMikrPinyon.Text = Convert.ToString(kontrol_mikr_pinyon_mod);                    // labeKontrolMikrPinyon Hesabı

            double kontrol_mikr_cark_mod = mod * System.Math.Cos(kavrama_acisi_radyan_mod) * ((kontrol_dis_sayisi_cark_mod - yarim_mod) * System.Math.PI + cark_dis_sayisi_mod * ev_as_mod + 2 * profil_kay_mik_cark_mod * System.Math.Sin(kavrama_acisi_radyan_mod));
            kontrol_mikr_cark_mod = Math.Round(kontrol_mikr_cark_mod, 3);
            labelModKontrolMikrCark.Text = Convert.ToString(kontrol_mikr_cark_mod);                        // labelKontrolMikrCark Hesabı

            double eksenler_arasi_mesafe_mod = (taksimat_dairesi_capi_cark_mod + taksimat_dairesi_capi_pinyon_mod) / 2 ;
            eksenler_arasi_mesafe_mod = Math.Round(eksenler_arasi_mesafe_mod, 3);
            labelModEksenlerArasiMesafe.Text = Convert.ToString(eksenler_arasi_mesafe_mod);                  //Eksenler Arası Mesafe hesaplandı

            double profil_kay_ile_eks_arasi_mesafe_mod = eksenler_arasi_mesafe_mod + mod * y_degeri_mod;
            profil_kay_ile_eks_arasi_mesafe_mod = Math.Round(profil_kay_ile_eks_arasi_mesafe_mod, 3);
            labelModProfilKayEksMes.Text = Convert.ToString(profil_kay_ile_eks_arasi_mesafe_mod);              //Profil Kay. İle Eks. Ara. Mes hesaplandı..
        











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

            double diameterpitch = Convert.ToDouble(textBoxDiameter.Text);                      // Diamater Pitch

            double pinyon_dis_sayisi = Convert.ToDouble(textBoxPinyon2.Text);                   // DP Pinyon Diş Sayısı
            double cark_dis_sayisi = Convert.ToDouble(textBoxCark2.Text);                       // DP Çark Diş Sayısı

            double kavrama_acisi = Convert.ToDouble(textBoxKavrama2.Text);                      // DP Kavrama Açısı  

            double helis_acisi = Convert.ToDouble(textBoxHelis2.Text);                          // DP Helis Açısı
            double helis_yonu = Convert.ToDouble(textBoxHelisYonu.Text);                              // DP Helis Yönü

            double profil_kay_mik_pinyon = Convert.ToDouble(textBoxDpProfilKaydırmaPinyon.Text);// DP Profil Kaydırma Miktarı Pinyon
            double profil_kay_mik_cark = Convert.ToDouble(textBoxDpProfilKaydırmaCark.Text);      // DP Profil Kaydırma Miktarı Çark
           
/*hesaplanmadı*/double dpsayi18 = Convert.ToDouble(textBoxDpDonmeDairesi4.Text);                  // DP  Dönme dai. bas. açısı 

            double kavrama_acisi_radyan = kavrama_acisi * System.Math.PI / 180;
            kavrama_acisi_radyan = Math.Round(kavrama_acisi_radyan, 4);
            textBoxDpKavramaAcisiRadyan.Text = Convert.ToString(kavrama_acisi_radyan);                      // DP  Kavrama Açısının radyan hesabı yapıldı

            double helis_acisi_radyan = helis_acisi * System.Math.PI / 180;
            helis_acisi_radyan = Math.Round(helis_acisi_radyan, 4);
            textBoxDpHelisAcisiRadyan.Text = Convert.ToString(helis_acisi_radyan);                          // DP Helis Açısı'nın radyan hesabı yapıldı

            double gercek_kavrama_acisi = System.Math.Atan(System.Math.Tan(kavrama_acisi_radyan) / System.Math.Cos(helis_acisi_radyan));
            gercek_kavrama_acisi = Math.Round(gercek_kavrama_acisi, 4);
            textBoxDpGercekKavrama4.Text = Convert.ToString(gercek_kavrama_acisi);                // DP Gerçek Kavrama Açısı hesabı yapıldı

            double ev_an = System.Math.Tan(kavrama_acisi_radyan) - kavrama_acisi_radyan;
            ev_an = Math.Round(ev_an, 4);
            textBoxDpEvAn.Text = Convert.ToString(ev_an);                                          // DP ev(an) hesabı yapıldı

            double ev_as = System.Math.Tan(gercek_kavrama_acisi) - gercek_kavrama_acisi;
            ev_as = Math.Round(ev_as, 4);
            textBoxDpEvAs.Text = Convert.ToString(ev_as);                                          // DP ev(as) hesabı yapıldı

            double dp_hesap = 2 * System.Math.Tan(kavrama_acisi_radyan) * (profil_kay_mik_cark + profil_kay_mik_pinyon) / (pinyon_dis_sayisi + cark_dis_sayisi) + ev_an;
            dp_hesap = Math.Round(dp_hesap, 4);
            textBoxDpHesap.Text = Convert.ToString(dp_hesap);                                    // Dp hesap işlemi yapıldı

            double donme_dai_bas_acisi_radyan = (dpsayi18 * System.Math.PI / 180);              // Dönme dai. bas.  açısının radyan değeri

            double y_degeri = (pinyon_dis_sayisi + cark_dis_sayisi) / 2 * ((System.Math.Cos(kavrama_acisi_radyan) / System.Math.Cos(donme_dai_bas_acisi_radyan)) - 1); // y değeri'nin hesabı
            y_degeri = Math.Round(y_degeri, 4);
            textBoxDpYDegeri.Text = Convert.ToString(y_degeri);

            double milimeter = Convert.ToDouble("25,4");

            double taksimat_dairesi_capi_pinyon = pinyon_dis_sayisi / (diameterpitch * System.Math.Cos(helis_acisi_radyan));
            taksimat_dairesi_capi_pinyon = Math.Round(taksimat_dairesi_capi_pinyon, 3);
            labelTaksimatPinyon.Text = Convert.ToString(taksimat_dairesi_capi_pinyon);          // Taksimat Dairesi Çapı Pinyon  hesabı    

            double taksimat_dairesi_capi_cark = cark_dis_sayisi / (diameterpitch * System.Math.Cos(helis_acisi_radyan));
            taksimat_dairesi_capi_cark = Math.Round(taksimat_dairesi_capi_cark, 3);
            labelTaksimatCark.Text = Convert.ToString(taksimat_dairesi_capi_cark);               // Taksimat Dairesi Çapı Çark Hesabı                      

            double k = Convert.ToDouble("1,25");                                                 // milimetre hesaplaması 	

            double dis_ustu_capi_pinyon = (pinyon_dis_sayisi / System.Math.Cos(helis_acisi_radyan) + 2 * (profil_kay_mik_pinyon + 1)) / (diameterpitch);
            dis_ustu_capi_pinyon = Math.Round(dis_ustu_capi_pinyon, 3);
            labelDisUstuPinyon.Text = Convert.ToString(dis_ustu_capi_pinyon);

            double dis_ustu_capi_cark = (cark_dis_sayisi / System.Math.Cos(helis_acisi_radyan) + 2 * (1 + profil_kay_mik_cark)) / (diameterpitch);
            dis_ustu_capi_cark = Math.Round(dis_ustu_capi_cark, 3);
            labelDisUstuCark.Text = Convert.ToString(dis_ustu_capi_cark);

            double dis_dibi_capi_pinyon = (pinyon_dis_sayisi / System.Math.Cos(helis_acisi_radyan)-2 * (k - profil_kay_mik_pinyon)) / (diameterpitch);
            dis_dibi_capi_pinyon = Math.Round(dis_dibi_capi_pinyon, 3);
            labelDisDibiPinyon.Text = Convert.ToString(dis_dibi_capi_pinyon);

            double dis_dibi_capi_cark = (cark_dis_sayisi / System.Math.Cos(helis_acisi_radyan)-2 * (k - profil_kay_mik_cark)) / (diameterpitch);
            dis_dibi_capi_cark = Math.Round(dis_dibi_capi_cark, 3);
            labelDisDibiCark.Text = Convert.ToString(dis_dibi_capi_cark);

            double kontrol_dis_sayisi_pinyon = pinyon_dis_sayisi * ev_as / ev_an * kavrama_acisi / 180;
            kontrol_dis_sayisi_pinyon = Math.Round(kontrol_dis_sayisi_pinyon, 0);
            labelKontrolDisPinyon.Text = Convert.ToString(kontrol_dis_sayisi_pinyon);             // Kontrol Pinyon Dis Sayısı

            double kontrol_dis_sayisi_cark = cark_dis_sayisi * ev_as / ev_an * kavrama_acisi / 180;
            kontrol_dis_sayisi_cark = Math.Round(kontrol_dis_sayisi_cark, 0);
            labelKontrolDisCark.Text = Convert.ToString(kontrol_dis_sayisi_cark);                 // Kontrol Çark Dis Sayısı


            double yarim = Convert.ToDouble("0,5");                                               // Yarım hesabı
            double kontrol_mikr_pinyon = 1 / diameterpitch * System.Math.Cos(kavrama_acisi_radyan) * ((kontrol_dis_sayisi_pinyon - yarim) * System.Math.PI + pinyon_dis_sayisi * ev_as + 2 * profil_kay_mik_pinyon * System.Math.Sin(kavrama_acisi_radyan));
            kontrol_mikr_pinyon = Math.Round(kontrol_mikr_pinyon, 3);
            labelKontrolMikrPinyon.Text = Convert.ToString(kontrol_mikr_pinyon);                    // labeKontrolMikrPinyon Hesabı

            double kontrol_mikr_cark = 1 / diameterpitch * System.Math.Cos(kavrama_acisi_radyan) * ((kontrol_dis_sayisi_cark - yarim) * System.Math.PI + cark_dis_sayisi * ev_as + 2 * profil_kay_mik_cark * System.Math.Sin(kavrama_acisi_radyan));
            kontrol_mikr_cark = Math.Round(kontrol_mikr_cark, 3);
            labelKontrolMikrCark.Text = Convert.ToString(kontrol_mikr_cark);                        // labelKontrolMikrCark Hesabı

        
            double eksenler_arasi_mesafe = (taksimat_dairesi_capi_cark + taksimat_dairesi_capi_pinyon) / 2;
            eksenler_arasi_mesafe = Math.Round(eksenler_arasi_mesafe, 3);
            labelEksenlerArasiMesafe.Text = Convert.ToString(eksenler_arasi_mesafe);                  //Eksenler Arası Mesafe hesaplandı

            double profil_kay_ile_eks_arasi_mesafe = (eksenler_arasi_mesafe + (y_degeri / diameterpitch));
            profil_kay_ile_eks_arasi_mesafe = Math.Round(profil_kay_ile_eks_arasi_mesafe, 3);
            labelProfilKayEksMes.Text = Convert.ToString(profil_kay_ile_eks_arasi_mesafe);              //Profil Kay. İle Eks. Ara. Mes hesaplandı..
        
   
            
        //public void hesap();
        //{
        //    double deger = double dp_hesap;
        //    double alfa = 0;
        //    double oldevol = System.Math.Tan(alfa) - alfa;
        //    double p = Convert.ToDouble("3,141592654");

        //    double artım = 1 * p / 180;
        //    double sayaç = 0;
        //    do {
        //       double alfa = alfa + artım;
        //      double   newevol = Tan(alfa) - alfa;
        //      double  oldfark = oldevol - deger;
        //        newfark = newevol - deger;
        ////MsgBox deger, , "değer"
        ////MsgBox oldfark, , "oldfark"
        ////MsgBox newfark, , "newfark"
        //        if (((newfark > 0 & oldfark < 0) | (newfark < 0 & oldfark > 0))) {
        //            artım = -artım / 10;
        //    //MsgBox "eksiden artıya"
        //    //ElseIf (newfark < 0 And oldfark > 0) Then
        //    //artım = -artım / 10
        //    //MsgBox "artıdan eksiye"
        //        }
        //        oldevol = newevol;
        //        sayaç = sayaç + 1;
        //        if ((sayaç > 500))
        //            break; // TODO: might not be correct. Was : Exit Do
        //    } while (!(newfark == 0));
        //    alfa = alfa * 180 / p;
        //    Range("I10").Value = alfa;   // I10 = 
        //}


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
            textBoxMod.Text = "0";
            textBoxModPinyonDisSayisi.Text = "0";
            textBoxModCarkDisSayisi.Text = "0";
            textBoxModKavramaAcisi.Text = "0";
            textBoxModHelisAcisi.Text = "0";
            textBoxModHelisYonu.Text = "0";
            textBoxModProfilKaydırmaPinyon.Text = "0";
            textBoxModProfilKaydırmaCark.Text = "0";
            textBoxModAlinModulu.Text = "0";
            // Sonuçları Temizleme--Düz Mod
            labelModTaksimatPinyon.Text="0";
            labelModTaksimatCark.Text = "0";
            labelModDisUstuPinyon.Text = "0";
            labelModDisUstuCark.Text = "0";
            labelModDisDibiPinyon.Text = "0";
            labelModDisDibiCark.Text = "0";
            labelModKontrolDisPinyon.Text = "0";
            labelModKontrolDisCark.Text = "0";
            labelModKontrolMikrPinyon.Text = "0";
            labelModKontrolMikrCark.Text = "0";
            labelModEksenlerArasiMesafe.Text = "0";
            labelModProfilKayEksMes.Text = "0";
            // Yardımcı Hesap Kısmı-Düz
            textBoxModKavramaAcisiRadyan.Text = "0";
            textBoxModHelisAcisRadyan.Text = "0";
            textBoxModGercekKavramaAcisi.Text = "0";
            textBoxModDonmeDairesi.Text = "0";
            textBoxModEvAn.Text = "0";
            textBoxModEvAs.Text = "0";
            textBoxModHesap.Text = "0";
            textBoxModYDegeri.Text = "0";


        }
        private void BtnTemizle2_Click(object sender, EventArgs e)
        {
            textBoxDiameter.Text = "0";
            textBoxPinyon2.Text = "0";
            textBoxCark2.Text = "0";
            textBoxKavrama2.Text = "0";
            textBoxHelis2.Text = "0";

            //Sonuçları Temizleme-- Dp
            textBoxHelisYonu.Text = "0";
            textBoxDpProfilKaydırmaPinyon.Text = "0";
            textBoxDpProfilKaydırmaCark.Text = "0";
            labelTaksimatCark.Text = "0";
            labelDisUstuCark.Text = "0";
            labelDisDibiCark.Text = "0";
            labelKontrolDisCark.Text = "0";
            labelKontrolMikrCark.Text = "0";
            labelEksenlerArasiMesafe.Text = "0";
            labelProfilKayEksMes.Text = "0";
            labelTaksimatPinyon.Text = "0";
            labelDisUstuPinyon.Text = "0";
            labelDisDibiPinyon.Text = "0";
            labelKontrolDisPinyon.Text = "0";
            labelKontrolMikrPinyon.Text = "0";
            // Yardımcı Hesap Kısmı-Dp
            textBoxDpKavramaAcisiRadyan.Text = "0";
            textBoxDpHelisAcisiRadyan.Text = "0";
            textBoxDpGercekKavrama4.Text = "0";
            textBoxDpDonmeDairesi4.Text = "0";
            textBoxDpEvAn.Text = "0";
            textBoxDpEvAs.Text = "0";
            textBoxDpHesap.Text = "0";
            textBoxDpYDegeri.Text = "0";
            
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxHelis2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCark2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDisUstuCark_Click(object sender, EventArgs e)
        {

        }
    }
}

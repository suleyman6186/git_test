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
            try
            {
     
            double mod = Convert.ToDouble(textBoxMod.Text);                                                     // MOD    
            double pinyon_dis_sayisi_mod = Convert.ToDouble(textBoxModPinyonDisSayisi.Text);                    // MOD Pinyon Diş Sayısı
            double cark_dis_sayisi_mod = Convert.ToDouble(textBoxModCarkDisSayisi.Text);                        // MOD Çark Diş Sayısı
            double kavrama_acisi_mod = Convert.ToDouble(textBoxModKavramaAcisi.Text);                           // MOD Kavrama Açısı  
            double helis_acisi_mod = Convert.ToDouble(textBoxModHelisAcisi.Text);                               // MOD Helis Açısı
            double helis_yonu_mod = Convert.ToDouble(textBoxHelisYonu.Text);                                    // MOD Helis Yönü
            double profil_kay_mik_pinyon_mod = Convert.ToDouble(textBoxModProfilKaydırmaPinyon.Text);           // MOD Profil Kaydırma Miktarı Pinyon
            double profil_kay_mik_cark_mod = Convert.ToDouble(textBoxModProfilKaydırmaCark.Text);               // MOD Profil Kaydırma Miktarı Çark
            double alin_modulu_mod = Convert.ToDouble(textBoxModAlinModulu.Text);                               // MOD alın modulu

            double kavrama_acisi_radyan_mod = kavrama_acisi_mod * System.Math.PI / 180;
            textBoxModKavramaAcisiRadyan.Text = Convert.ToString(kavrama_acisi_radyan_mod);                     // MOD  Kavrama Açısının radyan hesabı yapıldı

            double helis_acisi_radyan_mod = helis_acisi_mod * System.Math.PI / 180;
            textBoxModHelisAcisRadyan.Text = Convert.ToString(helis_acisi_radyan_mod);                          // MOD Helis Açısı'nın radyan hesabı yapıldı

            double gercek_kavrama_acisi_mod = System.Math.Atan(System.Math.Tan(kavrama_acisi_radyan_mod) / System.Math.Cos(helis_acisi_radyan_mod));
            textBoxModGercekKavramaAcisi.Text = Convert.ToString(gercek_kavrama_acisi_mod);                     // MOD Gerçek Kavrama Açısı hesabı yapıldı

            double ev_an_mod = System.Math.Tan(kavrama_acisi_radyan_mod) - kavrama_acisi_radyan_mod;
            textBoxModEvAn.Text = Convert.ToString(ev_an_mod);                                                  // MOD ev(an) hesabı yapıldı

            double ev_as_mod = System.Math.Tan(gercek_kavrama_acisi_mod) - gercek_kavrama_acisi_mod;
            textBoxModEvAs.Text = Convert.ToString(ev_as_mod);                                                  // MOD ev(as) hesabı yapıldı

            double dp_hesap_mod = 2 * System.Math.Tan(kavrama_acisi_radyan_mod) * ((profil_kay_mik_cark_mod + profil_kay_mik_pinyon_mod) / (pinyon_dis_sayisi_mod + cark_dis_sayisi_mod)) + ev_an_mod;
            textBoxModHesap.Text = Convert.ToString(dp_hesap_mod);                                              // MOD hesap işlemi yapıldı
   // Dönme dai. bas.  açısının  (mod) hesaplanması

            double deger_mod = dp_hesap_mod;
            double alfa_mod = 0;
            double oldevol_mod = System.Math.Tan(alfa_mod) - alfa_mod;
            double p_mod = System.Math.PI;
            double newevol_mod;
            double oldfark_mod;
            double newfark_mod;
            double artım_mod = p_mod / 180;

            double sayac = 0;

                do {
                    alfa_mod = alfa_mod + artım_mod;
                    newevol_mod = System.Math.Tan(alfa_mod) - alfa_mod;
                    oldfark_mod = oldevol_mod - deger_mod;
                    newfark_mod = newevol_mod - deger_mod;
                                                                    //MsgBox deger, , "değer"
                                                                    //MsgBox oldfark, , "oldfark"
                                                                    //MsgBox newfark, , "newfark"
                    if (((newfark_mod > 0 & oldfark_mod < 0) | (newfark_mod < 0 & oldfark_mod > 0)))
                    {
                        artım_mod = -artım_mod / 10;
                                                                    //MsgBox "eksiden artıya"
                                                                    //ElseIf (newfark < 0 And oldfark > 0) Then
                                                                    //artım = -artım / 10
                                                                    //MsgBox "artıdan eksiye"
                    }
                oldevol_mod = newevol_mod;
                    sayac = sayac + 1;
                if ((sayac > 500))
                break; // TODO: might not be correct. Was : Exit Do
                } while (!(newfark_mod == 0));
                alfa_mod = alfa_mod * 180 / p_mod;
                double donme_dairesi_bas_acisi_mod = alfa_mod;   // I10 =    
                textBoxModDonmeDairesi.Text = Convert.ToString(alfa_mod);
//----------------------------------------------------------------------------------------------------------------

            double donme_dai_bas_acisi_radyan_mod = (donme_dairesi_bas_acisi_mod * System.Math.PI / 180);                            // Dönme dai. bas.  açısının radyan değeri

            double y_degeri_mod = (pinyon_dis_sayisi_mod + cark_dis_sayisi_mod) / 2 * (System.Math.Cos(kavrama_acisi_radyan_mod) / System.Math.Cos(donme_dai_bas_acisi_radyan_mod) - 1); // y değeri'nin hesabı
            textBoxModYDegeri.Text = Convert.ToString(y_degeri_mod);

            double milimeter_mod = Convert.ToDouble("25,4");                                                    // milimetre hesaplaması 	

            double taksimat_dairesi_capi_pinyon_mod = alin_modulu_mod*pinyon_dis_sayisi_mod;
            taksimat_dairesi_capi_pinyon_mod = Math.Round(taksimat_dairesi_capi_pinyon_mod, 3);
            labelModTaksimatPinyon.Text = Convert.ToString(taksimat_dairesi_capi_pinyon_mod);                   // Taksimat Dairesi Çapı Pinyon  hesabı    

            double taksimat_dairesi_capi_cark_mod = alin_modulu_mod*cark_dis_sayisi_mod;
            taksimat_dairesi_capi_cark_mod = Math.Round(taksimat_dairesi_capi_cark_mod, 3);
            labelModTaksimatCark.Text = Convert.ToString(taksimat_dairesi_capi_cark_mod);                       // Taksimat Dairesi Çapı Çark Hesabı                      

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
            kontrol_dis_sayisi_pinyon_mod = Math.Ceiling(kontrol_dis_sayisi_pinyon_mod);
            labelModKontrolDisPinyon.Text = Convert.ToString(kontrol_dis_sayisi_pinyon_mod);                    // Kontrol Pinyon Dis Sayısı

            double kontrol_dis_sayisi_cark_mod = (cark_dis_sayisi_mod * (ev_as_mod / ev_an_mod * kavrama_acisi_mod / 180));
            kontrol_dis_sayisi_cark_mod = Math.Ceiling(kontrol_dis_sayisi_cark_mod);
            labelModKontrolDisCark.Text = Convert.ToString(kontrol_dis_sayisi_cark_mod);                        // Kontrol Çark Dis Sayısı

            double yarim_mod = Convert.ToDouble("0,5");                                                         // Yarım hesabı
            double kontrol_mikr_pinyon_mod = mod * System.Math.Cos(kavrama_acisi_radyan_mod) * ((kontrol_dis_sayisi_pinyon_mod - yarim_mod) * System.Math.PI + pinyon_dis_sayisi_mod * ev_as_mod + 2 * profil_kay_mik_pinyon_mod * System.Math.Sin(kavrama_acisi_radyan_mod));
            kontrol_mikr_pinyon_mod = Math.Round(kontrol_mikr_pinyon_mod, 3);
            labelModKontrolMikrPinyon.Text = Convert.ToString(kontrol_mikr_pinyon_mod);                         // labeKontrolMikrPinyon Hesabı

            double kontrol_mikr_cark_mod = mod * System.Math.Cos(kavrama_acisi_radyan_mod) * ((kontrol_dis_sayisi_cark_mod - yarim_mod) * System.Math.PI + cark_dis_sayisi_mod * ev_as_mod + 2 * profil_kay_mik_cark_mod * System.Math.Sin(kavrama_acisi_radyan_mod));
            kontrol_mikr_cark_mod = Math.Round(kontrol_mikr_cark_mod, 3);
            labelModKontrolMikrCark.Text = Convert.ToString(kontrol_mikr_cark_mod);                             // labelKontrolMikrCark Hesabı

            double eksenler_arasi_mesafe_mod = (taksimat_dairesi_capi_cark_mod + taksimat_dairesi_capi_pinyon_mod) / 2 ;
            eksenler_arasi_mesafe_mod = Math.Round(eksenler_arasi_mesafe_mod, 3);
            labelModEksenlerArasiMesafe.Text = Convert.ToString(eksenler_arasi_mesafe_mod);                     //Eksenler Arası Mesafe hesaplandı

            double profil_kay_ile_eks_arasi_mesafe_mod = eksenler_arasi_mesafe_mod + mod * y_degeri_mod;
            profil_kay_ile_eks_arasi_mesafe_mod = Math.Round(profil_kay_ile_eks_arasi_mesafe_mod, 3);
            labelModProfilKayEksMes.Text = Convert.ToString(profil_kay_ile_eks_arasi_mesafe_mod);              //Profil Kay. İle Eks. Ara. Mes hesaplandı..

            }
            catch (Exception)
            {
                MessageBox.Show("Zorunlu Değerler Boş Bırakılamaz..!");
            }


        } 
    
        private void BtnHesapla2_Click(object sender, EventArgs e)
        {    
            try
            {

            double diameterpitch = Convert.ToDouble(textBoxDiameter.Text);                                                  // Diamater Pitch
            double pinyon_dis_sayisi = Convert.ToDouble(textBoxPinyon2.Text);                                               // DP Pinyon Diş Sayısı
            double cark_dis_sayisi = Convert.ToDouble(textBoxCark2.Text);                                                   // DP Çark Diş Sayısı
            double kavrama_acisi = Convert.ToDouble(textBoxKavrama2.Text);                                                  // DP Kavrama Açısı  
            double helis_acisi = Convert.ToDouble(textBoxHelis2.Text);                                                      // DP Helis Açısı
            double helis_yonu = Convert.ToDouble(textBoxHelisYonu.Text);                                                    // DP Helis Yönü
            double profil_kay_mik_pinyon = Convert.ToDouble(textBoxDpProfilKaydırmaPinyon.Text);                            // DP Profil Kaydırma Miktarı Pinyon
            double profil_kay_mik_cark = Convert.ToDouble(textBoxDpProfilKaydırmaCark.Text);                                // DP Profil Kaydırma Miktarı Çark         
          
            double kavrama_acisi_radyan = kavrama_acisi * System.Math.PI / 180;
            textBoxDpKavramaAcisiRadyan.Text = Convert.ToString(kavrama_acisi_radyan);                                      // DP  Kavrama Açısının radyan hesabı yapıldı
           
            double helis_acisi_radyan = helis_acisi * System.Math.PI / 180;
            textBoxDpHelisAcisiRadyan.Text = Convert.ToString(helis_acisi_radyan);                                          // DP Helis Açısı'nın radyan hesabı yapıldı

            double gercek_kavrama_acisi = System.Math.Atan(System.Math.Tan(kavrama_acisi_radyan) / System.Math.Cos(helis_acisi_radyan));
            textBoxDpGercekKavrama4.Text = Convert.ToString(gercek_kavrama_acisi);                                          // DP Gerçek Kavrama Açısı hesabı yapıldı
                
            double ev_an = System.Math.Tan(kavrama_acisi_radyan) - kavrama_acisi_radyan;
            textBoxDpEvAn.Text = Convert.ToString(ev_an);                                                                   // DP ev(an) hesabı yapıldı

            double ev_as = System.Math.Tan(gercek_kavrama_acisi) - gercek_kavrama_acisi;
            textBoxDpEvAs.Text = Convert.ToString(ev_as);                                                                   // DP ev(as) hesabı yapıldı

            double dp_hesap = 2 * System.Math.Tan(kavrama_acisi_radyan) * (profil_kay_mik_cark + profil_kay_mik_pinyon) / (pinyon_dis_sayisi + cark_dis_sayisi) + ev_an;
            textBoxDpHesap.Text = Convert.ToString(dp_hesap);                                                               // Dp hesap işlemi yapıldı

            // Dönme dai. bas. açısının hesaplanması...
          
            double deger = dp_hesap;
            double alfa = 0;
            double oldevol = System.Math.Tan(alfa) - alfa;
            double p = System.Math.PI;
            double newevol;
            double oldfark;
            double newfark;
            double artım = p /180;

            double sayac = 0;

                do {
                    alfa = alfa + artım;
                    newevol = System.Math.Tan(alfa) - alfa;
                    oldfark = oldevol - deger;
                    newfark = newevol - deger;
                                                                    //MsgBox deger, , "değer"
                                                                    //MsgBox oldfark, , "oldfark"
                                                                    //MsgBox newfark, , "newfark"
                if (((newfark > 0 & oldfark < 0) | (newfark < 0 & oldfark > 0))) {
                    artım = -artım / 10;
                                                                    //MsgBox "eksiden artıya"
                                                                    //ElseIf (newfark < 0 And oldfark > 0) Then
                                                                    //artım = -artım / 10
                                                                    //MsgBox "artıdan eksiye"
                    }
                    oldevol = newevol;
                    sayac = sayac + 1;
                if ((sayac > 500))
                break; // TODO: might not be correct. Was : Exit Do
                    } while (!(newfark == 0));
                            alfa = alfa * 180 / p;

            double   donme_dairesi_bas_acisi= alfa;
            textBoxDpDonmeDairesi4.Text=Convert.ToString(alfa);
//-------------------------------------------------------------------------------------------------------------------------

            double donme_dai_bas_acisi_radyan = (donme_dairesi_bas_acisi * System.Math.PI / 180);                                          // Dönme dai. bas.  açısının radyan değeri

            double y_degeri = (pinyon_dis_sayisi + cark_dis_sayisi) / 2 * ((System.Math.Cos(kavrama_acisi_radyan) / System.Math.Cos(donme_dai_bas_acisi_radyan)) - 1); // y değeri'nin hesabı
            textBoxDpYDegeri.Text = Convert.ToString(y_degeri);

            double milimeter = Convert.ToDouble("25,4");                                                                    // milimetre hesaplaması 	

            double taksimat_dairesi_capi_pinyon = (pinyon_dis_sayisi / (diameterpitch * System.Math.Cos(helis_acisi_radyan)))* milimeter;
            taksimat_dairesi_capi_pinyon = Math.Round(taksimat_dairesi_capi_pinyon, 3) ;
            labelTaksimatPinyon.Text = Convert.ToString(taksimat_dairesi_capi_pinyon);                                      // Taksimat Dairesi Çapı Pinyon  hesabı    

            double taksimat_dairesi_capi_cark = (cark_dis_sayisi / (diameterpitch * System.Math.Cos(helis_acisi_radyan))) * milimeter;
            taksimat_dairesi_capi_cark = Math.Round(taksimat_dairesi_capi_cark, 3);
            labelTaksimatCark.Text = Convert.ToString(taksimat_dairesi_capi_cark);                                          // Taksimat Dairesi Çapı Çark Hesabı                      

            double k = Convert.ToDouble("1,25");                                                           
            double dis_ustu_capi_pinyon = ((pinyon_dis_sayisi / System.Math.Cos(helis_acisi_radyan) + 2 * (profil_kay_mik_pinyon + 1)) / (diameterpitch)) * milimeter;
            dis_ustu_capi_pinyon = Math.Round(dis_ustu_capi_pinyon, 3);
            labelDisUstuPinyon.Text = Convert.ToString(dis_ustu_capi_pinyon);

            double dis_ustu_capi_cark = ((cark_dis_sayisi / System.Math.Cos(helis_acisi_radyan) + 2 * (1 + profil_kay_mik_cark)) / (diameterpitch)) * milimeter;
            dis_ustu_capi_cark = Math.Round(dis_ustu_capi_cark, 3);
            labelDisUstuCark.Text = Convert.ToString(dis_ustu_capi_cark);

            double dis_dibi_capi_pinyon = ((pinyon_dis_sayisi / System.Math.Cos(helis_acisi_radyan)-2 * (k - profil_kay_mik_pinyon)) / (diameterpitch)) * milimeter;
            dis_dibi_capi_pinyon = Math.Round(dis_dibi_capi_pinyon, 3) ;
            labelDisDibiPinyon.Text = Convert.ToString(dis_dibi_capi_pinyon);

            double dis_dibi_capi_cark = ((cark_dis_sayisi / System.Math.Cos(helis_acisi_radyan)-2 * (k - profil_kay_mik_cark)) / (diameterpitch)) * milimeter;
            dis_dibi_capi_cark = Math.Round(dis_dibi_capi_cark, 3);
            labelDisDibiCark.Text = Convert.ToString(dis_dibi_capi_cark);

            double kontrol_dis_sayisi_pinyon = pinyon_dis_sayisi * ev_as / ev_an * kavrama_acisi / 180;
            kontrol_dis_sayisi_pinyon = Math.Ceiling(kontrol_dis_sayisi_pinyon);
            labelKontrolDisPinyon.Text = Convert.ToString(kontrol_dis_sayisi_pinyon);                                       // Kontrol Pinyon Dis Sayısı

            double kontrol_dis_sayisi_cark = cark_dis_sayisi * ev_as / ev_an * kavrama_acisi / 180;
            kontrol_dis_sayisi_cark = Math.Ceiling(kontrol_dis_sayisi_cark);
            labelKontrolDisCark.Text = Convert.ToString(kontrol_dis_sayisi_cark);                                           // Kontrol Çark Dis Sayısı

            double yarim = Convert.ToDouble("0,5");                                                                         // Yarım hesabı
            double kontrol_mikr_pinyon = (1 / diameterpitch * System.Math.Cos(kavrama_acisi_radyan) * ((kontrol_dis_sayisi_pinyon - yarim) * System.Math.PI + pinyon_dis_sayisi * ev_as + 2 * profil_kay_mik_pinyon * System.Math.Sin(kavrama_acisi_radyan))) * milimeter;
            kontrol_mikr_pinyon = Math.Round(kontrol_mikr_pinyon, 3);
            labelKontrolMikrPinyon.Text = Convert.ToString(kontrol_mikr_pinyon);                                            // labeKontrolMikrPinyon Hesabı

            double kontrol_mikr_cark = (1 / diameterpitch * System.Math.Cos(kavrama_acisi_radyan) * ((kontrol_dis_sayisi_cark - yarim) * System.Math.PI + cark_dis_sayisi * ev_as + 2 * profil_kay_mik_cark * System.Math.Sin(kavrama_acisi_radyan))) * milimeter;
            kontrol_mikr_cark = Math.Round(kontrol_mikr_cark, 3);
            labelKontrolMikrCark.Text = Convert.ToString(kontrol_mikr_cark );                                               // labelKontrolMikrCark Hesabı

            double eksenler_arasi_mesafe = (((cark_dis_sayisi / (diameterpitch * System.Math.Cos(helis_acisi_radyan))) + (pinyon_dis_sayisi / (diameterpitch * System.Math.Cos(helis_acisi_radyan)))) / 2)*milimeter;
            eksenler_arasi_mesafe = Math.Round(eksenler_arasi_mesafe, 3);
            labelEksenlerArasiMesafe.Text = Convert.ToString(eksenler_arasi_mesafe);                                        //Eksenler Arası Mesafe hesaplandı

            double profil_kay_ile_eks_arasi_mesafe = ((((cark_dis_sayisi / (diameterpitch * System.Math.Cos(helis_acisi_radyan))) + (pinyon_dis_sayisi / (diameterpitch * System.Math.Cos(helis_acisi_radyan)))) / 2) + y_degeri / diameterpitch)*milimeter;          
            profil_kay_ile_eks_arasi_mesafe = Math.Round(profil_kay_ile_eks_arasi_mesafe, 3);
            labelProfilKayEksMes.Text = Convert.ToString(profil_kay_ile_eks_arasi_mesafe);                                  //Profil Kay. İle Eks. Ara. Mes hesaplandı..
            }
            catch (Exception)
            {
                MessageBox.Show("Zorunlu Değerler Boş Bırakılamaz..!");
            }

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
        }
        private void BtnTemizle2_Click(object sender, EventArgs e)
        {
            textBoxDiameter.Text = "0";
            textBoxPinyon2.Text = "0";
            textBoxCark2.Text = "0";
            textBoxKavrama2.Text = "0";
            textBoxHelis2.Text = "0";
            textBoxDpProfilKaydırmaPinyon.Text = "0";
            textBoxDpProfilKaydırmaCark.Text = "0";
            textBoxHelisYonu.Text = "0";
            //Sonuçları Temizleme-- Dp
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
    }
}

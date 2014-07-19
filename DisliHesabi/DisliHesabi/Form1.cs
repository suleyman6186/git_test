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
        }


            //////////////////////////////////////////


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
            textBoxDp2.Clear();
            textBoxDp3.Clear();
            textBoxDp4.Clear();
            textBoxDp5.Clear();
            textBoxDp6.Clear();
            textBoxDp7.Clear();
            textBoxDp8.Clear();
            textBoxDp9.Clear();
            // Yardımcı Hesap Kısmı-Dp
            textBoxKavrama4.Clear();
            textBoxHelis4.Clear();
            textBoxGerçekKavrama4.Clear();
            textBoxDönmeDairesi4.Clear();
            textBoxEv4.Clear();
            textBoxEv4.Clear();
            textBoxHesap4.Clear();
        }  
    }
}

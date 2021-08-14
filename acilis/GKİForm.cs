using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acilis
{
    public partial class GKİForm : Form
    {
        double gkiSonucu;
        public GKİForm()
        {
            InitializeComponent();
            tbxGKIboy.MaxLength = 3;
            tbxGKIkilo.MaxLength = 3;
        }

        private void GKİForm_Load(object sender, EventArgs e)
        {
            cbxGender2.Items.Add("Erkek");
            cbxGender2.Items.Add("Kadın");
            cbxGender2.Items.Add("Belirtmek İstemiyorum");

            tbxGKIboy.Text = "Santim Cinsinden Boyunuzu Giriniz...";
            tbxGKIkilo.Text = "Kilonuzu Giriniz...";
            cbxGender2.Text = "Cinsiyetinizi Seçiniz...";
            nudYas.Text = "Yaşınızı Giriniz...";

        }


        private void btnGeri_Click_1(object sender, EventArgs e)
        {
            vkiForm yeni4 = new vkiForm();
            yeni4.Show();
            this.Hide();
        }

        private void btnIleri_Click_1(object sender, EventArgs e)
        {
            ygih yeni3 = new ygih();
            yeni3.Show();
            this.Hide();
        }

        private void btnCalculate2_Click(object sender, EventArgs e)
        {
            double kilo = Convert.ToDouble(tbxGKIkilo.Text);
            int boy = Convert.ToInt32(tbxGKIboy.Text);
            int yas = Convert.ToInt32(nudYas.Text);

           
                if (cbxGender2.Text == "Erkek")
                {
                    gkiSonucu = 66 + 13.7 * kilo + 5 * boy - 6.8 * yas;

                    MessageBox.Show(Convert.ToString(gkiSonucu), "Günlük almanız gereken kalori miktarı:");
                }

                if (cbxGender2.Text == "Belirtmek İstemiyorum")
                {
                    gkiSonucu = 66 + 13.7 * kilo + 5 * boy - 6.8 * yas;

                    MessageBox.Show(Convert.ToString(gkiSonucu), "Günlük almanız gereken kalori miktarı:");
                }

                if (cbxGender2.Text == "Kadın")
                {
                    gkiSonucu = 65 + 9.6 * kilo + 1.8 * boy - 6 - 4.7 * yas;

                    MessageBox.Show(Convert.ToString(gkiSonucu), "Günlük almanız gereken kalori miktarı:");
                }
            
        }

        private void cbxGender2_Validating(object sender, CancelEventArgs e)
        {
            if (cbxGender2.Text.Trim() == "" || cbxGender2.Text.Trim() == "Cinsiyetinizi Seçiniz...")
            {
                errorProvider1.SetError(cbxGender2, "Cinsiyetinizi Seçmelisiniz");
                btnCalculate2.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(cbxGender2, "");
                btnCalculate2.Enabled = true;
            }
        }

        private void tbxGKIboy_Validated(object sender, EventArgs e)
        {
            if (tbxGKIboy.Text.Trim() == "" || tbxGKIboy.Text.Trim() == "Santim Cinsinden Boyunuzu Giriniz...")
            {
                errorProvider1.SetError(tbxGKIboy, "Boyunuzu girmelisiniz");
                btnCalculate2.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(tbxGKIboy, "");
                btnCalculate2.Enabled = true;
            }
        }

        private void tbxGKIkilo_Validating(object sender, CancelEventArgs e)
        {
            if (tbxGKIkilo.Text.Trim() == "" || tbxGKIkilo.Text.Trim() == "Kilonuzu Giriniz...")
            {
                errorProvider1.SetError(tbxGKIkilo, "Kilonuzu girmelisiniz");
                btnCalculate2.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(tbxGKIkilo, "");
                btnCalculate2.Enabled = true;
            }
        }

        private void nudYas_Validated(object sender, EventArgs e)
        {
            if (nudYas.Text.Trim() == "" || nudYas.Text.Trim() == "Yaşınızı Giriniz...")
            {
                errorProvider1.SetError(nudYas, "Yaşınızı Girmelisiniz");
                btnCalculate2.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(nudYas, "");
                btnCalculate2.Enabled = true;
            }
        }
    }
}

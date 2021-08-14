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
    public partial class vkiForm : Form
    {


      
        public vkiForm()
        {
            InitializeComponent();
            tbxBoy.MaxLength = 4;
            tbxBoy.MaxLength = 4;
        }

        

        private void vkiForm_Load(object sender, EventArgs e)
        {
            cbxGender.Items.Add("Erkek");
            cbxGender.Items.Add("Kadın");
            cbxGender.Items.Add("Belirtmek İstemiyorum");

            tbxBoy.Text = "X,XX cinsinden boyunuz...";
            tbxKilo.Text = "XX,X veya XXX,X cinsinden kilonuz...";

            cbxGender.Text = "Cinsiyet Seçiniz...";


        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            double boy = Convert.ToDouble(tbxBoy.Text);
            double kilo = Convert.ToDouble(tbxKilo.Text);
            double boykare = Math.Pow(boy, 2);

            double vkiSonucu = kilo / boykare;

                if (cbxGender.Text == "Cinsiyet Seçiniz...")
                {
                    MessageBox.Show("Cinsiyet Belirtmelisiniz!!");
                }
                else
                {
                    if (cbxGender.Text == "")
                    {
                        MessageBox.Show("Cinsiyet Belirtmelisiniz!!");
                    }
                    else
                    {
                        if (vkiSonucu <= 20)
                        {
                            MessageBox.Show("Aşırı Zayıflık Kategorisinde Yer Almaktasınız. Sağlıklı Günler Dileriz!");
                        }

                        else if (vkiSonucu > 20 && vkiSonucu <= 24.9)
                        {
                            MessageBox.Show("Normal Kilodasınız. Sağlıklı Günler Dileriz!");
                        }

                        else if (vkiSonucu >= 25 && vkiSonucu <= 29.9)
                        {
                            MessageBox.Show("Hafif Şişman Kategorisinde Yer Almaktasınız. Sağlıklı Günler Dileriz!");
                        }

                        else if (vkiSonucu >= 30 && vkiSonucu <= 34.9)
                        {
                            MessageBox.Show("Şişman Kategorisinde Yer Almaktasınız. Sağlıklı Günler Dileriz!");
                        }

                        else if (vkiSonucu >= 35 && vkiSonucu <= 39.9)
                        {
                            MessageBox.Show("Obez Kategorisinde Yer Almaktasınız. Sağlıklı Günler Dileriz!");
                        }

                        else if (vkiSonucu >= 40)
                        {
                            MessageBox.Show("Sağlık için riskli kilodasınız. Doktora gitmenizi tavsiye eder , Sağlıklı Günler Dileriz!");
                        }
                    }
                }
            

            
                
            
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GKİForm yeni2 = new GKİForm();
            yeni2.Show();
            this.Hide();
        }

        private void tbxBoy_Validated(object sender, EventArgs e)
        {
            if (tbxBoy.Text.Trim() == "" || tbxBoy.Text.Trim() == "XXX,X cinsinden boyunuz...")
            {
                errorProvider1.SetError(tbxBoy, "Boyunuzu girmelisiniz");
                btnCalculate.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(tbxBoy, "");
                btnCalculate.Enabled = true;
            }
        }

        private void tbxKilo_Validating(object sender, CancelEventArgs e)
        {
            if (tbxKilo.Text.Trim() == "" || tbxKilo.Text.Trim() == "XX,X veya XXX,X cinsinden kilonuz...")
            {
                errorProvider1.SetError(tbxKilo, "Kilonuzu girmelisiniz");
                btnCalculate.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(tbxKilo, "");
                btnCalculate.Enabled = true;
            }
        }

        private void cbxGender_Validating(object sender, CancelEventArgs e)
        {
            if (cbxGender.Text.Trim() == "" || cbxGender.Text.Trim() == "Cinsiyet Seçiniz...")
            {
                errorProvider1.SetError(cbxGender, "Cinsiyet Seçmelisiniz");
                btnCalculate.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(cbxGender, "");
                btnCalculate.Enabled = true;
            }
        }

        
    }
}

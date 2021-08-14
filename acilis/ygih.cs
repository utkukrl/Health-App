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
    public partial class ygih : Form
    {
        
        public ygih()
        {
            InitializeComponent();
            textBox4.MaxLength = 2;
        }

        private void ygih_Load(object sender, EventArgs e)
        {
            cbxGender3.Items.Add("Erkek");
            cbxGender3.Items.Add("Kadın");
            cbxGender3.Items.Add("Belirtmek İstemiyorum");
            cbxGender3.Text = "Cinsiyet Seçiniz...";
            textBox4.Text = "Yaşınızı giriniz...";
            

        }

        private void cbxGender3_Validated(object sender, EventArgs e)
        {
            if (cbxGender3.Text.Trim() == "" || cbxGender3.Text.Trim() == "Cinsiyet Seçiniz...")
            {
                errorProvider1.SetError(cbxGender3, "Cinsiyet Seçmelisiniz");
                button2.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(cbxGender3, "");
                button2.Enabled = true;
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (textBox4.Text.Trim() == "" || textBox4.Text.Trim() == "Yaşınızı giriniz...")
            {
                errorProvider1.SetError(textBox4, "Yaşınızı girmelisiniz");
                button2.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(textBox4, "");
                button2.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GKİForm yeni4 = new GKİForm();
            yeni4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbxGender3.Text == "Kadın" || Convert.ToInt32(textBox4.Text) == 1)
            {
                textBox1.Text = "İdeal kilonuz 10 olmalıdır";
                textBox2.Text = "İdeal boyunuz 73 Santim olmalıdır";
            }

            if (cbxGender3.Text == "Kadın" || Convert.ToInt32(textBox4.Text) == 2)
            {
                textBox1.Text = "İdeal kilonuz 12.2 olmalıdır";
                textBox2.Text = "İdeal boyunuz 85.5 Santim olmalıdır";
            }

            if (cbxGender3.Text == "Kadın" || Convert.ToInt32(textBox4.Text) == 3)
            {
                textBox1.Text = "İdeal kilonuz 14 olmalıdır";
                textBox2.Text = "İdeal boyunuz 95 Santim olmalıdır";
            }

            if (cbxGender3.Text == "Kadın" || Convert.ToInt32(textBox4.Text) == 4)
            {
                textBox1.Text = "İdeal kilonuz 16 olmalıdır";
                textBox2.Text = "İdeal boyunuz 102 Santim olmalıdır";
            }

            if (cbxGender3.Text == "Kadın" || Convert.ToInt32(textBox4.Text) == 5)
            {
                textBox1.Text = "İdeal kilonuz 18.2 olmalıdır";
                textBox2.Text = "İdeal boyunuz 108 Santim olmalıdır";
            }


            if (cbxGender3.Text == "Kadın" || Convert.ToInt32(textBox4.Text) == 6)
            {
                textBox1.Text = "İdeal kilonuz 20.2 olmalıdır";
                textBox2.Text = "İdeal boyunuz 114 Santim olmalıdır";
            }

            if (cbxGender3.Text == "Kadın" || Convert.ToInt32(textBox4.Text) == 7)
            {
                textBox1.Text = "İdeal kilonuz 22.5 olmalıdır";
                textBox2.Text = "İdeal boyunuz 120 Santim olmalıdır";
            }

            if (cbxGender3.Text == "Kadın" || Convert.ToInt32(textBox4.Text) == 8)
            {
                textBox1.Text = "İdeal kilonuz 25.4 olmalıdır";
                textBox2.Text = "İdeal boyunuz 125.5 Santim olmalıdır";
            }

            if (cbxGender3.Text == "Kadın" || Convert.ToInt32(textBox4.Text) == 9)
            {
                textBox1.Text = "İdeal kilonuz 29.4 olmalıdır";
                textBox2.Text = "İdeal boyunuz 130.5 Santim olmalıdır";
            }

            if (cbxGender3.Text == "Kadın" || Convert.ToInt32(textBox4.Text) == 10)
            {
                textBox1.Text = "İdeal kilonuz 34.0 olmalıdır";
                textBox2.Text = "İdeal boyunuz 137 Santim olmalıdır";
            }

            if (cbxGender3.Text == "Kadın" || Convert.ToInt32(textBox4.Text) == 11)
            {
                textBox1.Text = "İdeal kilonuz 40 olmalıdır";
                textBox2.Text = "İdeal boyunuz 145.3 Santim olmalıdır";
            }

            if (cbxGender3.Text == "Kadın" || Convert.ToInt32(textBox4.Text) == 12)
            {
                textBox1.Text = "İdeal kilonuz 44.8 olmalıdır";
                textBox2.Text = "İdeal boyunuz 152.5 Santim olmalıdır";
            }

            if (cbxGender3.Text == "Kadın" || Convert.ToInt32(textBox4.Text) == 13)
            {
                textBox1.Text = "İdeal kilonuz 48.8 olmalıdır";
                textBox2.Text = "İdeal boyunuz 156 Santim olmalıdır";
            }

            if (Convert.ToDouble(textBox4.Text) > 13)
            {
                MessageBox.Show("Upss!! Girdiğiniz yaşa ait veri bulunamadı. Lütfen 1 ve 13 arasında bir yaş için hesaplama yapın.");
                textBox1.Text = "";
                textBox2.Text = "";
            }

            if (cbxGender3.Text == "Erkek" || Convert.ToInt32(textBox4.Text) == 1)
            {
                textBox1.Text = "İdeal kilonuz 10 olmalıdır";
                textBox2.Text = "İdeal boyunuz 74.7 Santim olmalıdır";
            }

            if (cbxGender3.Text == "Erkek" || Convert.ToInt32(textBox4.Text) == 2)
            {
                textBox1.Text = "İdeal kilonuz 12.7 olmalıdır";
                textBox2.Text = "İdeal boyunuz 86.5 Santim olmalıdır";
            }

            if (cbxGender3.Text == "Erkek" || Convert.ToInt32(textBox4.Text) == 3)
            {
                textBox1.Text = "İdeal kilonuz 14.6 olmalıdır";
                textBox2.Text = "İdeal boyunuz 96.3 Santim olmalıdır";
            }

            if (cbxGender3.Text == "Erkek" || Convert.ToInt32(textBox4.Text) == 4)
            {
                textBox1.Text = "İdeal kilonuz 16.7 olmalıdır";
                textBox2.Text = "İdeal boyunuz 102.5 Santim olmalıdır";
            }

            if (cbxGender3.Text == "Erkek" || Convert.ToInt32(textBox4.Text) == 5)
            {
                textBox1.Text = "İdeal kilonuz 18.7 olmalıdır";
                textBox2.Text = "İdeal boyunuz 109.5 Santim olmalıdır";
            }

            if (cbxGender3.Text == "Erkek" || Convert.ToInt32(textBox4.Text) == 6)
            {
                textBox1.Text = "İdeal kilonuz 20 olmalıdır";
                textBox2.Text = "İdeal boyunuz 116 Santim olmalıdır";
            }

            if (cbxGender3.Text == "Erkek" || Convert.ToInt32(textBox4.Text) == 7)
            {
                textBox1.Text = "İdeal kilonuz 23.2 olmalıdır";
                textBox2.Text = "İdeal boyunuz 121.5 Santim olmalıdır";
            }

            if (cbxGender3.Text == "Erkek" || Convert.ToInt32(textBox4.Text) == 8)
            {
                textBox1.Text = "İdeal kilonuz 26.1 olmalıdır";
                textBox2.Text = "İdeal boyunuz 127 Santim olmalıdır";
            }

            if (cbxGender3.Text == "Erkek" || Convert.ToInt32(textBox4.Text) == 9)
            {
                textBox1.Text = "İdeal kilonuz 29.5 olmalıdır";
                textBox2.Text = "İdeal boyunuz 132 Santim olmalıdır";
            }

            if (cbxGender3.Text == "Erkek" || Convert.ToInt32(textBox4.Text) == 10)
            {
                textBox1.Text = "İdeal kilonuz 33.7 olmalıdır";
                textBox2.Text = "İdeal boyunuz 137.5 Santim olmalıdır";
            }

            if (cbxGender3.Text == "Erkek" || Convert.ToInt32(textBox4.Text) == 11)
            {
                textBox1.Text = "İdeal kilonuz 38.5 olmalıdır";
                textBox2.Text = "İdeal boyunuz 143.5 Santim olmalıdır";
            }

            if (cbxGender3.Text == "Erkek" || Convert.ToInt32(textBox4.Text) == 12)
            {
                textBox1.Text = "İdeal kilonuz 43.1 olmalıdır";
                textBox2.Text = "İdeal boyunuz 150 Santim olmalıdır";
            }

            if (cbxGender3.Text == "Erkek" || Convert.ToInt32(textBox4.Text) == 13)
            {
                textBox1.Text = "İdeal kilonuz 48 olmalıdır";
                textBox2.Text = "İdeal boyunuz 156 Santim olmalıdır";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adresler yeni5 = new adresler();
            yeni5.Show();
            this.Hide();
        }

        
    }
}


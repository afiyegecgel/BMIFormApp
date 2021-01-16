using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BMIFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BMIHesaplayıcı BMIHesaplayıcı = new BMIHesaplayıcı();



        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(BMIHesaplayıcı.BMIHesapla(Convert.ToDouble(txtKilo.Text), Convert.ToDouble(txtBoy.Text)));
            
            if (result <= 18.5)
            {
                MessageBox.Show($" BMI Değeri: {result.ToString()} BMI Yorum: Zayıf ");
            }
            else if (result > 18.5 && result <= 24.9)
            {
                MessageBox.Show($" BMI Değeri: {result.ToString()} BMI Yorum: Normal ");
            }
            else if (result >= 25 && result <= 29.9)
            {
                MessageBox.Show($" BMI Değeri: {result.ToString()} BMI Yorum: Kilolu ");
            }
            else if (result >= 30 && result <= 34.9)
            {
                MessageBox.Show($" BMI Değeri: {result.ToString()} BMI Yorum: Obez 1 ");
            }
            else if (result >= 35 && result <= 39.9)
            {
                MessageBox.Show($" BMI Değeri: {result.ToString()} BMI Yorum: Obez 2 ");
            }
            else if (result >= 40)
            {
                MessageBox.Show($" BMI Değeri: {result.ToString()} BMI Yorum: Obez 3 ");
            }
            else 
            {
                MessageBox.Show($" Bir şeyler ters gitti girdiğiniz değerleri kontrol edin ");
            }

        }
    }
}

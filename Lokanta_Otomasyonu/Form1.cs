using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lokanta_Otomasyonu
{
    public partial class Form1 : Form
    {
        char _islem;
        bool _ekranTemizlenecekMi;
        int _ilksayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1Artı_Click(object sender, EventArgs e)
        {

            int button1Artı = Convert.ToInt32(label2Sıfır.Text);
            button1Artı = 20;
         EkranLabel.Text = Convert.ToString(button1Artı);

        }

        private void button3Artı_Click_1(object sender, EventArgs e)
        {
            int button3Artı = Convert.ToInt32(label4Sıfır.Text);
            button3Artı = 40;
            EkranLabel.Text = Convert.ToString(button3Artı);
        }

        private void button5Artı_Click_1(object sender, EventArgs e)
        {
            int button5Artı = Convert.ToInt32(label6sıfır.Text);
            button5Artı=60;
            EkranLabel.Text = Convert.ToString(button5Artı);
        }

        private void button7Artı_Click_1(object sender, EventArgs e)
        {
            int button7Artı = Convert.ToInt32(label8Sıfır.Text);
            button7Artı=50;
            EkranLabel.Text = Convert.ToString(button7Artı);
        }

        private void button9Artı_Click_1(object sender, EventArgs e)
        {
            int button9Artı = Convert.ToInt32(label10Sıfır.Text);
            button9Artı=45;
            EkranLabel.Text = Convert.ToString(button9Artı);
        }

        private void button11Artı_Click_1(object sender, EventArgs e)
        {
            int button11Artı = Convert.ToInt32(label12Sıfır.Text);
            button11Artı=48;
            EkranLabel.Text = Convert.ToString(button11Artı);
        }

        private void Button2Eksi_Click_1(object sender, EventArgs e)
        {
            int Button2Eksi = Convert.ToInt32(label2Sıfır.Text);
            if (Button2Eksi > 0)
            {
                Button2Eksi--;
                label2Sıfır.Text = Convert.ToString(Button2Eksi);
            }
        }

        private void button4Eksi_Click_1(object sender, EventArgs e)
        {
            int Button4Eksi = Convert.ToInt32(label4Sıfır.Text);
            if (Button4Eksi > 0)
            {
                Button4Eksi--;
                label4Sıfır.Text = Convert.ToString(Button4Eksi);
            }
        }

        private void button6Eksi_Click_1(object sender, EventArgs e)
        {
            int Button6Eksi = Convert.ToInt32(label6sıfır.Text);
            if (Button6Eksi > 0)
            {
                Button6Eksi--;
                label6sıfır.Text = Convert.ToString(Button6Eksi);
            }
        }

        private void button8Eksi_Click_1(object sender, EventArgs e)
        {
            int button8Eksi = Convert.ToInt32(label8Sıfır.Text);
            if (button8Eksi > 0)
            {
                button8Eksi--;
                label8Sıfır.Text = Convert.ToString(button8Eksi);
            }
        }

        private void Button10Eksi_Click_1(object sender, EventArgs e)
        {
            int Button10Eksi = Convert.ToInt32(label10Sıfır.Text);
            if (Button10Eksi > 0)
            {
                Button10Eksi--;
                label10Sıfır.Text = Convert.ToString(Button10Eksi);
            }
        }

        private void Button12Eksi_Click_1(object sender, EventArgs e)
        {
            int Button12Eksi = Convert.ToInt32(label12Sıfır.Text);
            if (Button12Eksi > 0)
            {
                Button12Eksi--;
                label12Sıfır.Text = Convert.ToString(Button12Eksi);
            }
        }
        private void button13Temizle_Click(object sender, EventArgs e)
        {
            label2Sıfır.Text = "0";
            label4Sıfır.Text = "0";
            label6sıfır.Text = "0";
            label8Sıfır.Text = "0";
            label10Sıfır.Text = "0";
            label12Sıfır.Text = "0";
        }

        private void Rakam1Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi) 
            {
                EkranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
          
           
            if (EkranLabel.Text=="0")

                EkranLabel.Text = "";
                EkranLabel.Text += "1";
           
           
        }

        private void Rakam2Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0")
           
                EkranLabel.Text = "";
                EkranLabel.Text += "2";
           
        }

        private void Rakam3Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0")
            
                EkranLabel.Text = "";
                EkranLabel.Text += "3";
           
        }

        private void Rakam4Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0")
            
                EkranLabel.Text = "";
                EkranLabel.Text += "4";
            
        }

        private void Rakam5Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (EkranLabel.Text == "0")
          
                EkranLabel.Text = "";
                EkranLabel.Text += "5";
          
        }

        private void Rakam6Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0")
            
                EkranLabel.Text = "";
                EkranLabel.Text += "6";
            
        }

        private void Rakam7Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0")
           
                EkranLabel.Text = "";
                EkranLabel.Text += "7";
           
        }

        private void Rakam8Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (EkranLabel.Text == "0")
           
                EkranLabel.Text = "";
                EkranLabel.Text += "8";
           
        }

        private void Rakam9Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0")
          
                EkranLabel.Text = "";
                EkranLabel.Text += "9";
            
        }

        private void Rakam0Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                EkranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (EkranLabel.Text == "0")
          
                EkranLabel.Text = "";
                EkranLabel.Text += "0";
            
        }

        private void ButtonArtı_Click(object sender, EventArgs e)
        {
            _islem ='+';
            _ekranTemizlenecekMi= true; 
            _ilksayi=Convert.ToInt32(EkranLabel.Text);
        }

        private void EsittirButton_Click(object sender, EventArgs e)
        {
            int ikinciSayi=Convert.ToInt32(EkranLabel.Text);
            int sonuc=0;
            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilksayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilksayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilksayi / ikinciSayi;
                    break;

            }
            EkranLabel.Text=Convert.ToString(sonuc);    
        }

        private void SilmeButton_Click(object sender, EventArgs e)
        {
            EkranLabel.Text = "0";
        }

        private void ButtonEksi_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilksayi = Convert.ToInt32(EkranLabel.Text);
        }

        private void ButtonCarpı_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecekMi = true;
            _ilksayi = Convert.ToInt32(EkranLabel.Text);
        }

        private void ButtonBölü_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilksayi = Convert.ToInt32(EkranLabel.Text);
        }

        private void label2Sıfır_Click(object sender, EventArgs e)
        {

        }
    }

}    //Total_Free_Py.Text = Convert.ToString(Convert.ToInt32(lbl_Esittir.Text) + Convert.ToInt32(lbl_9.Text));

    
    


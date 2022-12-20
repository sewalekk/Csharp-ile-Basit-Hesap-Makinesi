using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
       private char _islem;
       bool _ekranTemizlenecekmi;
        int _ilkSayi;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = ""; 
                _ekranTemizlenecekmi= false;
            }

            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "5";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecekmi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekmi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "4";
        }

        private void rakam1button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (ekranLabel.Text=="0") ekranLabel.Text="";
            ekranLabel.Text += "1";
        }

        private void rakam2button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "2";
        }

        private void rakam6button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "6";
        }

        private void rakam7button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "7";
        }

        private void rakam8button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "8";
        }

        private void rakam9button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "9";
        }

        private void rakam0button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekmi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "0";
        }

        private void toplamabutton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekmi = true;
            _ilkSayi=Convert.ToInt32(ekranLabel.Text);
        }

        private void eşittirbutton_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(ekranLabel.Text);
            int sonuc;
            
            switch(_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;

                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;

                case 'x':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;

                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            ekranLabel.Text=Convert.ToString(sonuc);    
        }

        private void çıkarmabutton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekmi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);
        }
    }
}

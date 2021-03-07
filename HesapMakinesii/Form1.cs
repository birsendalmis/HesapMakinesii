using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesii
{
    public partial class Form1 : Form
    {
        bool optDurum = false;
        int sonuc = 0;
        string opt = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Rakamlar(object sender, EventArgs e) //rakamları içeren butonlara Rakamlar olarak ortak tanımlama yaptım.
        {
            if (txtEkran.Text == "0" || optDurum)
                txtEkran.Clear(); //ilk durumda ekranda yazan sıfırın temizlemesini yaptım.

            optDurum = false; 
            Button buton = (Button)sender;
            txtEkran.Text += buton.Text;
                
        }

        private void Islemler(object sender, EventArgs e)//işlem operatörlerini içeren butonlara Islemler olarak ortak tanımlama yaptım.
        {
            optDurum = true;
            Button buton = (Button)sender;
            string yeniOpt = buton.Text;

            lbEkran.Text = lbEkran.Text + " " + txtEkran.Text + " " + yeniOpt;
            switch (opt)
            {
                case "+":txtEkran.Text = (sonuc + int.Parse(txtEkran.Text)).ToString();
                    break;
                case "-":
                    txtEkran.Text = (sonuc - int.Parse(txtEkran.Text)).ToString();
                    break;
                case "*":
                    txtEkran.Text = (sonuc * int.Parse(txtEkran.Text)).ToString();
                    break;
                case "/":
                    txtEkran.Text = (sonuc / int.Parse(txtEkran.Text)).ToString();
                    break;
            }

            sonuc = int.Parse(txtEkran.Text);
            txtEkran.Text = sonuc.ToString();
            opt = yeniOpt;
        }


        private void temizle(object sender, EventArgs e)
        {
            txtEkran.Text = "0";
            lbEkran.Text = "";
            opt = "";
            sonuc = 0;
        }

        private void esittir(object sender, EventArgs e)
        {
            lbEkran.Text = "";
            optDurum = true;

          
            
                if (opt == "+")
            {
                txtEkran.Text = (sonuc + int.Parse(txtEkran.Text)).ToString();
                
            }
                    
            
                else if (opt == "-")
            {
                txtEkran.Text = (sonuc - int.Parse(txtEkran.Text)).ToString();
               
            }
                    
                    
                else if (opt == "*")
            {
                txtEkran.Text = (sonuc * int.Parse(txtEkran.Text)).ToString();
               
            }
                    


                else if (opt == "/")
            {
                if (txtEkran.Text != "0") //tanımsız olma durumuna karşı kontrol yaptım.

                { txtEkran.Text = (sonuc / int.Parse(txtEkran.Text)).ToString(); }
                else
                {
                    MessageBox.Show("Sıfıra bölünemez.Tanımsızdır."); //tanımsızlık durumunda uyarı verdim.
                }

            }

            sonuc = int.Parse(txtEkran.Text);
            txtEkran.Text = sonuc.ToString();
            opt = "";
        }
    }
}

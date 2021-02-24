using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webautomasion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = "";
               
                String metin = textBox1.Text;
                int uzunluk = metin.Length;
                char[] dizi = new char[uzunluk];
                for(int i = 0; i < uzunluk; i++)
                {
                    dizi[i] = metin[i];
                }

                for(int i = 0; i < uzunluk; i++)
                {
                   
                    if(dizi[i]==' ')
                    {
                        dizi[i] = '-';
                    }
                    else if (dizi[i] =='ı')
                    {
                        dizi[i] = 'i';
                    }
                    else if (dizi[i] == 'ü')
                    {
                        dizi[i] = 'u';
                    }
                    else if (dizi[i] == 'ö')
                    {
                        dizi[i] = 'o';
                    }
                    else if (dizi[i] == 'ı')
                    {
                        dizi[i] = 'i';
                    }
                    else if (dizi[i] == 'İ')
                    {
                        dizi[i] = 'I';
                    }
                    else if (dizi[i] == 'Ü')
                    {
                        dizi[i] = 'U';
                    }
                    else if (dizi[i] == 'Ö')
                    {
                        dizi[i] = 'O';
                    }
                    else if (dizi[i] == '/')
                    {
                        dizi[i] = '-';
                    }
                    else if (dizi[i] == 'Ş')
                    {
                        dizi[i] = 'S';
                    }
                    else if (dizi[i] == 'ş')
                    {
                        dizi[i] = 's';
                    }
                    else if (dizi[i] == 'Ç')
                    {
                        dizi[i] = 'c';
                    }
                    else if (dizi[i] == 'ç')
                    {
                        dizi[i] = 'c';
                    }
                    else if (dizi[i] == 'Ğ')
                    {
                        dizi[i] = 'g';
                    }
                    else if (dizi[i] == 'ğ')
                    {
                        dizi[i] = 'g';
                    }

                }
                /// yazdirma 
                /// 
              
                for(int j = 0; j < uzunluk; j++)
                {
                    textBox2.Text = textBox2.Text + dizi[j];
                }
                sayac++;
                label2.Text = "Dönüştürülen cümle sayısı :" + sayac;

            }
            catch
            {
                MessageBox.Show("Hata " + e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}

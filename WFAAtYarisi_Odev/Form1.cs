using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAAtYarisi_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int degisken;
        decimal atno,kazan,yatir;
                private void tmrYaris_Tick(object sender, EventArgs e)
        {
            if(degisken ==1 )
            {
                pbAt1.Left += rnd.Next(4,11); //Çimende 1.At daha Avantajlı
                pbAt2.Left += rnd.Next(4, 9); 
                pbAt3.Left += rnd.Next(4, 8); 
                pbAt4.Left += rnd.Next(4, 10); 
            }
            else if(degisken == 2)
            {
                pbAt1.Left += rnd.Next(4, 9); 
                pbAt2.Left += rnd.Next(4, 11); //Kumda 2. at daha avantajlı
                pbAt3.Left += rnd.Next(4, 9); 
                pbAt4.Left += rnd.Next(4, 8); 
            }
            else if(degisken==3)
            {
                pbAt1.Left += rnd.Next(4, 7); 
                pbAt2.Left += rnd.Next(4, 8); 
                pbAt3.Left += rnd.Next(4, 9); 
                pbAt4.Left += rnd.Next(4, 11); //Toprakta 4. At daha avantajlı
            }
           

            if(pbAt1.Right >= lblFinish.Left)
            {
                
                tmrYaris.Stop();
               // DialogResult dr= MessageBox.Show("1 nolu at yarışı kazandı! Tekrar Oynamak ister misiniz?","Bilgi",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
               // if(dr == DialogResult.Yes)
               // {
               //     pbAt1.Left = pbAt2.Left = pbAt3.Left = pbAt4.Left = 0;
               // }
                //else
                //{
                 //   Application.Exit();
                //}
            }
            else if(pbAt2.Right >= lblFinish.Left)
            {
                
                tmrYaris.Stop();
                //DialogResult dr = MessageBox.Show("2 nolu at yarışı kazandı! Tekrar Oynamak İster misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
               // if (dr == DialogResult.Yes)
                //{
                  //  pbAt1.Left = pbAt2.Left = pbAt3.Left = pbAt4.Left = 0;
                //}
                //else
                //{
                  //  Application.Exit();

                //}
            }
            else if(pbAt3.Right >= lblFinish.Left)
            {
                
                tmrYaris.Stop();
                //DialogResult dr = MessageBox.Show("3 nolu at yarışı kazandı! Tekrar Oynamak İster misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                //if (dr == DialogResult.Yes)
                //{
                  //  pbAt1.Left = pbAt2.Left = pbAt3.Left = pbAt4.Left = 0;
                //}
                //else
                //{
                  //  Application.Exit();
                //}
            }
            else if(pbAt4.Right >= lblFinish.Left)
            {
                
                tmrYaris.Stop();
                //DialogResult dr = MessageBox.Show("4 nolu at yarışı kazandı! Tekrar Oynamak İster misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                //if (dr == DialogResult.Yes)
               // {
                 //   pbAt1.Left = pbAt2.Left = pbAt3.Left = pbAt4.Left = 0;
                //}
                //else
                //{
                  //  Application.Exit();
                //}
            }
            if (pbAt1.Right > pbAt2.Right && pbAt1.Right>pbAt3.Right && pbAt1.Right >pbAt4.Right) // 1 nolu at en hızlıysa
            {
                rtxtSpiker.Text = "1 nolu at ,yarışı önde götürüyor!";
                lblSpiker.Text = "1 nolu at ,yarışı önde götürüyor ";


            }
            else if(pbAt2.Right > pbAt1.Right && pbAt2.Right > pbAt3.Right && pbAt2.Right > pbAt4.Right) //2 nolu at en hızlıysa
            {
                rtxtSpiker.Text = "2 nolu at, hızlı bir atak yaptı!";
                lblSpiker.Text = " 2 nolu at, hızlı bir atak yaptı!";
            }
            else if(pbAt3.Right > pbAt1.Right && pbAt3.Right > pbAt2.Right && pbAt3.Right > pbAt4.Right) //3 nolu at en hızlıysa
            {
                rtxtSpiker.Text = "3 nolu at, öne geçmeyi başardı!";
                lblSpiker.Text = "3 nolu at, öne geçmeyi başardı!";
            }
            else if(pbAt4.Right > pbAt1.Right && pbAt4.Right > pbAt2.Right && pbAt4.Right > pbAt3.Right) //4 nolu at en hızlıysa
            {
                 rtxtSpiker.Text = "4 nolu at, çok hızlı bir çıkış yaptı!";
                lblSpiker.Text = "4 nolu at, çok hızlı bir çıkış yaptı!";
            }

            //
            
           /* DialogResult dr = MessageBox.Show(" Tekrar Oynamak İster misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
               pbAt1.Left = pbAt2.Left = pbAt3.Left = pbAt4.Left = 0;
            }
            else
            {
              Application.Exit();
            }*/

        }

        private void btnYarisiBaslat_Click(object sender, EventArgs e)
        {
            tmrYaris.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtYatirilacakMiktar.Text = null;
            txtAtNo.Text = null;
            lblTutar.Text = null;
            btnYatir.Enabled = true;

        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {

            
            if(pbAt1.Right >=lblFinish.Left)
            {
                lblBahisSonucu.Text = "1 no lu at yarışı kazandı!.";
            }
            else if (pbAt2.Right >= lblFinish.Left)
            {
                lblBahisSonucu.Text = "2 no lu at yarışı kazandı!.";
            }
            else if (pbAt3.Right >= lblFinish.Left)
            {
                lblBahisSonucu.Text = "3 no lu at yarışı kazandı!.";
            }
            else if (pbAt4.Right >= lblFinish.Left)
            {
                lblBahisSonucu.Text = "4 no lu at yarışı kazandı!.";
            }
            DialogResult dr = MessageBox.Show(" Tekrar Oynamak İster misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
             if (dr == DialogResult.Yes)
            {
              pbAt1.Left = pbAt2.Left = pbAt3.Left = pbAt4.Left = 0;
            }
            else
            {
              Application.Exit();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            //Arka planı rasgele değiştirir.
            degisken = rnd.Next(1, 4);
            if(degisken == 1)
            {
              this.BackgroundImage = Properties.Resources.cimen;
              
            }
            else if(degisken == 2)
            {
                this.BackgroundImage = Properties.Resources.kum;
               
            }
            else  
            {
               this.BackgroundImage = Properties.Resources.toprak;
              
            }
            
        }

        private void btnYatir_Click(object sender, EventArgs e)
        {
            yatir = Convert.ToDecimal(txtYatirilacakMiktar.Text);
            atno = Convert.ToDecimal(txtAtNo.Text);
           
           if (degisken == 1)
            {
                if (atno == 1)
                {
                    kazan = yatir * 135 / 100;
                    lblTutar.Text = kazan.ToString("C2");
                }
                else if (atno == 2)
                {
                    kazan = yatir * 180 / 100;
                    lblTutar.Text = kazan.ToString("C2");
                }
                else if (atno == 3)
                {
                    kazan = yatir * 140 / 100;
                    lblTutar.Text = kazan.ToString("C2");
                }
                else if(atno == 4)
                {
                    kazan = yatir * 2;
                    lblTutar.Text = kazan.ToString("C2");
                }
                else
                {
                    MessageBox.Show("Lütfen 1-4 arasında at nosu girin.");
                }
            }
           else if (degisken == 2)
            {
                if (atno == 1)
                {
                    kazan = yatir * 180 / 100;
                    lblTutar.Text = kazan.ToString("C2");
                }
                else if (atno == 2)
                {
                    kazan = yatir * 135 / 100;
                    lblTutar.Text = kazan.ToString("C2");
                }
                else if (atno == 3)
                {
                    kazan = yatir * 2;
                    lblTutar.Text = kazan.ToString("C2");
                }
                else if (atno == 4)
                {
                    kazan = yatir * 145/100;
                    lblTutar.Text = kazan.ToString("C2");
                }
                else
                {
                    MessageBox.Show("Lütfen 1-4 arasında at nosu girin.");
                }
            }
           else if(degisken ==3)
            {
                if (atno == 1)
                {
                    kazan = yatir * 2;
                    lblTutar.Text = kazan.ToString("C2");
                }
                else if (atno == 2)
                {
                    kazan = yatir * 180 / 100;
                    lblTutar.Text = kazan.ToString("C2");
                }
                else if (atno == 3)
                {
                    kazan = yatir * 155 / 100;
                    lblTutar.Text = kazan.ToString("C2");
                }
                else if (atno == 4)
                {
                    kazan = yatir * 140/100;
                    lblTutar.Text = kazan.ToString("C2");
                }
                else
                {
                    MessageBox.Show("Lütfen 1-4 arasında at nosu girin.");
                }
            }

            btnYatir.Enabled = false;
        }

        
    }
}

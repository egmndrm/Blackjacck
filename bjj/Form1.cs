using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bjj
{
    
     
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int sayac = 0;
        int opuan   = 0;
        int kasapuan = 0;
        int toplam;







        public void rastgelesayi()
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //random sayilar belirliyoruz
            rastgelesayi();
            sayac++;
            if(sayac == 1) { 
            int a1, a2;
            a1 = rastgele.Next(1,11) ;
            a2 = rastgele.Next(1, 11);
            toplam = a1 + a2;

                lblSayi1.Text = a1.ToString();
                lblSayi2.Text = a2.ToString();
                lblOyuncu0.Text = toplam.ToString();
            }
            if(sayac == 2)
            {
                //2. basis 3. kart icin deger
                int a3;
                a3 = rastgele.Next(1, 11);
                lblSayi3.Text = a3.ToString();

                toplam = Convert.ToInt32(lblSayi1.Text) + Convert.ToInt32(lblSayi2.Text) + a3;
                lblOyuncu0.Text = toplam.ToString();
            }
            if(sayac == 3)
            {
                int a4 ;
                a4 = rastgele.Next(1, 11);
                lblSayi4.Text = a4.ToString();

                toplam = Convert.ToInt32(lblSayi1.Text)+ Convert.ToInt32(lblSayi2.Text) + Convert.ToInt32(lblSayi3.Text) + a4;
                lblOyuncu0.Text = toplam.ToString();
            }
            if (lblSayi1.Text == "1")
            {
                pictureBox1.ImageLocation = "F:\\bjj\\a.png";
            }
            if (lblSayi1.Text == "2")
            {
                pictureBox1.ImageLocation = "D:\\bjj\\2.png";
            }
            if (lblSayi1.Text == "3")
            {
                pictureBox1.ImageLocation = "D:\\bjj\\3.png";
            }
            if (lblSayi1.Text == "4")
            {
                pictureBox1.ImageLocation = "D:\\bjj\\4.png";
            }
            if (lblSayi1.Text == "5")
            {
                pictureBox1.ImageLocation = "D:\\bjj\\5.png";
            }
            if (lblSayi1.Text == "6")
            {
                pictureBox1.ImageLocation = "D:\\bjj\\6.png";
            }
            if (lblSayi1.Text == "7")
            {
                pictureBox1.ImageLocation = "D:\\bjj\\7.png";
            }
            if (lblSayi1.Text == "8")
            {
                pictureBox1.ImageLocation = "D:\\bjj\\8.png";
            }
            if (lblSayi1.Text == "9")
            {
                pictureBox1.ImageLocation = "D:\\bjj\\9.png";
            }
            if (lblSayi1.Text == "10")
            {
                pictureBox1.ImageLocation = "D:\\bjj\\10.png";
            }
            if (lblSayi1.Text == "1")
            {
                pictureBox1.ImageLocation = "D:\\bjj\\a.png";
            }
            if (lblSayi1.Text == "2")
            {
                pictureBox1.ImageLocation = "D:\\bjj\\2.png";
            }
            if (lblSayi1.Text == "3")
            {
                pictureBox1.ImageLocation = "D:\\bjj\\3.png";
            }
            if (lblSayi1.Text == "4")
            {
                pictureBox1.ImageLocation = "D:\\bjj\\4.png";
            }
            if (lblSayi1.Text == "5")
            {
                pictureBox1.ImageLocation = "D:\\bjj\\5.png";
            }
            if (lblSayi1.Text == "6")
            {
                pictureBox1.ImageLocation = "D:\\bjj\\6.png";
            }
            if (lblSayi1.Text == "7")
            {
                pictureBox1.ImageLocation = "D:\\bjj\\7.png";
            }
            if (lblSayi1.Text == "8")
            {
                pictureBox1.ImageLocation = "D:\\bjj\\8.png";
            }
            if (lblSayi1.Text == "9")
            {
                pictureBox1.ImageLocation = "D:\\bjj\\9.png";
            }
            if (lblSayi1.Text == "10")
            {
                pictureBox1.ImageLocation = "D:\\bjj\\10.png";
            }
            if (lblSayi2.Text == "1")
            {
                pictureBox2.ImageLocation = "D:\\bjj\\a.png";
            }
            if (lblSayi2.Text == "2")
            {
                pictureBox2.ImageLocation = "D:\\bjj\\2.png";
            }
            if (lblSayi2.Text == "3")
            {
                pictureBox2.ImageLocation = "D:\\bjj\\3.png";
            }
            if (lblSayi2.Text == "4")
            {
                pictureBox2.ImageLocation = "D:\\bjj\\4.png";
            }
            if (lblSayi2.Text == "5")
            {
                pictureBox2.ImageLocation = "D:\\bjj\\5.png";
            }
            if (lblSayi2.Text == "6")
            {
                pictureBox2.ImageLocation = "D:\\bjj\\6.png";
            }
            if (lblSayi2.Text == "7")
            {
                pictureBox2.ImageLocation = "D:\\bjj\\7.png";
            }
            if (lblSayi2.Text == "8")
            {
                pictureBox2.ImageLocation = "D:\\bjj\\8.png";
            }
            if (lblSayi2.Text == "9")
            {
                pictureBox2.ImageLocation = "D:\\bjj\\9.png";
            }
            if (lblSayi2.Text == "10")
            {
                pictureBox2.ImageLocation = "D:\\bjj\\10.png";
            }
            if (lblSayi2.Text == "1")
            {
                pictureBox2.ImageLocation = "D:\\bjj\\a.png";
            }
            if (lblSayi2.Text == "2")
            {
                pictureBox2.ImageLocation = "D:\\bjj\\2.png";
            }
            if (lblSayi2.Text == "3")
            {
                pictureBox2.ImageLocation = "D:\\bjj\\3.png";
            }
            if (lblSayi2.Text == "4")
            {
                pictureBox2.ImageLocation = "D:\\bjj\\4.png";
            }
            if (lblSayi2.Text == "5")
            {
                pictureBox2.ImageLocation = "D:\\bjj\\5.png";
            }
            if (lblSayi2.Text == "6")
            {
                pictureBox2.ImageLocation = "D:\\bjj\\6.png";
            }
            if (lblSayi2.Text == "7")
            {
                pictureBox2.ImageLocation = "D:\\bjj\\7.png";
            }
            if (lblSayi2.Text == "8")
            {
                pictureBox2.ImageLocation = "D:\\bjj\\8.png";
            }
            if (lblSayi2.Text == "9")
            {
                pictureBox2.ImageLocation = "D:\\bjj\\9.png";
            }
            if (lblSayi2.Text == "10")
            {
                pictureBox2.ImageLocation = "D:\\bjj\\10.png";
            }
            if (lblSayi3.Text == "1")
            {
                pictureBox3.ImageLocation = "D:\\bjj\\a.png";
            }
            if (lblSayi3.Text == "2")
            {
                pictureBox3.ImageLocation = "D:\\bjj\\2.png";
            }
            if (lblSayi3.Text == "3")
            {
                pictureBox3.ImageLocation = "D:\\bjj\\3.png";
            }
            if (lblSayi3.Text == "4")
            {
                pictureBox3.ImageLocation = "D:\\bjj\\4.png";
            }
            if (lblSayi3.Text == "5")
            {
                pictureBox3.ImageLocation = "D:\\bjj\\5.png";
            }
            if (lblSayi3.Text == "6")
            {
                pictureBox3.ImageLocation = "D:\\bjj\\6.png";
            }
            if (lblSayi3.Text == "7")
            {
                pictureBox3.ImageLocation = "D:\\bjj\\7.png";
            }
            if (lblSayi3.Text == "8")
            {
                pictureBox3.ImageLocation = "D:\\bjj\\8.png";
            }
            if (lblSayi3.Text == "9")
            {
                pictureBox3.ImageLocation = "D:\\bjj\\9.png";
            }
            if (lblSayi3.Text == "10")
            {
                pictureBox3.ImageLocation = "D:\\bjj\\10.png";
            }
            if (lblSayi4.Text == "1")
            {
                pictureBox4.ImageLocation = "D:\\bjj\\a.png";
            }
            if (lblSayi4.Text == "2")
            {
                pictureBox4.ImageLocation = "D:\\bjj\\2.png";
            }
            if (lblSayi4.Text == "3")
            {
                pictureBox4.ImageLocation = "D:\\bjj\\3.png";
            }
            if (lblSayi4.Text == "4")
            {
                pictureBox4.ImageLocation = "D:\\bjj\\4.png";
            }
            if (lblSayi4.Text == "5")
            {
                pictureBox4.ImageLocation = "D:\\bjj\\5.png";
            }
            if (lblSayi4.Text == "6")
            {
                pictureBox4.ImageLocation = "D:\\bjj\\6.png";
            }
            if (lblSayi4.Text == "7")
            {
                pictureBox4.ImageLocation = "D:\\bjj\\7.png";
            }
            if (lblSayi4.Text == "8")
            {
                pictureBox4.ImageLocation = "D:\\bjj\\8.png";
            }
            if (lblSayi4.Text == "9")
            {
                pictureBox4.ImageLocation = "D:\\bjj\\9.png";
            }
            if (lblSayi4.Text == "10")
            {
                pictureBox4.ImageLocation = "D:\\bjj\\10.png";
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b1, b2;
            b1 = rastgele.Next(1, 11);
            b2 = rastgele.Next(1, 11);
            toplam = b1 + b2;

            lblSayi5.Text = b1.ToString();
            lblSayi6.Text = b2.ToString();
            lblkasa0.Text = toplam.ToString();

            if(toplam < 16)
            {
                int b3;
                b3 = rastgele.Next(1, 11);
                lblSayi7.Text = b3.ToString();

                toplam = toplam + b3;
                lblkasa0.Text = toplam.ToString();

            }
            if(toplam < 16)
            {
                int b4;
                b4 = rastgele.Next(1, 11);
                lblSayi8.Text = b4.ToString();

                lblkasa0.Text = toplam.ToString();
            }
            if (lblSayi5.Text == "1")
            {
                pictureBox5.ImageLocation = "D:\\bjj\\a.png";
            }
            if (lblSayi5.Text == "2")
            {
                pictureBox5.ImageLocation = "D:\\bjj\\2.png";
            }
            if (lblSayi5.Text == "3")
            {
                pictureBox5.ImageLocation = "D:\\bjj\\3.png";
            }
            if (lblSayi5.Text == "4")
            {
                pictureBox5.ImageLocation = "D:\\bjj\\4.png";
            }
            if (lblSayi5.Text == "5")
            {
                pictureBox5.ImageLocation = "D:\\bjj\\5.png";
            }
            if (lblSayi5.Text == "6")
            {
                pictureBox5.ImageLocation = "D:\\bjj\\6.png";
            }
            if (lblSayi5.Text == "7")
            {
                pictureBox5.ImageLocation = "D:\\bjj\\7.png";
            }
            if (lblSayi5.Text == "8")
            {
                pictureBox5.ImageLocation = "D:\\bjj\\8.png";
            }
            if (lblSayi5.Text == "9")
            {
                pictureBox5.ImageLocation = "D:\\bjj\\9.png";
            }
            if (lblSayi5.Text == "10")
            {
                pictureBox5.ImageLocation = "D:\\bjj\\10.png";
            }
            if (lblSayi6.Text == "1")
            {
                pictureBox6.ImageLocation = "D:\\bjj\\a.png";
            }
            if (lblSayi6.Text == "2")
            {
                pictureBox6.ImageLocation = "D:\\bjj\\2.png";
            }
            if (lblSayi6.Text == "3")
            {
                pictureBox6.ImageLocation = "D:\\bjj\\3.png";
            }
            if (lblSayi6.Text == "4")
            {
                pictureBox6.ImageLocation = "D:\\bjj\\4.png";
            }
            if (lblSayi6.Text == "5")
            {
                pictureBox6.ImageLocation = "D:\\bjj\\5.png";
            }
            if (lblSayi6.Text == "6")
            {
                pictureBox6.ImageLocation = "D:\\bjj\\6.png";
            }
            if (lblSayi6.Text == "7")
            {
                pictureBox6.ImageLocation = "D:\\bjj\\7.png";
            }
            if (lblSayi6.Text == "8")
            {
                pictureBox6.ImageLocation = "D:\\bjj\\8.png";
            }
            if (lblSayi6.Text == "9")
            {
                pictureBox6.ImageLocation = "D:\\bjj\\9.png";
            }
            if (lblSayi6.Text == "10")
            {
                pictureBox6.ImageLocation = "D:\\bjj\\10.png";
            }
            if (lblSayi7.Text == "1")
            {
                pictureBox7.ImageLocation = "D:\\bjj\\a.png";
            }
            if (lblSayi7.Text == "2")
            {
                pictureBox7.ImageLocation = "D:\\bjj\\2.png";
            }
            if (lblSayi7.Text == "3")
            {
                pictureBox7.ImageLocation = "D:\\bjj\\3.png";
            }
            if (lblSayi7.Text == "4")
            {
                pictureBox7.ImageLocation = "D:\\bjj\\4.png";
            }
            if (lblSayi7.Text == "5")
            {
                pictureBox7.ImageLocation = "D:\\bjj\\5.png";
            }
            if (lblSayi7.Text == "6")
            {
                pictureBox7.ImageLocation = "D:\\bjj\\6.png";
            }
            if (lblSayi7.Text == "7")
            {
                pictureBox7.ImageLocation = "D:\\bjj\\7.png";
            }
            if (lblSayi7.Text == "8")
            {
                pictureBox7.ImageLocation = "D:\\bjj\\8.png";
            }
            if (lblSayi7.Text == "9")
            {
                pictureBox7.ImageLocation = "D:\\bjj\\9.png";
            }
            if (lblSayi7.Text == "10")
            {
                pictureBox7.ImageLocation = "D:\\bjj\\10.png";
            }
            if (lblSayi8.Text == "1")
            {
                pictureBox8.ImageLocation = "D:\\bjj\\a.png";
            }
            if (lblSayi8.Text == "2")
            {
                pictureBox8.ImageLocation = "D:\\bjj\\2.png";
            }
            if (lblSayi8.Text == "3")
            {
                pictureBox8.ImageLocation = "D:\\bjj\\3.png";
            }
            if (lblSayi8.Text == "4")
            {
                pictureBox8.ImageLocation = "D:\\bjj\\4.png";
            }
            if (lblSayi8.Text == "5")
            {
                pictureBox8.ImageLocation = "D:\\bjj\\5.png";
            }
            if (lblSayi8.Text == "6")
            {
                pictureBox8.ImageLocation = "D:\\bjj\\6.png";
            }
            if (lblSayi8.Text == "7")
            {
                pictureBox8.ImageLocation = "D:\\bjj\\7.png";
            }
            if (lblSayi8.Text == "8")
            {
                pictureBox8.ImageLocation = "D:\\bjj\\8.png";
            }
            if (lblSayi8.Text == "9")
            {
                pictureBox8.ImageLocation = "D:\\bjj\\9.png";
            }
            if (lblSayi8.Text == "10")
            {
                pictureBox8.ImageLocation = "D:\\bjj\\10.png";
            }

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            
            btnSonuc.Enabled = false;
            btnYeniOyun.Enabled = true;
            int oynctoplam, kasatoplam;

            oynctoplam = Convert.ToInt32(lblOyuncu0.Text);
            kasatoplam = Convert.ToInt32(lblkasa0.Text);

            if (oynctoplam > kasatoplam && oynctoplam <= 21)
            {
                opuan = opuan + 10;
                lblOyuncuSkor.Text = oynctoplam.ToString();
            }
            if(kasatoplam > oynctoplam && kasatoplam <= 21)
            {
                kasapuan = kasapuan + 10;
                lblKasaSkor.Text = kasatoplam.ToString();
            }
            if (kasatoplam > 21 && oynctoplam > 21)
            {
                MessageBox.Show("Beraberlik");
            }
            if(kasatoplam == oynctoplam && kasatoplam <=21 && oynctoplam <= 21)
            {
                kasapuan = kasapuan + 10;
                opuan = opuan + 10;
            } 
            if (opuan == 70)
            {
                MessageBox.Show("Oyuncu Kazanır");
            }
            if (kasapuan == 70)
            {
                MessageBox.Show("Kasa Kazanır");
            }
            if (kasapuan <= 21 && oynctoplam > 21)
            {
                kasapuan = kasapuan + 10;
                lblKasaSkor.Text = kasatoplam.ToString();
            }
            if (oynctoplam <= 21 && kasatoplam > 21)
            {
                opuan = opuan + 10;
                lblOyuncuSkor.Text = oynctoplam.ToString();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            btnSonuc.Enabled = true;
            btnYeniOyun.Enabled = false;
            sayac = 0;
            lblSayi1.Text = "0 ";
            lblSayi2.Text = "0";
            lblSayi3.Text = "0";
            lblSayi4.Text = "0";
            lblSayi5.Text = "0";
            lblSayi6.Text = "0";
            lblSayi7.Text = "0";
            lblSayi8.Text = "0";
            lblOyuncu0.Text = "0";
            lblkasa0.Text = "0";
            pictureBox1.ImageLocation = "D:\\bjj\\download.jpg";
            pictureBox2.ImageLocation = "D:\\bjj\\download.jpg";
            pictureBox3.ImageLocation = "D:\\bjj\\download.jpg";
            pictureBox3.ImageLocation = "D:\\bjj\\download.jpg";
            pictureBox4.ImageLocation = "D:\\bjj\\download.jpg";
            pictureBox5.ImageLocation = "D:\\bjj\\download.jpg";
            pictureBox6.ImageLocation = "D:\\bjj\\download.jpg";
            pictureBox7.ImageLocation = "D:\\bjj\\download.jpg";
            pictureBox8.ImageLocation = "D:\\bjj\\download.jpg";


        }

        

        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}

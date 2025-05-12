using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Best_Maze
{
    public partial class Best : Form
    {
        public Best()
        {
            InitializeComponent();

        }

        int baslangicsayac = 0, bitissayac = 0, kbaslangicx, kbaslangicy, kbitisx, kbitisy, s = 0, manx, many, golgex, golgey, puan = 0, kayitsayac = 0,kapi1=0;
        int[,] road = new int[100, 2];
        int[,] kayit = new int[30, 2];
        int[,] kayitman = new int[30, 2];
        int[,] kayitgolge = new int[30, 2];


        private void Form1_Load(object sender, EventArgs e)
        {
            fare.Visible = false;
            timer1.Interval = 100;
            MessageBox.Show("Hoşgeldiniz. \nEğer Oyunu İlk Defa Oynayacaksanız, \nLütfen Kurallar Butonundan Kurallara Göz Atınız.");

        }


        public void pbclick(object sender, EventArgs e)
        {
            PictureBox pbox = (sender as PictureBox);
            if (rbbaslangic.Checked == true)
            {
                if (pbox.BackColor != Color.Green && baslangicsayac == 0)
                {
                    pbox.BackColor = Color.Green;
                    baslangicsayac++;
                    kbaslangicx = Convert.ToInt32(pbox.Location.X);
                    kbaslangicy = Convert.ToInt32(pbox.Location.Y);


                }
                else if (pbox.BackColor == Color.Green)
                {
                    pbox.BackColor = Color.Black;
                    baslangicsayac--;
                }

            }
            if (rbBitis.Checked == true)
            {
                if (pbox.BackColor != Color.Red && bitissayac == 0)
                {
                    pbox.BackColor = Color.Red;
                    bitissayac++;
                    kbitisx = Convert.ToInt32(pbox.Location.X);
                    kbitisy = Convert.ToInt32(pbox.Location.Y);


                }
                else if (pbox.BackColor == Color.Red)
                {
                    pbox.BackColor = Color.Black;
                    bitissayac--;

                }
            }
            if (rbYol.Checked == true)
            {


                if (pbox.BackColor != Color.LightGray)
                {
                    pbox.BackColor = Color.LightGray;
                    if (s > 80 && s < 100)
                    {
                        int o = 0;
                        for (o = 0; o < 100; o++)
                        {
                            if (road[o, 0] == 2 && road[o, 1] == 2)
                            {
                                road[o, 0] = Convert.ToInt32(pbox.Location.X);
                                road[o, 1] = Convert.ToInt32(pbox.Location.Y);
                            }
                        } 

                    }
                    road[s, 0] = Convert.ToInt32(pbox.Location.X);
                    road[s, 1] = Convert.ToInt32(pbox.Location.Y);
                    s++;
                }
                else if (pbox.BackColor == Color.LightGray)
                {
                    pbox.BackColor = Color.Black;
                    int o=0;
                    for (o = 0; o < 100; o++)
                    {
                        if (road[o, 0] == pbox.Location.X && road[o, 1] == pbox.Location.Y)
                        {
                            road[o, 0] = 2;
                            road[o, 1] = 2;
                        }

                    }                       
                }
            }


        }


        public void btnbasla_Click(object sender, EventArgs e)
        {
            int sayac2 = 0;


            golgex = kbaslangicx;
            golgey = kbaslangicy;
            manx = kbaslangicx;
            many = kbaslangicy;

            for (sayac2 = 0; sayac2 < 100; sayac2++)
            {
                if (road[sayac2, 0] == manx - 50 && road[sayac2, 1] == many && manx - 50 != golgex)
                {
                    manx -= 50;
                    puan++;
                    goto First;
                }
                else if (road[sayac2, 0] == manx + 50 && road[sayac2, 1] == many && manx + 50 != golgex)
                {
                    manx += 50;
                    puan++;
                    goto First;
                }
                else if (road[sayac2, 0] == manx && road[sayac2, 1] == many + 50 && many + 50 != golgey)
                {
                    many += 50;
                    puan++;
                    goto First;
                }
                else if (road[sayac2, 0] == manx && road[sayac2, 1] == many - 50 && many - 50 != golgey)
                {
                    many -= 50;
                    puan++;
                    goto First;
                }
            }

        First:
            fare.Visible = Enabled;
            fare.Location = new Point(manx, many);
            timer1.Start();
            timer1.Enabled = true;
            if (rbyavas.Checked == true)
            {
                timer1.Interval = 500;
            }
            if (rborta.Checked == true)
            {
                timer1.Interval = 100;
            }
            if (rbhizli.Checked == true)
            {
                timer1.Interval = 10;
            }
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            int sayac1 = 0, sayac2 = 0, ihtimal = 0, kapi = 0;


            //Kayıt Noktası Al
            Boolean[] secenek = new Boolean[4];

            for (sayac2 = 0; sayac2 < 100; sayac2++)
            {
                if (road[sayac2, 0] == manx - 50 && road[sayac2, 1] == many && manx != golgex + 50)
                {
                    secenek[0] = true;
                }
                else if (road[sayac2, 0] == manx + 50 && road[sayac2, 1] == many && manx != golgex - 50)
                {
                    secenek[1] = true;
                }
                else if (road[sayac2, 0] == manx && road[sayac2, 1] == many + 50 && many != golgey - 50)
                {
                    secenek[2] = true;
                }
                else if (road[sayac2, 0] == manx && road[sayac2, 1] == many - 50 && many != golgey + 50)
                {
                    secenek[3] = true;
                }

            }
            int p = 0, i = 0;
            for (p = 0; p < 4; p++)
            {
                if (secenek[p] == true)
                {
                    ihtimal++;
                }
            }
            if (ihtimal > 1)
            {
                int sonuc = 0;
                for (i = 0; i < 30; i++)
                {
                    sonuc = 2;
                    if (kayit[i, 0] == manx && kayit[i, 1] == many)
                    {
                        sonuc = 1;
                        goto celik;
                    }
                }
            celik:
                if (sonuc == 2)
                {
                    kayit[kayitsayac, 0] = manx;
                    kayit[kayitsayac, 1] = many;
                    kayitsayac++;
                    //ihtimal = 0;
                    kapi++;
                }

            }
            //Kayıt Noktası Bitişi

            //Ara Element
            if (ihtimal == 0)
                if (kayitsayac > 1)
                    kayitsayac--;

            //Ara Element Bitiş 
               
            //Yol Bulma Başlangıcı
            for (sayac1 = 0; sayac1 < 100; sayac1++)
            {


                if (road[sayac1, 0] == manx - 50 && road[sayac1, 1] == many && manx != golgex + 50)
                {
                    if (kapi == 1)
                    {
                        kayitgolge[kayitsayac - 1, 0] = golgex;
                        kayitgolge[kayitsayac - 1, 1] = golgey;
                    }
                    golgex = manx;
                    golgey = many;
                    manx -= 50;
                    puan++;
                    if (kapi == 1 || kapi1 ==1)
                    {
                        kayitman[kayitsayac - 1, 0] = manx;
                        kayitman[kayitsayac - 1, 1] = many;
                        kapi--;
                        kapi1--;

                    }
                    goto yolbitis;
                }
                else if (road[sayac1, 0] == manx + 50 && road[sayac1, 1] == many && manx != golgex - 50)
                {
                    if (kapi == 1)
                    {
                        kayitgolge[kayitsayac - 1, 0] = golgex;
                        kayitgolge[kayitsayac - 1, 1] = golgey;
                    }
                    golgex = manx;
                    golgey = many;
                    manx += 50;
                    puan++;
                    if (kapi == 1 || kapi1 == 1)
                    {
                        kayitman[kayitsayac - 1, 0] = manx;
                        kayitman[kayitsayac - 1, 1] = many;
                        kapi--;
                        kapi1--;
                    }
                    goto yolbitis;
                }
                else if (road[sayac1, 0] == manx && road[sayac1, 1] == many + 50 && many != golgey - 50)
                {
                    if (kapi == 1)
                    {
                        kayitgolge[kayitsayac - 1, 0] = golgex;
                        kayitgolge[kayitsayac - 1, 1] = golgey;
                    }
                    golgex = manx;
                    golgey = many;
                    many += 50;
                    puan++;
                    if (kapi == 1 || kapi1 == 1)
                    {
                        kayitman[kayitsayac - 1, 0] = manx;
                        kayitman[kayitsayac - 1, 1] = many;
                        kapi--;
                        kapi1--;
                    }
                    goto yolbitis;
                }
                else if (road[sayac1, 0] == manx && road[sayac1, 1] == many - 50 && many != golgey + 50)
                {
                    if (kapi == 1)
                    {
                        kayitgolge[kayitsayac - 1, 0] = golgex;
                        kayitgolge[kayitsayac - 1, 1] = golgey;
                    }
                    golgex = manx;
                    golgey = many;
                    many -= 50;
                    puan++;
                    if (kapi == 1 || kapi1 == 1)
                    {
                        kayitman[kayitsayac - 1, 0] = manx;
                        kayitman[kayitsayac - 1, 1] = many;
                        kapi--;
                        kapi1--; ///////////////// KAPİLARA DİKKAT LORDUM..
                    }
                    goto yolbitis;
                }

            }

        yolbitis:
            fare.Location = new Point(manx, many);
            //Yol Bitiş

            //Çıkmaz Başlangıç      
            int c;
            if (ihtimal == 0)
            {
                for (c = 0; c < 100; c++)
                {
                    if (road[c, 0] == manx && road[c, 1] == many)
                    {
                        road[c, 0] = 1;
                        road[c, 1] = 1;

                    }

                }
                manx = kayit[kayitsayac - 1, 0];
                many = kayit[kayitsayac - 1, 1];
                golgex = kayitgolge[kayitsayac - 1, 0];
                golgey = kayitgolge[kayitsayac - 1, 1];
                kapi1++;
                

                fare.Location = new Point(manx, many);
            }
            ihtimal = 0;
            //Çıkmaz Bitiş

            //Bitiş Şartı
            if (manx == kbitisx && many == kbitisy)
            {

                timer1.Stop();
                MessageBox.Show(puan + ". Kerede Bulundu...");
                puan = 1;

            }
            //Bitiş Şartı Sonu..
            
        }

        private void btnkurallar_Click(object sender, EventArgs e)
        {
            kural kural = new kural();
            this.Hide();
            kural.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }





    }
}

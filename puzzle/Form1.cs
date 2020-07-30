using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace deneme
{
    public partial class Form1 : Form
    {
        
        ArrayList images = new ArrayList();
        private int a,b,c,d,ee,f,g,h,ı,j,k,l,m,n,o,p;
        int w=0,toplam=0, sayac = 0, sayac1=0, sayac2=0, sayac3 = 0, sayac4 = 0, sayac5 = 0, sayac6 = 0, sayac7 = 0, sayac8 = 0, sayac9 = 0, sayac10 = 0, sayac11 = 0, sayac12 = 0, 
            sayac13 = 0, sayac14 = 0, sayac15 = 0, sayac16 = 0, puan=100;
        bool durum1 = true, durum2 = true, durum3 = true, durum4 = true, durum5 = true, durum6 = true, durum7 = true, durum8 = true, durum9 = true, durum10 = true
            , durum11 = true, durum12 = true, durum13 = true, durum14 = true, durum15 = true, durum16 = true;

        private void button34_Click(object sender, EventArgs e)
        {
            Kontrol();
        }

        public Form1()
        {
            
            InitializeComponent();
            int counter = 0;
                        string line;
                        System.IO.StreamReader file = new System.IO.StreamReader(@"enyüksekskor.txt");
                        int[] sayilar;
                        int m = 0;
                        sayilar = new int[100];
                        while ((line = file.ReadLine()) != null)
                        {
                            counter++;
                            sayilar[m] = Convert.ToInt32(line);
                            m++;
                        }
                        int max = sayilar[0], k = 0;
                        for (int n = 0; n < counter; n++)
                        {
                            //max = sayilar[k];
                            if (sayilar[k] < sayilar[n])
                            {
                                k = n;
                                max = sayilar[n];
                            }

                        }
                        file.Close();
                        String maximum = Convert.ToString(max);
                        label3.Text = "En yüksek skor: " + maximum;

        }

        private void button17_Click(object sender, EventArgs e) //KARIŞTIR
        {
           /* foreach (Button b in panel1.Controls)
                b.Enabled = true;*/

            Image orginal = Image.FromFile(@"-resim-.png");
            

            ResimParcala(orginal, 360, 360);

            ResimEkle(images);
           
            
        }

        private void ResimEkle(ArrayList images)
        {
           
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7 , 8, 9, 10, 11, 12, 13, 14, 15};

            
            button18.Image = (Image)images[arr[0]];
            button19.Image = (Image)images[arr[1]];
            button20.Image = (Image)images[arr[2]];
            button21.Image = (Image)images[arr[3]];
            button22.Image = (Image)images[arr[4]];
            button23.Image = (Image)images[arr[5]];
            button24.Image = (Image)images[arr[6]];
            button25.Image = (Image)images[arr[7]];
            button26.Image = (Image)images[arr[8]];
            button27.Image = (Image)images[arr[9]];
            button28.Image = (Image)images[arr[10]];
            button29.Image = (Image)images[arr[11]];
            button30.Image = (Image)images[arr[12]];
            button31.Image = (Image)images[arr[13]];
            button32.Image = (Image)images[arr[14]];
            button33.Image = (Image)images[arr[15]];


            arr = suffle(arr);

             
            button1.Image = (Image)images[arr[0]];
            button2.Image = (Image)images[arr[1]];
            button3.Image = (Image)images[arr[2]];
            button4.Image = (Image)images[arr[3]];
            button5.Image = (Image)images[arr[4]];
            button6.Image = (Image)images[arr[5]];
            button7.Image = (Image)images[arr[6]];
            button8.Image = (Image)images[arr[7]];
            button9.Image = (Image)images[arr[8]];
            button10.Image = (Image)images[arr[9]];
            button11.Image = (Image)images[arr[10]];
            button12.Image = (Image)images[arr[11]];
            button13.Image = (Image)images[arr[12]];
            button14.Image = (Image)images[arr[13]];
            button15.Image = (Image)images[arr[14]];
            button16.Image = (Image)images[arr[15]];
           
            
        }
        

        private int[] suffle(int[] arr)
        {
            Random rand = new Random();
            arr = arr.OrderBy(x => rand.Next()).ToArray();
            return arr;
        }

        private void ResimParcala(Image orginal, int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h);

            Graphics graphic = Graphics.FromImage(bmp);

            graphic.DrawImage(orginal, 0, 0, w, h);

            graphic.Dispose();

            int movr = 0, movd = 0;

            for (int x = 0; x < 16; x++)
            {
                Bitmap piece = new Bitmap(90, 90);

                for (int i = 0; i < 90; i++)
                    for (int j = 0; j < 90; j++)
                        piece.SetPixel(i, j, bmp.GetPixel(i + movr, j + movd));
                
                images.Add(piece);
                

                movr += 90;

                if (movr ==360)
                {
                    movr = 0;
                    movd += 90;
                }
            }

        }
        
       

        
        private Bitmap yesilYap(Bitmap resim)
        {
            for (int i = 0; i < resim.Height - 1; i++)
            {
                for (int j = 0; j < resim.Width - 1; j++)
                {
                    int deger = resim.GetPixel(j, i).G;
                    Color renk;
                    renk = Color.FromArgb(0, deger, 0);
                    resim.SetPixel(j, i, renk);

                }
            }
            return resim;
        }


        private void Kontrol()
        {
            Bitmap a1 = new Bitmap(button1.Image);
            Bitmap a2 = new Bitmap(button2.Image);
            Bitmap a3 = new Bitmap(button3.Image);
            Bitmap a4 = new Bitmap(button4.Image);
            Bitmap a5 = new Bitmap(button5.Image);
            Bitmap a6 = new Bitmap(button6.Image);
            Bitmap a7 = new Bitmap(button7.Image);
            Bitmap a8 = new Bitmap(button8.Image);
            Bitmap a9 = new Bitmap(button9.Image);
            Bitmap a10 = new Bitmap(button10.Image);
            Bitmap a11 = new Bitmap(button11.Image);
            Bitmap a12 = new Bitmap(button12.Image);
            Bitmap a13 = new Bitmap(button13.Image);
            Bitmap a14 = new Bitmap(button14.Image);
            Bitmap a15 = new Bitmap(button15.Image);
            Bitmap a16 = new Bitmap(button16.Image);
            ////
            Bitmap b1 = new Bitmap(button18.Image);
            Bitmap b2 = new Bitmap(button19.Image);
            Bitmap b3 = new Bitmap(button20.Image);
            Bitmap b4 = new Bitmap(button21.Image);
            Bitmap b5 = new Bitmap(button22.Image);
            Bitmap b6 = new Bitmap(button23.Image);
            Bitmap b7 = new Bitmap(button24.Image);
            Bitmap b8 = new Bitmap(button25.Image);
            Bitmap b9 = new Bitmap(button26.Image);
            Bitmap b10 = new Bitmap(button27.Image);
            Bitmap b11 = new Bitmap(button28.Image);
            Bitmap b12 = new Bitmap(button29.Image);
            Bitmap b13 = new Bitmap(button30.Image);
            Bitmap b14 = new Bitmap(button31.Image);
            Bitmap b15 = new Bitmap(button32.Image);
            Bitmap b16 = new Bitmap(button33.Image);

            sayac = sayac1+sayac2+sayac3+sayac4+sayac5 +sayac6+sayac7 +sayac8+sayac9+sayac10+sayac11+sayac12+sayac13 + sayac14 + sayac15 +sayac16;
            for (int i = 0; i < 90; i++)
            {
                for(int j = 0; j < 90; j++)
                {
                    if (a1.GetPixel(i, j) != b1.GetPixel(i, j))
                    {
                        durum1 = false;
                        //break;
                    }
                    if (a2.GetPixel(i, j) != b2.GetPixel(i, j))
                    {
                        durum2 = false;
                        //break;
                    }
                    if (a3.GetPixel(i, j) != b3.GetPixel(i, j))
                    {
                        durum3 = false;
                        //break;
                    }
                    if (a4.GetPixel(i, j) != b4.GetPixel(i, j))
                    {
                        durum4 = false;
                        //break;
                    }
                    if (a5.GetPixel(i, j) != b5.GetPixel(i, j))
                    {
                        durum5 = false;
                        //break;
                    }
                    if (a6.GetPixel(i, j) != b6.GetPixel(i, j))
                    {
                        durum6 = false;
                        //break;
                    }
                    if (a7.GetPixel(i, j) != b7.GetPixel(i, j))
                    {
                        durum7 = false;
                       // break;
                    }
                    if (a8.GetPixel(i, j) != b8.GetPixel(i, j))
                    {
                        durum8 = false;
                       // break;
                    }
                    if (a9.GetPixel(i, j) != b9.GetPixel(i, j))
                    {
                        durum9 = false;
                        //break;
                    }
                    if (a10.GetPixel(i, j) != b10.GetPixel(i, j))
                    {
                        durum10 = false;
                       // break;
                    }
                    if (a11.GetPixel(i, j) != b11.GetPixel(i, j))
                    {
                        durum11 = false;
                        //break;
                    }
                    if (a12.GetPixel(i, j) != b12.GetPixel(i, j))
                    {
                        durum12 = false;
                       // break;
                    }
                    if (a13.GetPixel(i, j) != b13.GetPixel(i, j))
                    {
                        durum13 = false;
                        //break;
                    }
                    if (a14.GetPixel(i, j) != b14.GetPixel(i, j))
                    {
                        durum14 = false;
                       // break;
                    }
                    if (a15.GetPixel(i, j) != b15.GetPixel(i, j))
                    {
                        durum15 = false;
                        //break;
                    }
                    if (a16.GetPixel(i, j) != b16.GetPixel(i, j))
                    {
                        

                        durum16 = false;
                        //break;
                    }
                    

                }
            }
            for (int i = 0; i < 90; i++)
            {
                for (int j = 0; j < 90; j++)
                {
                    if (a1.GetPixel(i, j) == b1.GetPixel(i, j) && a2.GetPixel(i, j) == b2.GetPixel(i, j) && a3.GetPixel(i, j) == b3.GetPixel(i, j)
                        && a4.GetPixel(i, j) == b4.GetPixel(i, j) && a5.GetPixel(i, j) == b5.GetPixel(i, j) && a6.GetPixel(i, j) == b6.GetPixel(i, j)
                        && a7.GetPixel(i, j) == b7.GetPixel(i, j) && a8.GetPixel(i, j) == b8.GetPixel(i, j) && a9.GetPixel(i, j) == b9.GetPixel(i, j)
                        && a10.GetPixel(i, j) == b10.GetPixel(i, j) && a11.GetPixel(i, j) == b11.GetPixel(i, j) && a12.GetPixel(i, j) == b12.GetPixel(i, j)
                        && a13.GetPixel(i, j) == b13.GetPixel(i, j) && a14.GetPixel(i, j) == b14.GetPixel(i, j) && a15.GetPixel(i, j) == b15.GetPixel(i, j)
                        && a16.GetPixel(i, j) == b16.GetPixel(i, j))
                    {

                        StreamWriter SW = File.AppendText(Application.StartupPath + "\\enyüksekskor.txt");
                        SW.WriteLine(puan);
                       // SW.WriteLine("En son satıra eklendi 2");
                        SW.Close();
                        //label2.Text="TEBRİKLER KAZANDINIZ! ";
                        MessageBox.Show("TEBRİKLER KAZANDINIZ!");
                        
                    }
                }
            }
                    if (durum1 == true)
            {
                Bitmap yesil =yesilYap(a1);
                button1.Image =yesil;
            }
            else if(durum1==false)
            {
                sayac1++;

                durum1 = true;
            }

            if (durum2 == true)
            {
                Bitmap yesil = yesilYap(a2);
                button2.Image = yesil;
                
            }
            else if(durum2 == false)
            {
                durum2 = true;
                sayac2++;
            }
            if (durum3 == true)
            {
                Bitmap yesil = yesilYap(a3);
                button3.Image = yesil;
                
            }
            else if(durum3 == false)
            {
                durum3 = true;
                sayac3++;
            }
            if (durum4 == true)
            {
                Bitmap yesil = yesilYap(a4);
                button4.Image = yesil;
                
            }
            else if (durum4 == false)
            {
               durum4 = true;
                sayac4++;
            }
            if (durum5 == true)
            {
                Bitmap yesil = yesilYap(a5);
                button5.Image = yesil;
                
            }
            else if (durum5 == false)
            {
                durum5 = true;
                sayac5++;
            }
            if (durum6 == true)
            {
                Bitmap yesil = yesilYap(a6);
                button6.Image = yesil;
                
            }
            else if (durum6 == false)
            {
                durum6 = true;
                sayac6++;
            }
            if (durum7 == true)
            {
                Bitmap yesil = yesilYap(a7);
                button7.Image = yesil;
                
            }
            else if (durum7 == false)
            {
                durum7 = true;
                sayac7++;
            }
            if (durum8 == true)
            {
                Bitmap yesil = yesilYap(a8);
                button8.Image = yesil;
                
            }
            else if (durum8 == false)
            {
                durum8 = true;
                sayac8++;
            }
            if (durum9 == true)
            {
                Bitmap yesil = yesilYap(a9);
                button9.Image = yesil;
                
            }
            else if (durum9 == false)
            {
                durum9 = true;
                sayac9++;
            }
            if (durum10 == true)
            {
                Bitmap yesil = yesilYap(a10);
                button10.Image = yesil;
                
            }
            else if (durum10 == false)
            {
                durum10 = true;
                sayac10++;
            }
            if (durum11 == true)
            {
                Bitmap yesil = yesilYap(a11);
                button11.Image = yesil;
                
            }
            else if (durum11 == false)
            {
                durum11 = true;
                sayac11++;
            }
            if (durum12 == true)
            {
                Bitmap yesil = yesilYap(a12);
                button12.Image = yesil;
                
            }
            else if (durum12 == false)
            {
                durum12 = true;
                sayac12++;
            }
            if (durum13 == true)
            {
                Bitmap yesil = yesilYap(a13);
                button13.Image = yesil;
                
            }
            else if (durum13 == false)
            {
                durum13 = true;
                sayac13++;
            }
            if (durum14 == true)
            {
                Bitmap yesil = yesilYap(a14);
                button14.Image = yesil;
                
            }
            else if (durum14 == false)
            {
               durum14 = true;
                sayac14++;
            }
            if (durum15 == true)
            {
                Bitmap yesil = yesilYap(a15);
                button15.Image = yesil;
               
            }
            else if(durum15 == false)
            {
                durum15 = true;
                sayac15++;
            }
            if (durum16 == true)
            {
                Bitmap yesil = yesilYap(a16);
                button16.Image = yesil;
                
            }
            else if (durum16 == false)
            {
               durum16 = true;
                sayac16++;
            }
            toplam = sayac1 + sayac2 + sayac3 + sayac4 + sayac5 + sayac6 + sayac7 + sayac8 + sayac9 + sayac10 + sayac11 + sayac12 + sayac13 + sayac14 + sayac15 + sayac16;

            if (sayac == toplam - sayac+w && w != 0)
            {
                puan = puan + 5;
                label1.Text = "puanınız: " + puan;
            }
            if (sayac == toplam - sayac + 2 && w != 0)
            {
              //puan = puan + 5;
                label1.Text = "puanınız: " + puan;
            }
            else if(sayac != toplam-sayac+1 && w != 0)
            {
                puan = puan - 5;
                label1.Text = "puanınız: " + puan;
            }
            else if (sayac != toplam - sayac + 2 && w != 0)
            {
                puan = puan - 5;
                label1.Text = "puanınız: " + puan;
            }
            if (w == 1)
            {
                toplam = 0; sayac = 0; sayac1 = 0; sayac2 = 0; sayac3 = 0; sayac4 = 0; sayac5 = 0; sayac6 = 0; sayac7 = 0; sayac8 = 0; sayac9 = 0; sayac10 = 0; sayac11 = 0; sayac12 = 0;
                sayac13 = 0; sayac14 = 0; sayac15 = 0; sayac16 = 0; w = 0;
            }
            else
            {
                w++;
            }
            

        }


        

         //////////////////////////// KÜÇÜK RESİMLERİN YERİNİ DEĞİŞİRME
        private void button2_Click(object sender, EventArgs e)
        {
            b = 2;
            
            foreach (Button bb in panel1.Controls)
            {
                
                if (bb == button1 && a == 2)
                {
                    Bitmap x = new Bitmap(button2.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button2.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                    Bitmap x1 = new Bitmap(button18.Image);
                    Bitmap y1 = new Bitmap(button19.Image);
                  /*  for(int i=0; i < 90; i++)
                    {
                        for(int j = 0; j < 90; j++)
                        {
                            if (x.GetPixel(i, j) == x1.GetPixel(i, j)|| y.GetPixel(i, j) == y1.GetPixel(i, j))
                            {
                                puan++;
                                label1.Text = "dogru";
                            }
                        }
                    }*/
                }
                if (bb == button3 && c == 2)
                {
                    Bitmap x = new Bitmap(button2.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button2.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button4 && d == 2)
                {
                    Bitmap x = new Bitmap(button2.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button2.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button5 && ee == 2)
                {
                    Bitmap x = new Bitmap(button2.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button2.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button6 && f == 2)
                {
                    Bitmap x = new Bitmap(button2.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button2.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button7 && g == 2)
                {
                    Bitmap x = new Bitmap(button2.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button2.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button8 && h == 2)
                {
                    Bitmap x = new Bitmap(button2.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button2.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button9 && ı == 2)
                {
                    Bitmap x = new Bitmap(button2.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button2.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button10 && j == 2)
                {
                    Bitmap x = new Bitmap(button2.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button2.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button11 && k == 2)
                {
                    Bitmap x = new Bitmap(button2.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button2.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button12 && l == 2)
                {
                    Bitmap x = new Bitmap(button2.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button2.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button13 && m == 2)
                {
                    Bitmap x = new Bitmap(button2.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button2.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button14 && n == 2)
                {
                    Bitmap x = new Bitmap(button2.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button2.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button15 && o == 2)
                {
                    Bitmap x = new Bitmap(button2.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button2.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button16 && p == 2)
                {
                    Bitmap x = new Bitmap(button2.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button2.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
            }
            Kontrol();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            c = 2;
            foreach (Button bb in panel1.Controls)
            {
                if (bb == button1 && a == 2)
                {
                    Bitmap x = new Bitmap(button3.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button3.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button2 && b == 2)
                {
                    Bitmap x = new Bitmap(button3.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button3.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button4 && d == 2)
                {
                    Bitmap x = new Bitmap(button3.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button3.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button5 && ee == 2)
                {
                    Bitmap x = new Bitmap(button3.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button3.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button6 && f == 2)
                {
                    Bitmap x = new Bitmap(button3.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button3.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button7 && g == 2)
                {
                    Bitmap x = new Bitmap(button3.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button3.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button8 && h == 2)
                {
                    Bitmap x = new Bitmap(button3.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button3.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button9 && ı == 2)
                {
                    Bitmap x = new Bitmap(button3.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button3.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button10 && j == 2)
                {
                    Bitmap x = new Bitmap(button3.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button3.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button11 && k == 2)
                {
                    Bitmap x = new Bitmap(button3.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button3.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button12 && l == 2)
                {
                    Bitmap x = new Bitmap(button3.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button3.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button13 && m == 2)
                {
                    Bitmap x = new Bitmap(button3.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button3.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button14 && n == 2)
                {
                    Bitmap x = new Bitmap(button3.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button3.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button15 && o == 2)
                {
                    Bitmap x = new Bitmap(button3.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button3.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button16 && p == 2)
                {
                    Bitmap x = new Bitmap(button3.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button3.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
            }
            Kontrol();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            d = 2;
            foreach (Button bb in panel1.Controls)
            {
                if (bb == button1 && a == 2)
                {
                    Bitmap x = new Bitmap(button4.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button4.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button2 && b == 2)
                {
                    Bitmap x = new Bitmap(button4.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button4.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button3 && c == 2)
                {
                    Bitmap x = new Bitmap(button4.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button4.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button5 && ee == 2)
                {
                    Bitmap x = new Bitmap(button4.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button4.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button6 && f == 2)
                {
                    Bitmap x = new Bitmap(button4.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button4.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button7 && g == 2)
                {
                    Bitmap x = new Bitmap(button4.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button4.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button8 && h == 2)
                {
                    Bitmap x = new Bitmap(button4.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button4.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button9 && ı == 2)
                {
                    Bitmap x = new Bitmap(button4.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button4.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button10 && j == 2)
                {
                    Bitmap x = new Bitmap(button4.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button4.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button11 && k == 2)
                {
                    Bitmap x = new Bitmap(button4.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button4.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button12 && l == 2)
                {
                    Bitmap x = new Bitmap(button4.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button4.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button13 && m == 2)
                {
                    Bitmap x = new Bitmap(button4.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button4.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button14 && n == 2)
                {
                    Bitmap x = new Bitmap(button4.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button4.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button15 && o == 2)
                {
                    Bitmap x = new Bitmap(button4.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button4.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button16 && p == 2)
                {
                    Bitmap x = new Bitmap(button4.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button4.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
            }
            Kontrol();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            ee = 2;
            foreach (Button bb in panel1.Controls)
            {
                if (bb == button1 && a == 2)
                {
                    Bitmap x = new Bitmap(button5.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button5.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button2 && b == 2)
                {
                    Bitmap x = new Bitmap(button5.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button5.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button3 && c == 2)
                {
                    Bitmap x = new Bitmap(button5.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button5.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button4 && d == 2)
                {
                    Bitmap x = new Bitmap(button5.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button5.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button6 && f == 2)
                {
                    Bitmap x = new Bitmap(button5.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button5.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button7 && g == 2)
                {
                    Bitmap x = new Bitmap(button5.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button5.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button8 && h == 2)
                {
                    Bitmap x = new Bitmap(button5.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button5.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button9 && ı == 2)
                {
                    Bitmap x = new Bitmap(button5.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button5.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button10 && j == 2)
                {
                    Bitmap x = new Bitmap(button5.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button5.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button11 && k == 2)
                {
                    Bitmap x = new Bitmap(button5.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button5.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button12 && l == 2)
                {
                    Bitmap x = new Bitmap(button5.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button5.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button13 && m == 2)
                {
                    Bitmap x = new Bitmap(button5.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button5.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button14 && n == 2)
                {
                    Bitmap x = new Bitmap(button5.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button5.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button15 && o == 2)
                {
                    Bitmap x = new Bitmap(button5.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button5.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button16 && p == 2)
                {
                    Bitmap x = new Bitmap(button5.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button5.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
            }
            Kontrol();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            f = 2;
            foreach (Button bb in panel1.Controls)
            {
                if (bb == button1 && a == 2)
                {
                    Bitmap x = new Bitmap(button6.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button6.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button2 && b == 2)
                {
                    Bitmap x = new Bitmap(button6.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button6.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button3 && c == 2)
                {
                    Bitmap x = new Bitmap(button6.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button6.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button4 && d == 2)
                {
                    Bitmap x = new Bitmap(button6.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button6.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button5 && ee == 2)
                {
                    Bitmap x = new Bitmap(button6.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button6.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button7 && g == 2)
                {
                    Bitmap x = new Bitmap(button6.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button6.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button8 && h == 2)
                {
                    Bitmap x = new Bitmap(button6.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button6.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button9 && ı == 2)
                {
                    Bitmap x = new Bitmap(button6.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button6.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button10 && j == 2)
                {
                    Bitmap x = new Bitmap(button6.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button6.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button11 && k == 2)
                {
                    Bitmap x = new Bitmap(button6.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button6.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button12 && l == 2)
                {
                    Bitmap x = new Bitmap(button6.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button6.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button13 && m == 2)
                {
                    Bitmap x = new Bitmap(button6.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button6.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button14 && n == 2)
                {
                    Bitmap x = new Bitmap(button6.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button6.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button15 && o == 2)
                {
                    Bitmap x = new Bitmap(button6.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button6.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button16 && p == 2)
                {
                    Bitmap x = new Bitmap(button6.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button6.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
            }
            Kontrol();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            g = 2;
            foreach (Button bb in panel1.Controls)
            {
                if (bb == button1 && a == 2)
                {
                    Bitmap x = new Bitmap(button7.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button7.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button2 && b == 2)
                {
                    Bitmap x = new Bitmap(button7.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button7.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button3 && c == 2)
                {
                    Bitmap x = new Bitmap(button7.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button7.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button4 && d == 2)
                {
                    Bitmap x = new Bitmap(button7.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button7.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button5 && ee == 2)
                {
                    Bitmap x = new Bitmap(button7.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button7.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button6 && f == 2)
                {
                    Bitmap x = new Bitmap(button7.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button7.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button8 && h == 2)
                {
                    Bitmap x = new Bitmap(button7.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button7.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button9 && ı == 2)
                {
                    Bitmap x = new Bitmap(button7.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button7.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button10 && j == 2)
                {
                    Bitmap x = new Bitmap(button7.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button7.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button11 && k == 2)
                {
                    Bitmap x = new Bitmap(button7.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button7.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button12 && l == 2)
                {
                    Bitmap x = new Bitmap(button7.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button7.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button13 && m == 2)
                {
                    Bitmap x = new Bitmap(button7.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button7.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button14 && n == 2)
                {
                    Bitmap x = new Bitmap(button7.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button7.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button15 && o == 2)
                {
                    Bitmap x = new Bitmap(button7.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button7.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button16 && p == 2)
                {
                    Bitmap x = new Bitmap(button7.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button7.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
            }
            Kontrol();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            h = 2;
            foreach (Button bb in panel1.Controls)
            {
                if (bb == button1 && a == 2)
                {
                    Bitmap x = new Bitmap(button8.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button8.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button2 && b == 2)
                {
                    Bitmap x = new Bitmap(button8.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button8.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button3 && c == 2)
                {
                    Bitmap x = new Bitmap(button8.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button8.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button4 && d == 2)
                {
                    Bitmap x = new Bitmap(button8.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button8.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button5 && ee == 2)
                {
                    Bitmap x = new Bitmap(button8.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button8.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button6 && f == 2)
                {
                    Bitmap x = new Bitmap(button8.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button8.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button7 && g == 2)
                {
                    Bitmap x = new Bitmap(button8.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button8.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button9 && ı == 2)
                {
                    Bitmap x = new Bitmap(button8.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button8.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button10 && j == 2)
                {
                    Bitmap x = new Bitmap(button8.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button8.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button11 && k == 2)
                {
                    Bitmap x = new Bitmap(button8.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button8.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button12 && l == 2)
                {
                    Bitmap x = new Bitmap(button8.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button8.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button13 && m == 2)
                {
                    Bitmap x = new Bitmap(button8.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button8.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button14 && n == 2)
                {
                    Bitmap x = new Bitmap(button8.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button8.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button15 && o == 2)
                {
                    Bitmap x = new Bitmap(button8.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button8.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button16 && p == 2)
                {
                    Bitmap x = new Bitmap(button8.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button8.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
            }
            Kontrol();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            ı = 2;
            foreach (Button bb in panel1.Controls)
            {
                if (bb == button1 && a == 2)
                {
                    Bitmap x = new Bitmap(button9.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button9.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button2 && b == 2)
                {
                    Bitmap x = new Bitmap(button9.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button9.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button3 && c == 2)
                {
                    Bitmap x = new Bitmap(button9.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button9.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button4 && d == 2)
                {
                    Bitmap x = new Bitmap(button9.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button9.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button5 && ee == 2)
                {
                    Bitmap x = new Bitmap(button9.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button9.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button6 && f == 2)
                {
                    Bitmap x = new Bitmap(button9.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button9.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button7 && g == 2)
                {
                    Bitmap x = new Bitmap(button9.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button9.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button8 && h == 2)
                {
                    Bitmap x = new Bitmap(button9.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button9.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button10 && j == 2)
                {
                    Bitmap x = new Bitmap(button9.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button9.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button11 && k == 2)
                {
                    Bitmap x = new Bitmap(button9.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button9.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button12 && l == 2)
                {
                    Bitmap x = new Bitmap(button9.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button9.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button13 && m == 2)
                {
                    Bitmap x = new Bitmap(button9.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button9.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button14 && n == 2)
                {
                    Bitmap x = new Bitmap(button9.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button9.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button15 && o == 2)
                {
                    Bitmap x = new Bitmap(button9.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button9.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button16 && p == 2)
                {
                    Bitmap x = new Bitmap(button9.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button9.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
            }
            Kontrol();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            j = 2;
            foreach (Button bb in panel1.Controls)
            {
                if (bb == button1 && a == 2)
                {
                    Bitmap x = new Bitmap(button10.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button10.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button2 && b == 2)
                {
                    Bitmap x = new Bitmap(button10.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button10.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button3 && c == 2)
                {
                    Bitmap x = new Bitmap(button10.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button10.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button4 && d == 2)
                {
                    Bitmap x = new Bitmap(button10.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button10.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button5 && ee == 2)
                {
                    Bitmap x = new Bitmap(button10.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button10.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button6 && f == 2)
                {
                    Bitmap x = new Bitmap(button10.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button10.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button7 && g == 2)
                {
                    Bitmap x = new Bitmap(button10.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button10.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button8 && h == 2)
                {
                    Bitmap x = new Bitmap(button10.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button10.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button9 && ı == 2)
                {
                    Bitmap x = new Bitmap(button10.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button10.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button11 && k == 2)
                {
                    Bitmap x = new Bitmap(button10.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button10.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button12 && l == 2)
                {
                    Bitmap x = new Bitmap(button10.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button10.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button13 && m == 2)
                {
                    Bitmap x = new Bitmap(button10.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button10.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button14 && n == 2)
                {
                    Bitmap x = new Bitmap(button10.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button10.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button15 && o == 2)
                {
                    Bitmap x = new Bitmap(button10.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button10.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button16 && p == 2)
                {
                    Bitmap x = new Bitmap(button10.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button10.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
            }
            Kontrol();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            k = 2;
            foreach (Button bb in panel1.Controls)
            {
                if (bb == button1 && a == 2)
                {
                    Bitmap x = new Bitmap(button11.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button11.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button2 && b == 2)
                {
                    Bitmap x = new Bitmap(button11.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button11.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button3 && c == 2)
                {
                    Bitmap x = new Bitmap(button11.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button11.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button4 && d == 2)
                {
                    Bitmap x = new Bitmap(button11.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button11.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button5 && ee == 2)
                {
                    Bitmap x = new Bitmap(button11.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button11.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button6 && f == 2)
                {
                    Bitmap x = new Bitmap(button11.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button11.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button7 && g == 2)
                {
                    Bitmap x = new Bitmap(button11.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button11.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button8 && h == 2)
                {
                    Bitmap x = new Bitmap(button11.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button11.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button9 && ı == 2)
                {
                    Bitmap x = new Bitmap(button11.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button11.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button10 && j == 2)
                {
                    Bitmap x = new Bitmap(button11.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button11.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button12 && l == 2)
                {
                    Bitmap x = new Bitmap(button11.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button11.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button13 && m == 2)
                {
                    Bitmap x = new Bitmap(button11.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button11.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button14 && n == 2)
                {
                    Bitmap x = new Bitmap(button11.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button11.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button15 && o == 2)
                {
                    Bitmap x = new Bitmap(button11.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button11.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button16 && p == 2)
                {
                    Bitmap x = new Bitmap(button11.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button11.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
            }
            Kontrol();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            l = 2;
            foreach (Button bb in panel1.Controls)
            {
                if (bb == button1 && a == 2)
                {
                    Bitmap x = new Bitmap(button12.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button12.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button2 && b == 2)
                {
                    Bitmap x = new Bitmap(button12.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button12.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button3 && c == 2)
                {
                    Bitmap x = new Bitmap(button12.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button12.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button4 && d == 2)
                {
                    Bitmap x = new Bitmap(button12.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button12.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button5 && ee == 2)
                {
                    Bitmap x = new Bitmap(button12.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button12.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button6 && f == 2)
                {
                    Bitmap x = new Bitmap(button12.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button12.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button7 && g == 2)
                {
                    Bitmap x = new Bitmap(button12.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button12.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button8 && h == 2)
                {
                    Bitmap x = new Bitmap(button12.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button12.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button9 && ı == 2)
                {
                    Bitmap x = new Bitmap(button12.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button12.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button10 && j == 2)
                {
                    Bitmap x = new Bitmap(button12.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button12.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button11 && k == 2)
                {
                    Bitmap x = new Bitmap(button12.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button12.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button13 && m == 2)
                {
                    Bitmap x = new Bitmap(button12.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button12.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button14 && n == 2)
                {
                    Bitmap x = new Bitmap(button12.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button12.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button15 && o == 2)
                {
                    Bitmap x = new Bitmap(button12.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button12.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button16 && p == 2)
                {
                    Bitmap x = new Bitmap(button12.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button12.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
            }
            Kontrol();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            m = 2;
            foreach (Button bb in panel1.Controls)
            {
                if (bb == button1 && a == 2)
                {
                    Bitmap x = new Bitmap(button13.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button13.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button2 && b == 2)
                {
                    Bitmap x = new Bitmap(button13.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button13.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button3 && c == 2)
                {
                    Bitmap x = new Bitmap(button13.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button13.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button4 && d == 2)
                {
                    Bitmap x = new Bitmap(button13.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button13.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button5 && ee == 2)
                {
                    Bitmap x = new Bitmap(button13.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button13.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button6 && f == 2)
                {
                    Bitmap x = new Bitmap(button13.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button13.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button7 && g == 2)
                {
                    Bitmap x = new Bitmap(button13.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button13.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button8 && h == 2)
                {
                    Bitmap x = new Bitmap(button13.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button13.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button9 && ı == 2)
                {
                    Bitmap x = new Bitmap(button13.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button13.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button10 && j == 2)
                {
                    Bitmap x = new Bitmap(button13.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button13.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button11 && k == 2)
                {
                    Bitmap x = new Bitmap(button13.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button13.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button12 && l == 2)
                {
                    Bitmap x = new Bitmap(button13.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button13.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button14 && n == 2)
                {
                    Bitmap x = new Bitmap(button13.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button13.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button15 && o == 2)
                {
                    Bitmap x = new Bitmap(button13.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button13.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button16 && p == 2)
                {
                    Bitmap x = new Bitmap(button13.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button13.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
            }
            Kontrol();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            n = 2;
            foreach (Button bb in panel1.Controls)
            {
                if (bb == button1 && a == 2)
                {
                    Bitmap x = new Bitmap(button14.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button14.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button2 && b == 2)
                {
                    Bitmap x = new Bitmap(button14.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button14.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button3 && c == 2)
                {
                    Bitmap x = new Bitmap(button14.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button14.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button4 && d == 2)
                {
                    Bitmap x = new Bitmap(button14.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button14.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button5 && ee == 2)
                {
                    Bitmap x = new Bitmap(button14.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button14.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button6 && f == 2)
                {
                    Bitmap x = new Bitmap(button14.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button14.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button7 && g == 2)
                {
                    Bitmap x = new Bitmap(button14.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button14.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button8 && h == 2)
                {
                    Bitmap x = new Bitmap(button14.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button14.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button9 && ı == 2)
                {
                    Bitmap x = new Bitmap(button14.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button14.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button10 && j == 2)
                {
                    Bitmap x = new Bitmap(button14.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button14.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button11 && k == 2)
                {
                    Bitmap x = new Bitmap(button14.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button14.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button12 && l == 2)
                {
                    Bitmap x = new Bitmap(button14.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button14.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button13 && m == 2)
                {
                    Bitmap x = new Bitmap(button14.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button14.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button15 && o == 2)
                {
                    Bitmap x = new Bitmap(button14.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button14.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button16 && p == 2)
                {
                    Bitmap x = new Bitmap(button14.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button14.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
            }
            Kontrol();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            o = 2;
            foreach (Button bb in panel1.Controls)
            {
                if (bb == button1 && a == 2)
                {
                    Bitmap x = new Bitmap(button15.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button15.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button2 && b == 2)
                {
                    Bitmap x = new Bitmap(button15.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button15.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button3 && c == 2)
                {
                    Bitmap x = new Bitmap(button15.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button15.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button4 && d == 2)
                {
                    Bitmap x = new Bitmap(button15.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button15.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button5 && ee == 2)
                {
                    Bitmap x = new Bitmap(button15.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button15.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button6 && f == 2)
                {
                    Bitmap x = new Bitmap(button15.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button15.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button7 && g == 2)
                {
                    Bitmap x = new Bitmap(button15.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button15.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button8 && h == 2)
                {
                    Bitmap x = new Bitmap(button15.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button15.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button9 && ı == 2)
                {
                    Bitmap x = new Bitmap(button15.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button15.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button10 && j == 2)
                {
                    Bitmap x = new Bitmap(button15.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button15.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button11 && k == 2)
                {
                    Bitmap x = new Bitmap(button15.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button15.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button12 && l == 2)
                {
                    Bitmap x = new Bitmap(button15.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button15.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button13 && m == 2)
                {
                    Bitmap x = new Bitmap(button15.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button15.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button14 && n == 2)
                {
                    Bitmap x = new Bitmap(button15.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button15.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button16 && p == 2)
                {
                    Bitmap x = new Bitmap(button15.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button15.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
            }
            Kontrol();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
            p = 2;
            foreach (Button bb in panel1.Controls)
            {
                if (bb == button1 && a == 2)
                {
                    Bitmap x = new Bitmap(button16.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button16.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button2 && b == 2)
                {
                    Bitmap x = new Bitmap(button16.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button16.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button3 && c == 2)
                {
                    Bitmap x = new Bitmap(button16.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button16.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button4 && d == 2)
                {
                    Bitmap x = new Bitmap(button16.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button16.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button5 && ee == 2)
                {
                    Bitmap x = new Bitmap(button16.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button16.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button6 && f == 2)
                {
                    Bitmap x = new Bitmap(button16.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button16.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button7 && g == 2)
                {
                    Bitmap x = new Bitmap(button16.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button16.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button8 && h == 2)
                {
                    Bitmap x = new Bitmap(button16.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button16.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button9 && ı == 2)
                {
                    Bitmap x = new Bitmap(button16.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button16.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button10 && j == 2)
                {
                    Bitmap x = new Bitmap(button16.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button16.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button11 && k == 2)
                {
                    Bitmap x = new Bitmap(button16.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button16.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button12 && l == 2)
                {
                    Bitmap x = new Bitmap(button16.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button16.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button13 && m == 2)
                {
                    Bitmap x = new Bitmap(button16.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button16.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button14 && n == 2)
                {
                    Bitmap x = new Bitmap(button16.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button16.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button15 && o == 2)
                {
                    Bitmap x = new Bitmap(button16.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button16.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
            }
            Kontrol();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            a = 2;

            foreach (Button bb in panel1.Controls)
            {
                if (bb == button2 && b==2)
                {
                    Bitmap x = new Bitmap(button1.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button1.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button3 && c == 2)
                {
                    Bitmap x = new Bitmap(button1.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button1.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button4 && d == 2)
                {
                    Bitmap x = new Bitmap(button1.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button1.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button5 && ee == 2)
                {
                    Bitmap x = new Bitmap(button1.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button1.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button6 && f == 2)
                {
                    Bitmap x = new Bitmap(button1.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button1.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button7 && g == 2)
                {
                    Bitmap x = new Bitmap(button1.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button1.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button8 && h == 2)
                {
                    Bitmap x = new Bitmap(button1.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button1.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button9 && ı == 2)
                {
                    Bitmap x = new Bitmap(button1.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button1.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button10 && j == 2)
                {
                    Bitmap x = new Bitmap(button1.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button1.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button11 && k == 2)
                {
                    Bitmap x = new Bitmap(button1.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button1.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button12 && l == 2)
                {
                    Bitmap x = new Bitmap(button1.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button1.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button13 && m == 2)
                {
                    Bitmap x = new Bitmap(button1.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button1.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button14 && n == 2)
                {
                    Bitmap x = new Bitmap(button1.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button1.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button15 && o == 2)
                {
                    Bitmap x = new Bitmap(button1.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button1.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
                if (bb == button16 && p == 2)
                {
                    Bitmap x = new Bitmap(button1.Image);
                    Bitmap y = (Bitmap)bb.Image;
                    button1.Image = y;
                    bb.Image = x;
                    a = 0; b = 0; c = 0; d = 0; ee = 0; f = 0; g = 0; h = 0; ı = 0; j = 0; k = 0; l = 0; m = 0; n = 0; o = 0; p = 0;
                }
            }
            Kontrol();
        }
    }
}

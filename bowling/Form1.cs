using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bowling
{
   
    public partial class Form1 : Form
    {
        bowl Glavniibowl = new bowl();
        int propaltolko4to = 0;



        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            
            game.Location = new Point(this.Width*2/3, 500);
            game.Height = this.Height;
             game.Width = this.Width;
            newgame.Location = new Point(this.Width*7 /10, 700);
            newgame.Height = 100;
            newgame.Width = 200;
            outgame.Location = new Point(this.Width *9/ 10, 700);
            outgame.Height = 100;
            outgame.Width = 200;
            pictureBox27.Image = (Image)new Bitmap("neg1L.jpg");
            pictureBox27.Location = new Point(this.Width/2+40,this.Height+400);
            pictureBox28.Image = (Image)new Bitmap("neg2R.jpg");
            pictureBox28.Location = new Point(this.Width / 2 +300, this.Height+400);
            //bowlui.Location = new Point(this.Width / 2-35,this.Height-150);
            //newgame outgame



            bowlui.Visible = false;



        }
        //клик нет в меню
        private void outgame_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //клик да в меню
        private void newgame_Click(object sender, EventArgs e)
        {
            Glavniibowl.moveX = 0;
            Glavniibowl.speed = 1;
            propaltolko4to = 0;
            //Glavniibowl.dvig = false;
            Glavniibowl.speedX = 0;
            game.Visible=false;
            newgame.Visible = false;
            outgame.Visible = false;
            pictureBox27.Visible = true;
            pictureBox28.Visible = true;
            bowlui.Visible = true;
            bowlui.Image = (Image)new Bitmap(@"bowling-3.png");
            bowlui.Location = new Point(this.Width / 2-35,this.Height-150);

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            bort1.Visible = true;
            bort2.Visible = true;



            pictureBox1.Image = (Image)new Bitmap(@"ArrowUp.png");
            pictureBox1.Location = new Point(this.Width / 2 - 30, this.Height - 250);
            pictureBox2.Image = (Image)new Bitmap(@"ArrowDown.png");
            pictureBox2.Location = new Point(this.Width / 2 - 30, this.Height - 100);
            pictureBox3.Image = (Image)new Bitmap(@"ArrowRight.png");
            pictureBox3.Location = new Point(this.Width / 2, this.Height - 120);
            pictureBox4.Image = (Image)new Bitmap(@"ArrowLeft.png");
            pictureBox4.Location = new Point(this.Width / 2 - 100, this.Height - 120);
            pictureBox5.Image = (Image)new Bitmap(@"ArrowUpLeft .png");
            pictureBox5.Location = new Point(this.Width / 2 - 100, this.Height - 200);
            pictureBox6.Image = (Image)new Bitmap(@"ArrowUpRight.png");
            pictureBox6.Location = new Point(this.Width / 2, this.Height - 200);
            pictureBox7.Image = (Image)new Bitmap(@"bowl11.png");
            pictureBox8.Image = (Image)new Bitmap(@"bowl11.png");
            pictureBox9.Image = (Image)new Bitmap(@"bowl11.png");
            pictureBox10.Image = (Image)new Bitmap(@"bowl11.png");
            pictureBox11.Image = (Image)new Bitmap(@"bowl11.png");
            pictureBox11.BringToFront();
            pictureBox12.Image = (Image)new Bitmap(@"bowl11.png");
            pictureBox12.BringToFront();
            pictureBox13.Image = (Image)new Bitmap(@"bowl11.png");
            pictureBox13.BringToFront();
            pictureBox14.Image = (Image)new Bitmap(@"bowl11.png");
            pictureBox14.BringToFront();
            pictureBox15.Image = (Image)new Bitmap(@"bowl11.png");
            pictureBox15.BringToFront();
            pictureBox16.Image = (Image)new Bitmap(@"bowl11.png");
            pictureBox16.BringToFront();
            bort1.Height = this.Height;
            bort2.Height = this.Height;



        }

        //таймер тик
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if(Glavniibowl.dvig)
            {
                //шар катится
                bowlui.Top -= Glavniibowl.speed;
                bowlui.Left += Glavniibowl.speedX;

            }
            if(bowlui.Top<=this.Top)
            {
                Glavniibowl.dvig = false;
                bowlui.Visible = false;
                ++propaltolko4to;
                //сюда с вижном кусок

                game.Visible = true;
                game.Text = "повторим?";
                newgame.Visible = true;
                outgame.Visible = true;
                bort1.Visible = false;
                bort2.Visible = false;
                proshTry.Visible = true;
                proshTry.Height = 100;
                proshTry.Width = 200;

                if (propaltolko4to==1)
                {
                    if (pictureBox16.Visible)
                    {
                        pictureBox26.Image = (Image)new Bitmap(@"pin1.png");
                    }
                    else
                    {
                        pictureBox26.Image = (Image)new Bitmap(@"nepin1.png");
                    }

                    if (pictureBox14.Visible)
                    {
                        pictureBox24.Image = (Image)new Bitmap(@"pin2.png");
                    }
                    else
                    {
                        pictureBox24.Image = (Image)new Bitmap(@"nepin2.png");
                    }
                    if (pictureBox15.Visible)
                    {
                        pictureBox25.Image = (Image)new Bitmap(@"pin3.png");
                    }
                    else
                    {
                        pictureBox25.Image = (Image)new Bitmap(@"nepin3.png");
                    }
                    if (pictureBox13.Visible)
                    {
                        pictureBox23.Image = (Image)new Bitmap(@"pin6.png");
                    }
                    else
                    {
                        pictureBox23.Image = (Image)new Bitmap(@"nepin6.png");
                    }
                    if (pictureBox12.Visible)
                    {
                        pictureBox22.Image = (Image)new Bitmap(@"pin5.png");
                    }
                    else
                    {
                        pictureBox22.Image = (Image)new Bitmap(@"nepin5.png");
                    }
                    if (pictureBox11.Visible)
                    {
                        pictureBox21.Image = (Image)new Bitmap(@"pin4.png");
                    }
                    else
                    {
                        pictureBox21.Image = (Image)new Bitmap(@"nepin4.png");
                    }
                    if (pictureBox10.Visible)
                    {
                        pictureBox20.Image = (Image)new Bitmap(@"pin10.png");
                    }
                    else
                    {
                        pictureBox20.Image = (Image)new Bitmap(@"nepin10.png");
                    }
                    if (pictureBox9.Visible)
                    {
                        pictureBox19.Image = (Image)new Bitmap(@"pin9.png");
                    }
                    else
                    {
                        pictureBox19.Image = (Image)new Bitmap(@"nepin9.png");
                    }
                    if (pictureBox8.Visible)
                    {
                        pictureBox18.Image = (Image)new Bitmap(@"pin8.png");
                    }
                    else
                    {
                        pictureBox18.Image = (Image)new Bitmap(@"nepin8.png");
                    }
                    if (pictureBox7.Visible)
                    {
                        pictureBox17.Image = (Image)new Bitmap(@"pin7.png");
                    }
                    else
                    {
                        pictureBox17.Image = (Image)new Bitmap(@"nepin7.png");
                    }
                }
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox15.Visible = false;
                pictureBox14.Visible = false;
                pictureBox16.Visible = false;

                pictureBox17.Visible = true;
                pictureBox18.Visible = true;
                pictureBox19.Visible = true;
                pictureBox20.Visible = true;
                pictureBox21.Visible = true;
                pictureBox22.Visible = true;
                pictureBox23.Visible = true;
                pictureBox24.Visible = true;
                pictureBox25.Visible = true;
                pictureBox26.Visible = true;



                propaltolko4to = 2;




            }
            if(bowlui.Left<=bort1.Right|| bowlui.Right >= bort2.Left)
            {
               Glavniibowl.speedX = 0;
            }


            if(bowlui.Top<= pictureBox7.Bottom&&((bowlui.Left>= pictureBox7.Left&& bowlui.Left <= pictureBox7.Right) || (bowlui.Right >= pictureBox7.Left && bowlui.Right <= pictureBox7.Right)|| (bowlui.Left <= pictureBox7.Left && bowlui.Right >= pictureBox7.Right)))
            {
                pictureBox7.Visible = false;
            }
            if (bowlui.Top <= pictureBox8.Bottom && ((bowlui.Left >= pictureBox8.Left && bowlui.Left <= pictureBox8.Right) || (bowlui.Right >= pictureBox8.Left && bowlui.Right <= pictureBox8.Right) || (bowlui.Left <= pictureBox8.Left && bowlui.Right >= pictureBox8.Right)))
            {
                pictureBox8.Visible = false;
            }
            if (bowlui.Top <= pictureBox9.Bottom && ((bowlui.Left >= pictureBox9.Left && bowlui.Left <= pictureBox9.Right) || (bowlui.Right >= pictureBox9.Left && bowlui.Right <= pictureBox9.Right) || (bowlui.Left <= pictureBox9.Left && bowlui.Right >= pictureBox9.Right)))
            {
                pictureBox9.Visible = false;
            }
            if (bowlui.Top <= pictureBox10.Bottom && ((bowlui.Left >= pictureBox10.Left && bowlui.Left <= pictureBox10.Right) || (bowlui.Right >= pictureBox10.Left && bowlui.Right <= pictureBox10.Right) || (bowlui.Left <= pictureBox10.Left && bowlui.Right >= pictureBox10.Right)))
            {
                pictureBox10.Visible = false;
            }
            if (bowlui.Top <= pictureBox11.Bottom && ((bowlui.Left >= pictureBox11.Left && bowlui.Left <= pictureBox11.Right) || (bowlui.Right >= pictureBox11.Left && bowlui.Right <= pictureBox11.Right) || (bowlui.Left <= pictureBox11.Left && bowlui.Right >= pictureBox11.Right)))
            {
                pictureBox11.Visible = false;
            }
            if (bowlui.Top <= pictureBox12.Bottom && ((bowlui.Left >= pictureBox12.Left && bowlui.Left <= pictureBox12.Right) || (bowlui.Right >= pictureBox12.Left && bowlui.Right <= pictureBox12.Right) || (bowlui.Left <= pictureBox12.Left && bowlui.Right >= pictureBox12.Right)))
            {
                pictureBox12.Visible = false;
            }
            if (bowlui.Top <= pictureBox13.Bottom && ((bowlui.Left >= pictureBox13.Left && bowlui.Left <= pictureBox13.Right) || (bowlui.Right >= pictureBox13.Left && bowlui.Right <= pictureBox13.Right) || (bowlui.Left <= pictureBox13.Left && bowlui.Right >= pictureBox13.Right)))
            {
                pictureBox13.Visible = false;
            }
            if (bowlui.Top <= pictureBox14.Bottom && ((bowlui.Left >= pictureBox14.Left && bowlui.Left <= pictureBox14.Right) || (bowlui.Right >= pictureBox14.Left && bowlui.Right <= pictureBox14.Right) || (bowlui.Left <= pictureBox14.Left && bowlui.Right >= pictureBox14.Right)))
            {
                pictureBox14.Visible = false;
            }
            if (bowlui.Top <= pictureBox15.Bottom && ((bowlui.Left >= pictureBox15.Left && bowlui.Left <= pictureBox15.Right) || (bowlui.Right >= pictureBox15.Left && bowlui.Right <= pictureBox15.Right) || (bowlui.Left <= pictureBox15.Left && bowlui.Right >= pictureBox15.Right)))
            {
                pictureBox15.Visible = false;
            }
            if (bowlui.Top <= pictureBox16.Bottom && ((bowlui.Left >= pictureBox16.Left && bowlui.Left <= pictureBox16.Right) || (bowlui.Right >= pictureBox16.Left && bowlui.Right <= pictureBox16.Right) || (bowlui.Left <= pictureBox16.Left && bowlui.Right >= pictureBox16.Right)))
            {
                pictureBox16.Visible = false;
            }

        }
        //старт
        private void bowlui_Click(object sender, EventArgs e)
        {
            Glavniibowl.dvig = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;

            pictureBox6.Visible = false;

        }
        //up
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!Glavniibowl.dvig)
            {
                Glavniibowl.speed += 10;
            }

        }
        //down
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!Glavniibowl.dvig)
            {
                Glavniibowl.speed -= 10;
            }
        }
        //right
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!Glavniibowl.dvig)
            {
                Glavniibowl.moveX += 5;
                bowlui.Left += 5;

            }//bowlui.Left += Glavniibowl.moveX;
        }
        //left
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (!Glavniibowl.dvig)
            {
                Glavniibowl.moveX -= 5;
                bowlui.Left -= 5;

            }
        }
        //upright
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (!Glavniibowl.dvig)
            {
                Glavniibowl.speedX += 1;
            }
        }
        //upleft
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (!Glavniibowl.dvig)
            {
                Glavniibowl.speedX -= 1;
            }
            }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
        }
    }



    class bowl
    {
        private int Speed;
        public int speed {
            get
            {
                return Speed;
            }
            set {
               
                if(value < 31)
                {
                    Speed = value;
                }
                else
                {
                    Speed = 31;
                }
                    }
        }
        public int speedX;
        public int moveX;
        public bool dvig;

        public bowl()
        {
            speed = 1;
            speedX = 0;
            moveX = 0;
            dvig = false;
        }



    }
}

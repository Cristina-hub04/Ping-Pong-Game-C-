using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace pingpong
{
    public partial class Form2 : Form
    {
        int viteza = 5;
        int x = 5;
        int y = 5;
        int s1 = 0;
        int s2 = 0;
        int jos;
        int centru;
        int xmid;
        int ymid;
        bool jucatorsus;
        bool jucatorjos;
        int spacebar = 0;
        public Form2()
        {
            InitializeComponent();
           
            jos = ClientSize.Height - jucator1.Height;
            xmid = ClientSize.Width / 2;
            ymid = ClientSize.Height / 2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random locnou = new Random();
            int nou = locnou.Next(100, ClientSize.Height - 100);
            minge.Top -= y;
            minge.Left -= x;

            jucator2.Top += viteza;

            if (jucator2.Top < 0 || jucator2.Top > jos)
            {
                viteza = -viteza;
            }
            if (minge.Left < 0)
            {
                minge.Left = xmid;
                minge.Top = nou;
                x = -x;
                s2++;
                scor2.Text = s2.ToString();

            }
            if (minge.Left + minge.Width > ClientSize.Width)
            {
                minge.Left = xmid;
                minge.Top = nou;
                x = -x;
                s1++;
                scor1.Text = s1.ToString();

            }
            if (minge.Top < 0 || minge.Top + minge.Height > ClientSize.Height)
            {
                y = -y;
            }
            if (minge.Bounds.IntersectsWith(jucator1.Bounds) || minge.Bounds.IntersectsWith(jucator2.Bounds))
            {
                x = -x;
            }
            if (jucatorsus == true && jucator1.Top > 0)
            {
                jucator1.Top -= 10;
            }
            if (jucatorjos == true && jucator1.Top < jos)
            {
                jucator1.Top += 10;
            }
            if (s1 >= 5 || s2 >= 5)
                timer1.Stop();
            if(s1==5)
            {
                MessageBox.Show("jucator1 a castigat!");
               
            }
            if(s2==5)
            {
                MessageBox.Show("jucator2 a castigat!");
            }
            
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                jucatorsus = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                jucatorjos = true;
            }
            if(e.KeyCode == Keys.C)
            {
                Form character = new Form4();
                character.Owner = this;
                timer1.Stop();
                character.Show();
            }
           
            if (e.KeyCode == Keys.Space)
            {
                if (spacebar % 2 == 0)
                {
                    timer1.Stop();

                }
                else
                {
                    timer1.Start();
                }
            }
            spacebar++;
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                jucatorsus = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                jucatorjos = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
    }



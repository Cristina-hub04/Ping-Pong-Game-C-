using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pingpong
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            (this.Owner as Form2).minge.Image = Image.FromFile(@"C:\Users\Cristina\Downloads\pattern1.jpg");
            (this.Owner as Form2).timer1.Start();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            (this.Owner as Form2).minge.Image = Image.FromFile(@"C:\Users\Cristina\Downloads\pattern2.jfif");
            (this.Owner as Form2).timer1.Start();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            (this.Owner as Form2).minge.Image = Image.FromFile(@"C:\Users\Cristina\Downloads\istockphoto-1331291706-612x612.jpg");
            (this.Owner as Form2).timer1.Start();
            this.Hide();
        }
    }
}

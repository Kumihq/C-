using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = ımageList1.Images[0];
            pictureBox2.Image = ımageList1.Images[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random= new Random();

            pictureBox1.Image = ımageList1.Images[random.Next(1, 6)];
            pictureBox2.Image = ımageList1.Images[random.Next(1, 6)];
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkLable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.Links.Add(71, 20, "https://bilgi.baskent.edu.tr");
            linkLabel1.Links.Add(101, 25, "mailto:muhammed@baskent.edu.tr");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int tiklanan;
            tiklanan=linkLabel1.Links.IndexOf(e.Link);
            linkLabel1.Links[tiklanan].Visited = true;
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

//Joshua Lopez
//COSC 1320 001
//Week 6 Project
//10-6-2019
using pictureBoxProject.Properties;
using System;
using System.Windows.Forms;

namespace pictureBoxProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.image1;
        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.image2;
        }

        private void btnShow3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.image3;
        }
    }
}

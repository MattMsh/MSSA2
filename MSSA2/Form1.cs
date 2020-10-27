using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MSSA2
{
    public partial class Form1 : Form
    {
        public static int variant = 16;
        public static double V1 = 50 + Math.Pow(variant, 3);
        public static double V2 = 50 + Math.Pow(variant, 2);
        public static double V3 = 50 + variant;
        public static double h12 = (double)variant / (variant + 5);
        public static double h23 = (double)2 * variant / (2 * variant + 5);
        
        public static double s01 = (double)5 + variant;
        public static double s12 = (V2 + V3) * s01 / (V1 - V1 * h12 + V2 + V3);
        public static double s23 = V3 * s12 / (V2 - V2 * h23 + V3);


        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Model1 model1 = new Model1();
            model1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Model2 model2 = new Model2();
            model2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Model3 model3 = new Model3();
            model3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Visual vis = new Visual();
            vis.Show();
        }
    }
}

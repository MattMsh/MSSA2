using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MSSA2
{
    public partial class Model2 : Form
    {
        public Model2()
        {
            InitializeComponent();
        }

        double V1 = Form1.V1;
        double V2 = Form1.V2;
        double V3 = Form1.V3;
        double h12 = Form1.h12;
        double h23 = Form1.h23;
        double s01 = Form1.s01;

        private void button1_Click(object sender, EventArgs e)
        {
            double s12 = (V2 + V3) * s01 / (V1 - (V1 * h12) + V2 + V3);
            numeric_s12.Value = (decimal)s12;

            double s23 = V3 * s12 / (V2 - (V2 * h23) + V3);
            numeric_s23.Value = (decimal)s23;
        }

        private void Model2_Load(object sender, EventArgs e)
        {
            numeric_h12.Value = (decimal)h12;
            numeric_h23.Value = (decimal)h23;
            numeric_s01.Value = (decimal)s01;
        }
    }
}

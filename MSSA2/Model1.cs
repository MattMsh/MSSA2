using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MSSA2
{
    public partial class Model1 : Form
    {
        public Model1()
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
            double s12 = (double)numeric_s12.Value;
            double s23 = (double)numeric_s23.Value;

            double t1 = (V1 + V2 + V3) / s01;
            double t2 = (V2 + V3) / s12;
            double t3 = V3 / s23;

            numeric_t1.Value = (decimal)t1;
            numeric_t2.Value = (decimal)t2;
            numeric_t3.Value = (decimal)t3;
        }

        private void Model1_Load(object sender, EventArgs e)
        {
            numeric_h12.Value = (decimal)h12;
            numeric_h23.Value = (decimal)h23;
            numeric_s01.Value = (decimal)s01;

            double s12 = ((V2 + V3) * s01)/(V1-V1*h12+V2+V3);
            numeric_s12.Value = (decimal)s12;

            double s23 = (V3 * s12) / (V2 - V2 * h23 + V3);
            numeric_s23.Value = (decimal)s23;
            
        }
    }
}

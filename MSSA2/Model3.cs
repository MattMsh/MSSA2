using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MSSA2
{
    public partial class Model3 : Form
    {
        public Model3()
        {
            InitializeComponent();
        }
        double V1 = Form1.V1;
        double V2 = Form1.V2;
        double V3 = Form1.V3;
        double s01 = Form1.s01;
        private void button1_Click(object sender, EventArgs e)
        {
            double s12 = (double)numeric_s12.Value;
            double s23 = (double)numeric_s23.Value;
            numeric_h12.Value = (decimal)(1 + (V2 / V1) + (V3 / V1) - ((V2 + V3) * s01 / V1 * s12));
            numeric_h23.Value = (decimal)(1 + (V3 / V2) - (V3 * s12 / V2 * s23));
        }

        private void Model3_Load(object sender, EventArgs e)
        {
            numeric_s01.Value = (decimal)s01;
        }
    }
}

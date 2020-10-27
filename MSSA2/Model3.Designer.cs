namespace MSSA2
{
    partial class Model3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numeric_s01 = new System.Windows.Forms.NumericUpDown();
            this.numeric_s12 = new System.Windows.Forms.NumericUpDown();
            this.numeric_s23 = new System.Windows.Forms.NumericUpDown();
            this.numeric_h12 = new System.Windows.Forms.NumericUpDown();
            this.numeric_h23 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_s01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_s12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_s23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_h12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_h23)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Варіант 16";
            // 
            // numeric_s01
            // 
            this.numeric_s01.DecimalPlaces = 3;
            this.numeric_s01.Location = new System.Drawing.Point(112, 81);
            this.numeric_s01.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numeric_s01.Name = "numeric_s01";
            this.numeric_s01.Size = new System.Drawing.Size(120, 20);
            this.numeric_s01.TabIndex = 5;
            // 
            // numeric_s12
            // 
            this.numeric_s12.DecimalPlaces = 3;
            this.numeric_s12.Location = new System.Drawing.Point(112, 107);
            this.numeric_s12.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numeric_s12.Name = "numeric_s12";
            this.numeric_s12.Size = new System.Drawing.Size(120, 20);
            this.numeric_s12.TabIndex = 6;
            // 
            // numeric_s23
            // 
            this.numeric_s23.DecimalPlaces = 3;
            this.numeric_s23.Location = new System.Drawing.Point(112, 133);
            this.numeric_s23.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numeric_s23.Name = "numeric_s23";
            this.numeric_s23.Size = new System.Drawing.Size(120, 20);
            this.numeric_s23.TabIndex = 7;
            // 
            // numeric_h12
            // 
            this.numeric_h12.DecimalPlaces = 3;
            this.numeric_h12.Location = new System.Drawing.Point(112, 232);
            this.numeric_h12.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numeric_h12.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numeric_h12.Name = "numeric_h12";
            this.numeric_h12.Size = new System.Drawing.Size(120, 20);
            this.numeric_h12.TabIndex = 8;
            // 
            // numeric_h23
            // 
            this.numeric_h23.DecimalPlaces = 3;
            this.numeric_h23.Location = new System.Drawing.Point(112, 258);
            this.numeric_h23.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numeric_h23.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numeric_h23.Name = "numeric_h23";
            this.numeric_h23.Size = new System.Drawing.Size(120, 20);
            this.numeric_h23.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Розрахувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "S01 =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "S12 =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "S23 =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "h12 =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "h23 =";
            // 
            // Model3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numeric_h23);
            this.Controls.Add(this.numeric_h12);
            this.Controls.Add(this.numeric_s23);
            this.Controls.Add(this.numeric_s12);
            this.Controls.Add(this.numeric_s01);
            this.Controls.Add(this.label1);
            this.Name = "Model3";
            this.Text = "Model 3";
            this.Load += new System.EventHandler(this.Model3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_s01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_s12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_s23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_h12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_h23)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeric_s01;
        private System.Windows.Forms.NumericUpDown numeric_s12;
        private System.Windows.Forms.NumericUpDown numeric_s23;
        private System.Windows.Forms.NumericUpDown numeric_h12;
        private System.Windows.Forms.NumericUpDown numeric_h23;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
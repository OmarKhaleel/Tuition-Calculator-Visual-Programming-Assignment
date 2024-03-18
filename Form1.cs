using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuitionCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int collegeFee;
        int majorFee;
        int numCourses;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (rBtnIT.Checked)
            {
                collegeFee = 100;
            } else if (rBtnEng.Checked)
            {
                collegeFee = 200;
            } else if (rBtnBusiness.Checked)
            {
                collegeFee = 300;
            }

          
            if (rBtnCS.Checked)
            {
                majorFee = 100;
            } else if (rBtnSoftware.Checked)
            {
                majorFee = 110;
            } else if (rBtnGraphics.Checked)
            {
                majorFee = 120;
            } else if (rBtnEng2.Checked)
            {
                majorFee = 130;
            }

            numCourses = 0;
            if (checkBox1.CheckState == CheckState.Checked)
            {
                numCourses++;
            } 

            if (checkBox2.CheckState == CheckState.Checked)
            {
                numCourses++;
            }

            if (checkBox3.CheckState == CheckState.Checked)
            {
                numCourses++;
            }

            if (checkBox4.CheckState == CheckState.Checked)
            {
                numCourses++;
            }

            if (checkBox5.CheckState == CheckState.Checked)
            {
                numCourses++;
            }
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            int totalFee = numCourses * majorFee + collegeFee - (10 * (int) numericUpDown1.Value);
            MessageBox.Show($"Total Fees = {totalFee}", "Fees Calculator", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Weighed_Grade_Calculator
{
    public partial class PartsPopup : Form
    {
        double remainingP;
        Calculator calc;
        public PartsPopup(double a, Calculator c)
        {
            InitializeComponent();
            remainingP = a;
            calc = c;
            messageTxt.Text = "Enter the weight part you have " + remainingP + " percent left of the weighed total";
        }

        private void submitbttn_Click(object sender, EventArgs e)
        {
            double num1, num2;
            bool isNum1 = double.TryParse(gradeTxtBox.Text, out num1);
            bool isNum2 = double.TryParse(weightTxtBox.Text, out num2);
            if (isNum1 && isNum2)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Enter data in this form 00.00 i.e. 87.81 as this fourm cannot take number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PartsPopup_FormClosing(object sender, FormClosingEventArgs e)
        {
            calc.addToTotal(double.Parse(weightTxtBox.Text),double.Parse(gradeTxtBox.Text));
        }
    }
}

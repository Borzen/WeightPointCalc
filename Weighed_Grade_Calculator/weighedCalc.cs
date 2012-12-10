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
    public partial class WeighedCalculator : Form
    {
        public WeighedCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Num;
            bool isNum = double.TryParse(GWtxtBox.Text, out Num);
            if (isNum)
            {
               Calculator c = new Calculator(int.Parse(WPtxtBox.Text), Num, double.Parse(FinaltxtBox.Text));
               c.getParts();
                
            }
            else
            {
                Calculator c = new Calculator(int.Parse(WPtxtBox.Text), GWtxtBox.Text[0], double.Parse(FinaltxtBox.Text));
                c.getParts();
            }
        }
    }
}

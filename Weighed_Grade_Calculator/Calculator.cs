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
    public class Calculator
    {
        double totalP = 100;
        double finalP;
        double gradeWanted;
        int numberOfParts;
        double[] weighedTotals;
        int p = 0;
        double totalG;
        double needOnF;
        public Calculator(int a, double b, double c)
        {
            numberOfParts = a - 1;
            gradeWanted = b;
            finalP = c;
            totalP -= finalP;
            weighedTotals = new double[numberOfParts];
        }
        public Calculator(int a, char b, double c)
        {
            numberOfParts = a - 1;
            switch (char.ToUpper(b))
            {
                case 'A':
                    gradeWanted = 90;
                    break;
                case 'B':
                    gradeWanted = 80;
                    break;
                case 'C':
                    gradeWanted = 70;
                    break;
                case 'D':
                    gradeWanted = 60;
                    break;
                default:
                    gradeWanted = 50;
                    break;
            }
            finalP = c;
            totalP -= finalP;
            weighedTotals = new double[numberOfParts];
        }

        public void getParts()
        {
            PartsPopup pp = new PartsPopup(totalP, this);
            pp.Show();
            
        }
        public void addToTotal(double weight, double precent)
        {
            totalP -= weight;
            weight /= 100;
            weighedTotals[p] = weight * precent;
            if (p+1 < numberOfParts)
            {
                p++;
                getParts();
            }
            else
            {
                CalculateNeed();
            }
            
        }
        public void CalculateNeed()
        {
            totalG = 0;
            for (int i = 0; i < weighedTotals.Length; i++)
            {
                totalG += weighedTotals[i];
            }
            MessageBox.Show("Total Grade: "+(totalG/(100-finalP))*100, "Test", MessageBoxButtons.OK, MessageBoxIcon.Question);
            needOnF = (gradeWanted - totalG) / (finalP / 100);
            if (needOnF > 100)
            {
                totalG += finalP;
                MessageBox.Show("You cannot get " + gradeWanted + " as you would need to get over 100% \n The highest grade you can get in the class is " + totalG,"No grade", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else
            {
                MessageBox.Show("You need a " + needOnF + " to get a " + gradeWanted, "Needed on Final", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

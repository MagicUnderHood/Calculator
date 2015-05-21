using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double saved = 0;
        private char sign = ' ';
        private int keyPoint = 0;
        private int keyPoint2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            display.Text = "0";
            signsDisplay.Text = "";
            keyPoint = 0;
            keyPoint2 = 0;
        }

        private void NumberButtonClick(object sender, EventArgs e)
        {
            Button tmpButton = (Button)sender;
            if (signsDisplay.Text == "")
            {
                int tmp = Convert.ToInt32(tmpButton.Text);
                    if (keyPoint == 0)
                    {
                        display.Text = Convert.ToString(Convert.ToDouble(display.Text) * 10 + tmp);
                    }
                    else
                    {
                        display.Text = Convert.ToString(Convert.ToDouble(display.Text) + tmp * Math.Pow(10, -(double)keyPoint));
                        keyPoint++;
                    }
            }
            else
            {
                display.Text = Convert.ToString(Convert.ToInt32(tmpButton.Text));
                signsDisplay.Text = "";
            }
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            saved = Convert.ToDouble(display.Text);
            sign = '+';
            signsDisplay.Text = "+";
            keyPoint2 = 0;
        }

        private void EqualButtonClick(object sender, EventArgs e)
        {
            double tmp = Convert.ToDouble(display.Text);
            signsDisplay.Text = "=";
            switch (sign)
            {
                case '+':
                    display.Text = Convert.ToString(saved + tmp);
                    sign = ' ';
                    saved = 0;
                    break;
                case '-':
                    display.Text = Convert.ToString(saved - tmp);
                    sign = ' ';
                    saved = 0;
                    break;
                case 'x':
                    display.Text = Convert.ToString(saved * tmp);
                    sign = ' ';
                    saved = 0;
                    break;
                case '/':
                    display.Text = Convert.ToString(saved / tmp);
                    sign = ' ';
                    saved = 0;
                    break;
            }
        }

        private void SubtractionButtonClick(object sender, EventArgs e)
        {
            saved = Convert.ToDouble(display.Text);
            sign = '-';
            signsDisplay.Text = "-";
            keyPoint2 = 0;
        }

        private void MultiplyButtonClick(object sender, EventArgs e)
        {
            saved = Convert.ToDouble(display.Text);
            sign = 'x';
            signsDisplay.Text = "x";
            keyPoint2 = 0;
        }

        private void DivisionButtonClick(object sender, EventArgs e)
        {
            saved = Convert.ToDouble(display.Text);
            sign = '/';
            signsDisplay.Text = "/";
            keyPoint2 = 0;
        }

        private void pointButton_Click(object sender, EventArgs e)
        {
            if (keyPoint2 == 0)
            {
                keyPoint = 1;
                keyPoint2 = 1;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}

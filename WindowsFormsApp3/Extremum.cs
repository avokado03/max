using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    //Форма вычисления экстремумов функции
    public partial class Extremum : Form
    {
        public Extremum()
        {
            InitializeComponent();
        }

        //Вычисления экстремумов функции
        private void button1_Click(object sender, EventArgs e)
        {
            double xn = -2.85, xk = 5.2, xh = 0.5, y = 0, yMin = 0, yMax = 0;
            List<double> yValue = new List<double>();
            try
            {
                double x = Convert.ToDouble(xValue.Text);
                double a = Convert.ToDouble(aValue.Text);
                while (xn < xk)
                {
                    if (x <= 0)
                    {
                        y = 1.0 / Math.Tan(Math.Pow(3 * xn - 1, 2));
                    }
                    else if (x > 0 && x <= a)
                    {
                        y = 2 + xn * Math.Exp(-xn);
                    }
                    else if (x > a)
                    {
                        y = Math.Sin(Math.Pow(xn, 3) + 1);
                    }

                    yValue.Add(y);

                    xn += xh;
                }
                yValue.Sort();
                yMax = Math.Round(yValue[yValue.Count - 1], 2);
                yMin = Math.Round(yValue[0], 2);
                resultTextBox.Text = "yMax = " + yMax + "\tyMin = " + yMin;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Переход на главную форму
        private void Extremum_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = Application.OpenForms[0];
            f.Show();
        }
    }
}

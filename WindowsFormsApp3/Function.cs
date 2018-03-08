using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    //Форма вычисления значения функции
    public partial class Function : Form
    {
        public Function()
        {
            InitializeComponent();
        }

        //Вычисление значения функции
        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0, x = 0, result = 0;

            try
            {
                a = Convert.ToDouble(aValue.Text);
                x = Convert.ToDouble(xValue.Text);

                if (x <= 0)
                {
                    result = Math.Abs(Math.Pow((2 * x + 5) / (Math.Pow(x, 3) + 2), 1.0 / 3));
                }
                else if (x > 0 && x <= a)
                {
                    result = (5 * x + Math.Pow(x, 2)) / (Math.Pow(Math.Pow(x, 2) + 3, 3));
                }
                else if (x > a)
                {
                    result = Math.Pow(Math.Cos(Math.Pow(x, 3) + Math.Sqrt(x)), 2);
                }

                resultTextBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        //Переход на главную форму
        private void Function_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = Application.OpenForms[0];
            f.Show();
        }
    }
}

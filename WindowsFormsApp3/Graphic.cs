using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    //Форма построения графика функции
    public partial class Graphic : Form
    {
        public Graphic()
        {
            InitializeComponent();
        }

        double xn = -3.78;
        double xk = 18.10;
        double xh = 0.33;

        //Отрисовка стандартного графика
        private void Form1_Load(object sender, EventArgs e)
        {
            draw();
        }

        //Метод отрисовки графика функции
        public void draw()
        {
            try
            {
                int count = (int)Math.Ceiling((xk - xn) / xh) + 1;
                double[] x = new double[count];
                double[] y = new double[count];
                for (int i = 0; i < count; i++)
                {
                    x[i] = xn + xh * i;
                    y[i] = (Math.Exp(x[i]) * Math.Log10(Math.Abs(x[i]))) / (1.0 / (Math.Tan(Math.Pow(3 * x[i] - 1, 2))));
                }
                functionGraphic.Series[0].Points.DataBindXY(x, y);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Получение значений и вызов метода отрисовки графика
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                xn = Convert.ToDouble(xnValue.Text);
                xk = Convert.ToDouble(xkValue.Text);
                xh = Convert.ToDouble(xhValue.Text);
                draw();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Переход на главную форму
        private void Graphic_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = Application.OpenForms[0];
            f.Show();
        }
    }
}

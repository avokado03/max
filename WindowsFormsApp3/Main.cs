using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    //Главная форма приложения
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //Переход на форму вычисления экстремумов функции
        private void button2_Click(object sender, EventArgs e)
        {
            Extremum f = new Extremum();
            f.Show();
            this.Hide();
        }

        //Переход на форму построения графика
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Graphic f = new Graphic();
            f.Show();
        }

        //Переход на форму вычисления значения функции
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Function f = new Function();
            f.Show();
        }

        //Переход на форму обработки одномерного массива
        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            StandartArray f = new StandartArray();
            f.Show();
        }

        //Переход на форму обработки матрицы
        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Matrix f = new Matrix();
            f.Show();
        }

        //Выход из программы
        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    //Форма обработки элементов одномерного массива
    public partial class StandartArray : Form
    {
        public StandartArray()
        {
            InitializeComponent();
        }

        //Инициализация и обработка значений одномерного массива
        private void button1_Click(object sender, EventArgs e)
        {
            arrayItemsList.Items.Clear();
            Random rnd = new Random();
            double average = 1;
            int max = 0;
            int maxAbs = 0;
            try
            {
                int[] array = new int[Convert.ToInt32(arrayLenght.Text)];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(-50, 70);
                    arrayItemsList.Items.Add("["+i+"] " + array[i]);
                    if (Math.Abs(array[i]) % 2 == 0 && array[i] > max)
                        max = array[i];
                    if (Math.Abs(array[i]) > array[maxAbs])
                    {
                        maxAbs = i;
                    }
                    if (Math.Abs(array[i]) % 2 == 0)
                        average *= array[i];
                }
                averageItems.Text = Math.Round(Math.Pow(average, 1.0 / array.Length), 2).ToString();
                maxAbsIndexItem.Text = maxAbs.ToString();
                maxItem.Text = max.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Переход на главную форму
        private void StandartArray_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = Application.OpenForms[0];
            f.Show();
        }
    }
}

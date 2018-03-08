using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    //Форма обработки элементов матрицы
    public partial class Matrix : Form
    {
        public Matrix()
        {
            InitializeComponent();
            matrixView.RowHeadersVisible = false;
        }

        //Переход на главную форму
        private void Matrix_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = Application.OpenForms[0];
            f.Show();
        }

        //Инициализация матрицы и обработка ее элементов
        private void button1_Click(object sender, EventArgs e)
        {
            int rCount, cCount;
            Random r = new Random();
            try
            {
                rCount = Convert.ToInt32(rowCount.Text);
                cCount = Convert.ToInt32(cellsCount.Text);
                int multFive = 0;   //+%5
                int sumOdd = 0;     //сумма нечетных
                int posDiag = 0;    //кол-во положительных на побочной
                int multThree = 0;  //+%3
                int countOdd = 0;   //нечетные второго столбца
                int [,]arr = new int[rCount,cCount];
                matrixView.RowCount = rCount;
                matrixView.ColumnCount = cCount;
                if (rCount == cCount)
                {
                    //заполнение массива, гридвьюва, изменение бэкграунда побочной диагонали и нахождение
                    //на ней положительных
                    for (int i = 0; i < rCount; i++)
                    {
                        for (int j = 0; j < cCount; j++)
                        {
                            arr[i, j] = r.Next(-50, 50);
                            matrixView[i, j].Value = arr[i, j];
                            matrixView.Rows[i].Cells[j].Style.BackColor = Color.White;
                            if (i == cCount - j - 1)
                            {
                                matrixView.Rows[i].Cells[j].Style.BackColor = Color.Coral;
                                if (arr[i, j] > 0)
                                    posDiag++;
                            }
                        }
                    }
                    //поиск всего на свете
                    for (int i = 0; i < rCount; i++)
                    {
                        for (int j = 0; j < cCount; j++)
                        {
                            if (arr[i, j] > 0 && arr[i, j] % 5 == 0)
                                multFive++;
                            if (arr[i, j] % 2 != 0)
                                sumOdd += arr[i, j];
                            if (rCount == 6 && cCount == 6)
                            {
                                if (i == 0 && arr[i, j] > 0 && arr[i, j] % 3 == 0)
                                    multThree++;
                                if (j == 1 && arr[j, i] % 2 != 0)
                                    countOdd++;
                                countArrayItems.Text = "Кратных 3 - " + multThree + " Нечетных - " + countOdd;
                            }
                            else
                            {
                                countArrayItems.Text = "Размер матрицы должен быть 6х6";
                            }
                        }
                    }
                    //для матрицы 6х6
                    
                    countItems.Text = Convert.ToString(multFive);
                    opItems.Text = Convert.ToString(sumOdd * posDiag);
                }
                else
                {
                    MessageBox.Show("Количество строк и столбцов должно совпадать");
                }
            }
            catch {
                MessageBox.Show("Ошибка");
            }
            /*try
            {
                int cCount = Convert.ToInt32(cellsCount.Text);
                int rCount = Convert.ToInt32(rowCount.Text);
                if (cCount == rCount)
                {
                    matrixView.ColumnCount = cCount;
                    matrixView.RowCount = rCount;
                    Random rnd = new Random();
                    int count = 0;
                    int op = 0;
                    int sum = 0;
                    int countDiag = 0;
                    for (int i = 0; i < matrixView.RowCount; i++)
                    {
                        for (int j = 0; j < matrixView.ColumnCount; j++)
                        {
                            matrixView[j, i].Value = rnd.Next(-50, 50);
                            if ((int)matrixView[j, i].Value % 5 == 0 && (int)matrixView[j, i].Value > 0)
                                count++;
                            if (Math.Abs((int)matrixView[j, i].Value) % 2 == 1)
                                sum += (int)matrixView[j, i].Value;
                            if (i + j == matrixView.RowCount - 1)
                            {
                                matrixView[j, i].Style.BackColor = Color.Coral;
                                if ((int)matrixView[j, i].Value > 0)
                                    countDiag++;
                            }
                            else
                            {
                                matrixView[j, i].Style.BackColor = DefaultBackColor;
                            }
                        }
                    }
                    op = countDiag * sum;

                    int countA = 0;
                    int countA2 = 0;
                    int[,] array = new int[6, 6];
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            array[j, i] = rnd.Next(-50, 50);
                            if (i == 0 && array[j, i] > 0 && array[j, i] % 3 == 0)
                                countA++;
                            if (j == 1 && Math.Abs(array[j, i]) % 2 == 1)
                                countA2++;
                        }
                    }
                    countItems.Text = count.ToString();
                    opItems.Text = op.ToString();
                    countArrayItems.Text = "Положительных: " + countA + "\tНечетных: " + countA2;
                }
                else
                {
                    MessageBox.Show("Количество строк и столбцов должно быть одинаковым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        //Отключение возможности выбора ячейки матрицы
        private void matrixView_SelectionChanged(object sender, EventArgs e)
        {
            matrixView.ClearSelection();
        }
    }
}

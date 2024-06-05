using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач
{
    public partial class Form1 : Form
    {
        private SortArray sortArray = new SortArray();

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_array_to_File_Click(object sender, EventArgs e)
        {
            // выбор файла
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // чтение файла
                    string line = File.ReadAllText(openFileDialog.FileName);

                    // проверка на пустоту
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        MessageBox.Show("Файл пуст.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    // преобразовал файла в массив целых
                    string[] numbers = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int[] array = Array.ConvertAll(numbers, int.Parse);
                    sortArray.setArray(array);
                    
                    // обновление таблиц
                    UpdateDataGridView(array);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при считывании файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button_general_array_Click(object sender, EventArgs e)
        {
            try
            {
                // чтение размера массива из текстового поля
                int size = int.Parse(size_Array.Text);
                Random random = new Random();
                int[] array = new int[size];
                for (int i = 0; i < size; i++) 
                {
                    array[i] = random.Next(100);
                }

                sortArray.setArray(array);
                UpdateDataGridView(array);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректный размер массива.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_sort_Click(object sender, EventArgs e)
        {
            try
            {
                if (radio_Bubble_sort.Checked)
                {
                    sortArray.bubbleSort();
                }
                else if (radio_Quick_sort.Checked)
                {
                    sortArray.quickSort();
                }

                int[] sortedArray = sortArray.getArray();
                UpdateDataGridView(sortedArray);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сортировке массива: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDataGridView(int[] array)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            for (int i = 0; i < array.Length; i++)
            {
                dataGridView1.Columns.Add($"ArrayColumn{i}", $"{i + 1}");
            }

            dataGridView1.Rows.Add();
            for (int i = 0; i < array.Length; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = array[i];
            }

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
        }
        private void Button_WriteArrayToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int[] array = sortArray.getArray();
                    string content = string.Join(" ", array);
                    File.WriteAllText(saveFileDialog.FileName, content);
                    MessageBox.Show("Массив успешно записан в файл.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при записи файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public class SortArray
        {
            public int[] array { get; private set; }

            public SortArray()
            {
                array = new int[0];
            }

            public SortArray(int[] array)
            {
                this.array = array;
            }

            public void setArray(int[] array)
            {
                this.array = array;
            }

            public int[] getArray()
            {
                return array;
            }

            public void bubbleSort()
            {
                int n = array.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }

            public void quickSort()
            {
                quickSort(0, array.Length - 1);
            }

            private void quickSort(int low, int high)
            {
                if (low < high)
                {
                    int pi = Partition(low, high);
                    quickSort(low, pi - 1);
                    quickSort(pi + 1, high);
                }
            }

            private int Partition(int low, int high)
            {
                int pivot = array[high];
                int i = low - 1;
                for (int j = low; j < high; j++)
                {
                    if (array[j] < pivot)
                    {
                        i++;
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
                int temp1 = array[i + 1];
                array[i + 1] = array[high];
                array[high] = temp1;
                return i + 1;
            }

            public void printArray()
            {
                foreach (int i in array)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

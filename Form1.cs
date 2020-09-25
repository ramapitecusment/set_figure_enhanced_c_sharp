using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arr
{
    public partial class Form1 : Form
    {
        int[,] a = new int[11,11];
        int k;

        public Form1()
        {
            InitializeComponent();      
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            prepareDataGridView();
            int matrix = dataGridView1.ColumnCount;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    k = 1;
                    for (int i = 0; i < matrix; i++)
                    {
                        for (int j = 0; j < k; j++)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = "0";
                        }
                        k++;
                    }
                    break;
                case 1:
                    k = -1;
                    for (int i = 0; i < matrix; i++)
                    {
                        for (int j = dataGridView1.RowCount-1; j > k; j--)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = "0";
                        }
                        k++;
                    }
                    break;
                case 2:
                    k = matrix-2;
                    for (int i = 0; i < matrix; i++)
                    {
                        for (int j = dataGridView1.RowCount - 1; j > k; j--)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = "0";
                        }
                        k--;
                    }
                    break;
                case 3:
                    k = matrix;
                    for (int i = 0; i < matrix; i++)
                    {
                        for (int j = 0; j < k; j++)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = "0";
                        }
                        k--;
                    }
                    break;
                case 4:
                    k = matrix;
                    for (int i = 0; i < (matrix+1)/2; i++)
                    {
                        for (int j = i; j < k; j++)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = "0";
                        }
                        k--;
                    }
                    break;
                case 5:
                    k = -1;
                    for (int i = matrix-1; i >= ((matrix + 1) / 2)-1; i--)
                    {
                        for (int j = i; j > k; j--)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = "0";
                        }
                        k++;
                    }
                    break;
                case 6:
                    k = matrix;
                    for (int i = 0; i < (matrix + 1) / 2; i++)
                    {
                        for (int j = i; j < k; j++)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = "0";
                        }
                        k--;
                    }
                    k = -1;
                    for (int i = matrix - 1; i >= ((matrix + 1) / 2) - 1; i--)
                    {
                        for (int j = i; j > k; j--)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = "0";
                        }
                        k++;
                    }
                    break;

                case 7:
                    k = matrix;
                    for (int j = 0; j < (matrix + 1) / 2; j++)
                    {
                        for (int i = j; i < k; i++)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = "0";
                        }
                        k--;
                    }
                    break;
                case 8:
                    k = -1;
                    for (int j = matrix - 1; j >= ((matrix + 1) / 2) - 1; j--)
                    {
                        for (int i = j; i > k; i--)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = "0";
                        }
                        k++;
                    }
                    break;
                case 9:
                    k = matrix;
                    for (int j = 0; j < (matrix + 1) / 2; j++)
                    {
                        for (int i = j; i < k; i++)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = "0";
                        }
                        k--;
                    }
                    k = -1;
                    for (int j = matrix - 1; j >= ((matrix + 1) / 2) - 1; j--)
                    {
                        for (int i = j; i > k; i--)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = "0";
                        }
                        k++;
                    }
                    break;
                
                case 10:
                    k = 1;
                    for (int i = 0; i < matrix; i++)
                    {
                        for (int j = 0; j < k; j++)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = "0";
                        }
                        k++;
                    }
                    k = matrix;
                    for (int i = 0; i < matrix; i++)
                    {
                        for (int j = 0; j < k; j++)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = "0";
                        }
                        k--;
                    }
                    break;

                case 11:
                    k = -1;
                    for (int i = 0; i < matrix; i++)
                    {
                        for (int j = dataGridView1.RowCount - 1; j > k; j--)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = "0";
                        }
                        k++;
                    }
                    k = matrix -2;
                    for (int i = 0; i < matrix; i++)
                    {
                        for (int j = dataGridView1.RowCount - 1; j > k; j--)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = "0";
                        }
                        k--;
                    }
                    break;

                case 12:
                    k = 1;
                    for (int i = 0; i < matrix; i++)
                    {
                        for (int j = 0; j < k; j++)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = "0";
                        }
                        k++;
                    }
                    k = matrix -2;
                    for (int i = 0; i < matrix; i++)
                    {
                        for (int j = dataGridView1.RowCount - 1; j > k; j--)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = "0";
                        }
                        k--;
                    }
                    break;

                case 13:
                    k = -1;
                    for (int i = 0; i < matrix; i++)
                    {
                        for (int j = dataGridView1.RowCount - 1; j > k; j--)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = "0";
                        }
                        k++;
                    }
                    k = matrix;
                    for (int i = 0; i < matrix; i++)
                    {
                        for (int j = 0; j < k; j++)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = "0";
                        }
                        k--;
                    }
                    break;
            }
        }

        public void clearDataGridView()
        {
            int matrix = dataGridView1.ColumnCount;
            for (int i = 0; i < matrix; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = "";
                }
            }
        }

        public void prepareDataGridView()
        {
            int matrix = dataGridView1.ColumnCount;
            for (int i = 0; i < matrix; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = "";
                }
            }
            
            Random rand = new Random();
            
            for (int i = 0; i < matrix; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    a[i, j] = rand.Next(1, 99);
                }
            }

            for (int i = 0; i < matrix; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j];
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearDataGridView();
            comboBox1.Text = "Вариант";
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    dataGridView1.ColumnCount = 3;
                    dataGridView1.RowCount = 3;
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        dataGridView1.Columns[i].Width = 25;
                    }
                    dataGridView1.Size = new Size(80, 70);
                    break;
                case 1:
                    dataGridView1.ColumnCount = 5;
                    dataGridView1.RowCount = 5;
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        dataGridView1.Columns[i].Width = 25;
                    }
                    dataGridView1.Size = new Size(128, 113);
                    break;

                case 2:
                    dataGridView1.ColumnCount = 7;
                    dataGridView1.RowCount = 7;
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        dataGridView1.Columns[i].Width = 25;
                    }
                    dataGridView1.Size = new Size(178, 157);
                    break;

                case 3:
                    dataGridView1.ColumnCount = 9;
                    dataGridView1.RowCount = 9;
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        dataGridView1.Columns[i].Width = 25;
                    }
                    dataGridView1.Size = new Size(228, 203);

                    break;

                case 4:
                    dataGridView1.ColumnCount = 11;
                    dataGridView1.RowCount = 11;
                    for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    {
                        dataGridView1.Columns[i].Width = 25;
                    }
                    dataGridView1.Size = new Size(278, 246);
                    break;
            }
        }
    }
}

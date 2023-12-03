using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ChepurnykhSR.Sprint6.Task3.V17.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint6.Task3.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] mtrx = new int[5, 5]
        {
            { 22, 32, -16, 24, 27 },
            { 3, -20, 24, -20, 26 },
            { 21, 17, -8, -19, 17 },
            { 8, 22, 28, 27, 19 },
            { 11, 20, 12, 27, 29 }
        };

        private void buttonDone_CSR_Click(object sender, EventArgs e)
        {
            int[,] result = ds.Calculate(mtrx);

            int rows = result.GetLength(0);
            int columns = result.GetLength(1);

            dataGridViewOutPutMatrix_CSR.ColumnCount = columns;
            dataGridViewOutPutMatrix_CSR.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {

                dataGridViewOutPutMatrix_CSR.Columns[i].Width = 35;

            }

            for (int i = 0; i < rows; i++)
            {
                dataGridViewOutPutMatrix_CSR.Rows[i].Height = 35;
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutPutMatrix_CSR.Rows[i].Cells[j].Value = Convert.ToString(result[i, j]);
                }
            }

        }

        private void buttonHelp_CSR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ИСТНб-23-1 Чепурных Софья Романовна", "Сообщение");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;


            dataGridViewInPutMatrix_CSR.ColumnCount = columns;
            dataGridViewInPutMatrix_CSR.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPutMatrix_CSR.Columns[i].Width = 35;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    dataGridViewInPutMatrix_CSR.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using Tyuiu.ChepurnykhSR.Sprint6.Task7.V6.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint6.Task7.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonOpenFile_CSR_Click(object sender, EventArgs e)
        {
            openFileDialogTask_CSR.ShowDialog();
            openFilePath = openFileDialogTask_CSR.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPut_CSR.ColumnCount = columns;
            dataGridViewInPut_CSR.RowCount = rows;
            dataGridViewOutPut_CSR.RowCount = rows;
            dataGridViewOutPut_CSR.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_CSR.Columns[i].Width = 25;
                dataGridViewOutPut_CSR.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPut_CSR.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_CSR.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPut_CSR.ColumnCount = 50;
            dataGridViewOutPut_CSR.ColumnCount = 50;

            dataGridViewInPut_CSR.RowCount = 50;
            dataGridViewOutPut_CSR.RowCount = 50;
        }

        private void buttonDone_CSR_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_CSR.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_CSR.Enabled = true;
        }

        private void buttonSave_CSR_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_CSR.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_CSR.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_CSR.ShowDialog();

            string path = saveFileDialogMatrix_CSR.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_CSR.RowCount;
            int columns = dataGridViewOutPut_CSR.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_CSR.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_CSR.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_CSR_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_CSR_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonDone_CSR_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonSave_CSR_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonHelp_CSR_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void buttonOpenFile_CSR_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void buttonDone_CSR_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void buttonSave_CSR_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void buttonHelp_CSR_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}

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

using Tyuiu.ChepurnykhSR.Sprint6.Task5.V16.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint6.Task5.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\user\source\repos\Tyuiu.ChepurnykhSR.Sprint6\Tyuiu.ChepurnykhSR.Sprint6.Task5.V16\bin\Debug\InPutFileTask5V16.txt";
        private void buttonDone_CSR_Click(object sender, EventArgs e)
        {
            dataGridViewResult_CRS.ColumnCount = 2;
            dataGridViewResult_CRS.Columns[0].Width = 30;
            dataGridViewResult_CRS.Columns[1].Width = 50;
            this.chartResult_CSR.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_CSR.ChartAreas[0].AxisY.Title = "Ось Y";
            chartResult_CSR.Series[0].Points.Clear();
            double[] numMass = new double[ds.len];
            numMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridViewResult_CRS.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chartResult_CSR.Series[0].Points.AddXY(i, numMass[i]);
            }
        }

        private void buttonFile_CSR_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_CSR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнилf студентrf группы ИСТНб-23-1 Чепурных Софья Романовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }    
}

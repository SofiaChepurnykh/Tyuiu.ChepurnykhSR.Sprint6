using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ChepurnykhSR.Sprint6.Task2.V8.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint6.Task2.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_CSR_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_CSR.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_CSR.Text);



                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_CSR.Titles.Add("График функции");
                this.chartFunction_CSR.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_CSR.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_CSR.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_CSR_MouseEnter(object sender, EventArgs e)
        {
            //
        }

        private void buttonDone_CSR_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void buttonDone_CSR_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void buttonHelp_CSR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ИСТНб-23-1 Чепурных Софья Романовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void labelBoxStartStep_CSR_Click(object sender, EventArgs e)
        {

        }
    }
}

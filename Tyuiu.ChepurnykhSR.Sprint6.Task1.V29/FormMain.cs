using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ChepurnykhSR.Sprint6.Task1.V29.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint6.Task1.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_CSR_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startStep = Convert.ToInt32(textBoxVarA_CSR.Text);
                int stopStep = Convert.ToInt32(textBoxVarB_CSR.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_CSR.Text = "";
                textBoxResult_CSR.AppendText("+----------+------------+" + Environment.NewLine);
                textBoxResult_CSR.AppendText("|    X     |     f(x)   |" + Environment.NewLine);
                textBoxResult_CSR.AppendText("+----------+------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     | {1,7:f2}    |", startStep, valueArray[i]);
                    textBoxResult_CSR.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_CSR.AppendText("+----------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_CSR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ИСТНб-23-1 Чепурных Софья Романовна", "Сообщение");
        }
    }
}

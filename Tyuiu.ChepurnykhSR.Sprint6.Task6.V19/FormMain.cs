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

using Tyuiu.ChepurnykhSR.Sprint6.Task6.V19.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint6.Task6.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpen_CSR_Click(object sender, EventArgs e)
        {
            openFileDialogTask_CSR.ShowDialog();
            openFilePath = openFileDialogTask_CSR.FileName;
            textBoxInPut_CSR.Text = File.ReadAllText(openFilePath);
            groupBoxInPut_CSR.Text = groupBoxInPut_CSR.Text + "  " + openFileDialogTask_CSR.FileName;
            buttonDone_CSR.Enabled = true;
        }

        private void buttonDone_CSR_Click(object sender, EventArgs e)
        {
            textBoxOutPut_CSR.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_CSR_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}

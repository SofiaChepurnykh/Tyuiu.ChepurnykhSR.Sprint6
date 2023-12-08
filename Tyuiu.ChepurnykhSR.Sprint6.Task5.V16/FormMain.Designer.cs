
namespace Tyuiu.ChepurnykhSR.Sprint6.Task5.V16
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_CSR = new System.Windows.Forms.Panel();
            this.panelLeft_CSR = new System.Windows.Forms.Panel();
            this.panelRight_CSR = new System.Windows.Forms.Panel();
            this.splitterPanel_CSR = new System.Windows.Forms.Splitter();
            this.buttonHelp_CSR = new System.Windows.Forms.Button();
            this.buttonFile_CSR = new System.Windows.Forms.Button();
            this.buttonDone_CSR = new System.Windows.Forms.Button();
            this.groupBoxTask_CSR = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_CSR = new System.Windows.Forms.GroupBox();
            this.chartResult_CSR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxTask_CSR = new System.Windows.Forms.TextBox();
            this.dataGridViewResult_CRS = new System.Windows.Forms.DataGridView();
            this.panelTop_CSR.SuspendLayout();
            this.panelLeft_CSR.SuspendLayout();
            this.panelRight_CSR.SuspendLayout();
            this.groupBoxTask_CSR.SuspendLayout();
            this.groupBoxResult_CSR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_CSR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_CRS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_CSR
            // 
            this.panelTop_CSR.Controls.Add(this.groupBoxTask_CSR);
            this.panelTop_CSR.Controls.Add(this.buttonDone_CSR);
            this.panelTop_CSR.Controls.Add(this.buttonFile_CSR);
            this.panelTop_CSR.Controls.Add(this.buttonHelp_CSR);
            this.panelTop_CSR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_CSR.Location = new System.Drawing.Point(0, 0);
            this.panelTop_CSR.Name = "panelTop_CSR";
            this.panelTop_CSR.Size = new System.Drawing.Size(834, 74);
            this.panelTop_CSR.TabIndex = 0;
            // 
            // panelLeft_CSR
            // 
            this.panelLeft_CSR.Controls.Add(this.groupBoxResult_CSR);
            this.panelLeft_CSR.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_CSR.Location = new System.Drawing.Point(0, 74);
            this.panelLeft_CSR.Name = "panelLeft_CSR";
            this.panelLeft_CSR.Size = new System.Drawing.Size(200, 337);
            this.panelLeft_CSR.TabIndex = 1;
            // 
            // panelRight_CSR
            // 
            this.panelRight_CSR.Controls.Add(this.chartResult_CSR);
            this.panelRight_CSR.Controls.Add(this.splitterPanel_CSR);
            this.panelRight_CSR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_CSR.Location = new System.Drawing.Point(200, 74);
            this.panelRight_CSR.Name = "panelRight_CSR";
            this.panelRight_CSR.Size = new System.Drawing.Size(634, 337);
            this.panelRight_CSR.TabIndex = 2;
            // 
            // splitterPanel_CSR
            // 
            this.splitterPanel_CSR.Location = new System.Drawing.Point(0, 0);
            this.splitterPanel_CSR.Name = "splitterPanel_CSR";
            this.splitterPanel_CSR.Size = new System.Drawing.Size(3, 337);
            this.splitterPanel_CSR.TabIndex = 0;
            this.splitterPanel_CSR.TabStop = false;
            // 
            // buttonHelp_CSR
            // 
            this.buttonHelp_CSR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp_CSR.Location = new System.Drawing.Point(747, 22);
            this.buttonHelp_CSR.Name = "buttonHelp_CSR";
            this.buttonHelp_CSR.Size = new System.Drawing.Size(75, 46);
            this.buttonHelp_CSR.TabIndex = 0;
            this.buttonHelp_CSR.Text = "Справка";
            this.buttonHelp_CSR.UseVisualStyleBackColor = false;
            this.buttonHelp_CSR.Click += new System.EventHandler(this.buttonHelp_CSR_Click);
            // 
            // buttonFile_CSR
            // 
            this.buttonFile_CSR.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonFile_CSR.Location = new System.Drawing.Point(666, 22);
            this.buttonFile_CSR.Name = "buttonFile_CSR";
            this.buttonFile_CSR.Size = new System.Drawing.Size(75, 46);
            this.buttonFile_CSR.TabIndex = 1;
            this.buttonFile_CSR.Text = "Открыть файл";
            this.buttonFile_CSR.UseVisualStyleBackColor = false;
            this.buttonFile_CSR.Click += new System.EventHandler(this.buttonFile_CSR_Click);
            // 
            // buttonDone_CSR
            // 
            this.buttonDone_CSR.BackColor = System.Drawing.Color.Green;
            this.buttonDone_CSR.Location = new System.Drawing.Point(585, 22);
            this.buttonDone_CSR.Name = "buttonDone_CSR";
            this.buttonDone_CSR.Size = new System.Drawing.Size(75, 46);
            this.buttonDone_CSR.TabIndex = 2;
            this.buttonDone_CSR.Text = "Выполнить";
            this.buttonDone_CSR.UseVisualStyleBackColor = false;
            this.buttonDone_CSR.Click += new System.EventHandler(this.buttonDone_CSR_Click);
            // 
            // groupBoxTask_CSR
            // 
            this.groupBoxTask_CSR.Controls.Add(this.textBoxTask_CSR);
            this.groupBoxTask_CSR.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_CSR.Name = "groupBoxTask_CSR";
            this.groupBoxTask_CSR.Size = new System.Drawing.Size(567, 62);
            this.groupBoxTask_CSR.TabIndex = 3;
            this.groupBoxTask_CSR.TabStop = false;
            this.groupBoxTask_CSR.Text = "Условие:";
            // 
            // groupBoxResult_CSR
            // 
            this.groupBoxResult_CSR.Controls.Add(this.dataGridViewResult_CRS);
            this.groupBoxResult_CSR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_CSR.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_CSR.Name = "groupBoxResult_CSR";
            this.groupBoxResult_CSR.Size = new System.Drawing.Size(200, 337);
            this.groupBoxResult_CSR.TabIndex = 0;
            this.groupBoxResult_CSR.TabStop = false;
            this.groupBoxResult_CSR.Text = "Вывод данных:";
            // 
            // chartResult_CSR
            // 
            chartArea3.Name = "ChartArea1";
            this.chartResult_CSR.ChartAreas.Add(chartArea3);
            this.chartResult_CSR.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartResult_CSR.Legends.Add(legend3);
            this.chartResult_CSR.Location = new System.Drawing.Point(3, 0);
            this.chartResult_CSR.Name = "chartResult_CSR";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartResult_CSR.Series.Add(series3);
            this.chartResult_CSR.Size = new System.Drawing.Size(631, 337);
            this.chartResult_CSR.TabIndex = 1;
            this.chartResult_CSR.Text = "chart1";
            // 
            // textBoxTask_CSR
            // 
            this.textBoxTask_CSR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxTask_CSR.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_CSR.Multiline = true;
            this.textBoxTask_CSR.Name = "textBoxTask_CSR";
            this.textBoxTask_CSR.ReadOnly = true;
            this.textBoxTask_CSR.Size = new System.Drawing.Size(555, 37);
            this.textBoxTask_CSR.TabIndex = 0;
            this.textBoxTask_CSR.Text = "Прочитать данные из файла InPutFileTask5V16.txt. Вывести в dataGridView. Вывести " +
    "все положительные числа.Построить диаграмму по этим значениям.";
            // 
            // dataGridViewResult_CRS
            // 
            this.dataGridViewResult_CRS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_CRS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_CRS.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult_CRS.Name = "dataGridViewResult_CRS";
            this.dataGridViewResult_CRS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewResult_CRS.Size = new System.Drawing.Size(194, 318);
            this.dataGridViewResult_CRS.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 411);
            this.Controls.Add(this.panelRight_CSR);
            this.Controls.Add(this.panelLeft_CSR);
            this.Controls.Add(this.panelTop_CSR);
            this.MinimumSize = new System.Drawing.Size(850, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 16 | Чепурных С. Р.";
            this.panelTop_CSR.ResumeLayout(false);
            this.panelLeft_CSR.ResumeLayout(false);
            this.panelRight_CSR.ResumeLayout(false);
            this.groupBoxTask_CSR.ResumeLayout(false);
            this.groupBoxTask_CSR.PerformLayout();
            this.groupBoxResult_CSR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_CSR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_CRS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_CSR;
        private System.Windows.Forms.Panel panelLeft_CSR;
        private System.Windows.Forms.Panel panelRight_CSR;
        private System.Windows.Forms.Splitter splitterPanel_CSR;
        private System.Windows.Forms.GroupBox groupBoxTask_CSR;
        private System.Windows.Forms.Button buttonDone_CSR;
        private System.Windows.Forms.Button buttonFile_CSR;
        private System.Windows.Forms.Button buttonHelp_CSR;
        private System.Windows.Forms.GroupBox groupBoxResult_CSR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_CSR;
        private System.Windows.Forms.TextBox textBoxTask_CSR;
        private System.Windows.Forms.DataGridView dataGridViewResult_CRS;
    }
}


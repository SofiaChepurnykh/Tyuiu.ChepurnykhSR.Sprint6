
namespace Tyuiu.ChepurnykhSR.Sprint6.Task2.V8
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonDone_CSR = new System.Windows.Forms.Button();
            this.buttonHelp_CSR = new System.Windows.Forms.Button();
            this.groupInput_CSR = new System.Windows.Forms.GroupBox();
            this.labelBoxStopStep_CSR = new System.Windows.Forms.Label();
            this.textBoxStopStep_CSR = new System.Windows.Forms.TextBox();
            this.labelBoxStartStep_CSR = new System.Windows.Forms.Label();
            this.textBoxStartStep_CSR = new System.Windows.Forms.TextBox();
            this.groupBoxResult_CSR = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction_CSR = new System.Windows.Forms.DataGridView();
            this.ColumnXY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTask_CSR = new System.Windows.Forms.GroupBox();
            this.chartFunction_CSR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupInput_CSR.SuspendLayout();
            this.groupBoxResult_CSR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_CSR)).BeginInit();
            this.groupBoxTask_CSR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_CSR)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_CSR
            // 
            this.buttonDone_CSR.Location = new System.Drawing.Point(311, 298);
            this.buttonDone_CSR.Name = "buttonDone_CSR";
            this.buttonDone_CSR.Size = new System.Drawing.Size(87, 28);
            this.buttonDone_CSR.TabIndex = 0;
            this.buttonDone_CSR.Text = "Выполнить";
            this.buttonDone_CSR.UseVisualStyleBackColor = true;
            this.buttonDone_CSR.Click += new System.EventHandler(this.buttonDone_CSR_Click);
            this.buttonDone_CSR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_CSR_MouseDown);
            this.buttonDone_CSR.MouseEnter += new System.EventHandler(this.buttonDone_CSR_MouseEnter);
            this.buttonDone_CSR.MouseLeave += new System.EventHandler(this.buttonDone_CSR_MouseLeave);
            // 
            // buttonHelp_CSR
            // 
            this.buttonHelp_CSR.Location = new System.Drawing.Point(238, 298);
            this.buttonHelp_CSR.Name = "buttonHelp_CSR";
            this.buttonHelp_CSR.Size = new System.Drawing.Size(67, 28);
            this.buttonHelp_CSR.TabIndex = 1;
            this.buttonHelp_CSR.Text = "Справка";
            this.buttonHelp_CSR.UseVisualStyleBackColor = true;
            this.buttonHelp_CSR.Click += new System.EventHandler(this.buttonHelp_CSR_Click);
            // 
            // groupInput_CSR
            // 
            this.groupInput_CSR.Controls.Add(this.labelBoxStopStep_CSR);
            this.groupInput_CSR.Controls.Add(this.textBoxStopStep_CSR);
            this.groupInput_CSR.Controls.Add(this.labelBoxStartStep_CSR);
            this.groupInput_CSR.Controls.Add(this.textBoxStartStep_CSR);
            this.groupInput_CSR.Location = new System.Drawing.Point(12, 266);
            this.groupInput_CSR.Name = "groupInput_CSR";
            this.groupInput_CSR.Size = new System.Drawing.Size(220, 60);
            this.groupInput_CSR.TabIndex = 2;
            this.groupInput_CSR.TabStop = false;
            this.groupInput_CSR.Text = "Ввод данных";
            // 
            // labelBoxStopStep_CSR
            // 
            this.labelBoxStopStep_CSR.AutoSize = true;
            this.labelBoxStopStep_CSR.Location = new System.Drawing.Point(109, 16);
            this.labelBoxStopStep_CSR.Name = "labelBoxStopStep_CSR";
            this.labelBoxStopStep_CSR.Size = new System.Drawing.Size(69, 13);
            this.labelBoxStopStep_CSR.TabIndex = 3;
            this.labelBoxStopStep_CSR.Text = "Конец шага:";
            // 
            // textBoxStopStep_CSR
            // 
            this.textBoxStopStep_CSR.Location = new System.Drawing.Point(112, 32);
            this.textBoxStopStep_CSR.Name = "textBoxStopStep_CSR";
            this.textBoxStopStep_CSR.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep_CSR.TabIndex = 2;
            // 
            // labelBoxStartStep_CSR
            // 
            this.labelBoxStartStep_CSR.AutoSize = true;
            this.labelBoxStartStep_CSR.Location = new System.Drawing.Point(6, 16);
            this.labelBoxStartStep_CSR.Name = "labelBoxStartStep_CSR";
            this.labelBoxStartStep_CSR.Size = new System.Drawing.Size(67, 13);
            this.labelBoxStartStep_CSR.TabIndex = 1;
            this.labelBoxStartStep_CSR.Text = "Старт шага:";
            // 
            // textBoxStartStep_CSR
            // 
            this.textBoxStartStep_CSR.Location = new System.Drawing.Point(6, 32);
            this.textBoxStartStep_CSR.Name = "textBoxStartStep_CSR";
            this.textBoxStartStep_CSR.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep_CSR.TabIndex = 0;
            // 
            // groupBoxResult_CSR
            // 
            this.groupBoxResult_CSR.Controls.Add(this.dataGridViewFunction_CSR);
            this.groupBoxResult_CSR.Location = new System.Drawing.Point(404, 12);
            this.groupBoxResult_CSR.Name = "groupBoxResult_CSR";
            this.groupBoxResult_CSR.Size = new System.Drawing.Size(441, 314);
            this.groupBoxResult_CSR.TabIndex = 3;
            this.groupBoxResult_CSR.TabStop = false;
            this.groupBoxResult_CSR.Text = "Вывод данных";
            // 
            // dataGridViewFunction_CSR
            // 
            this.dataGridViewFunction_CSR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_CSR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnXY,
            this.ColumnX});
            this.dataGridViewFunction_CSR.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewFunction_CSR.Name = "dataGridViewFunction_CSR";
            this.dataGridViewFunction_CSR.RowHeadersVisible = false;
            this.dataGridViewFunction_CSR.Size = new System.Drawing.Size(117, 289);
            this.dataGridViewFunction_CSR.TabIndex = 0;
            // 
            // ColumnXY
            // 
            this.ColumnXY.HeaderText = "F(x)";
            this.ColumnXY.Name = "ColumnXY";
            this.ColumnXY.Width = 50;
            // 
            // ColumnX
            // 
            this.ColumnX.HeaderText = "x";
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.Width = 50;
            // 
            // groupBoxTask_CSR
            // 
            this.groupBoxTask_CSR.Controls.Add(this.textBox1);
            this.groupBoxTask_CSR.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_CSR.Name = "groupBoxTask_CSR";
            this.groupBoxTask_CSR.Size = new System.Drawing.Size(386, 248);
            this.groupBoxTask_CSR.TabIndex = 4;
            this.groupBoxTask_CSR.TabStop = false;
            this.groupBoxTask_CSR.Text = "Условие";
            // 
            // chartFunction_CSR
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_CSR.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_CSR.Legends.Add(legend2);
            this.chartFunction_CSR.Location = new System.Drawing.Point(535, 31);
            this.chartFunction_CSR.Name = "chartFunction_CSR";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_CSR.Series.Add(series2);
            this.chartFunction_CSR.Size = new System.Drawing.Size(300, 287);
            this.chartFunction_CSR.TabIndex = 1;
            this.chartFunction_CSR.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(7, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(373, 223);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в DataGridView " +
    "и построить график функции.\r\n";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 338);
            this.Controls.Add(this.chartFunction_CSR);
            this.Controls.Add(this.groupBoxTask_CSR);
            this.Controls.Add(this.groupBoxResult_CSR);
            this.Controls.Add(this.groupInput_CSR);
            this.Controls.Add(this.buttonHelp_CSR);
            this.Controls.Add(this.buttonDone_CSR);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Спринт 6 | Таск 2 | Вариант 8 | Чепурных С. Р.";
            this.groupInput_CSR.ResumeLayout(false);
            this.groupInput_CSR.PerformLayout();
            this.groupBoxResult_CSR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_CSR)).EndInit();
            this.groupBoxTask_CSR.ResumeLayout(false);
            this.groupBoxTask_CSR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_CSR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_CSR;
        private System.Windows.Forms.Button buttonHelp_CSR;
        private System.Windows.Forms.GroupBox groupInput_CSR;
        private System.Windows.Forms.TextBox textBoxStartStep_CSR;
        private System.Windows.Forms.Label labelBoxStartStep_CSR;
        private System.Windows.Forms.Label labelBoxStopStep_CSR;
        private System.Windows.Forms.TextBox textBoxStopStep_CSR;
        private System.Windows.Forms.GroupBox groupBoxResult_CSR;
        private System.Windows.Forms.GroupBox groupBoxTask_CSR;
        private System.Windows.Forms.DataGridView dataGridViewFunction_CSR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnXY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_CSR;
        private System.Windows.Forms.TextBox textBox1;
    }
}


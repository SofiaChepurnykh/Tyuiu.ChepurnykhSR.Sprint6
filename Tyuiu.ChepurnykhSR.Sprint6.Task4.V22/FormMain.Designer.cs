
namespace Tyuiu.ChepurnykhSR.Sprint6.Task4.V22
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxTask_CSR = new System.Windows.Forms.GroupBox();
            this.textBoxTask_CSR = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData_CSR = new System.Windows.Forms.GroupBox();
            this.labelVarB = new System.Windows.Forms.Label();
            this.labelVarA_CSR = new System.Windows.Forms.Label();
            this.textBoxStopStep_CSR = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_CSR = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_CSR = new System.Windows.Forms.GroupBox();
            this.textBoxResult_CSR = new System.Windows.Forms.TextBox();
            this.panelLeft_CSR = new System.Windows.Forms.Panel();
            this.buttonDone_CSR = new System.Windows.Forms.Button();
            this.buttonSave_CSR = new System.Windows.Forms.Button();
            this.buttonHelp_CSR = new System.Windows.Forms.Button();
            this.chartFunction_CSR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop_CSR = new System.Windows.Forms.Panel();
            this.panelRight_CSR = new System.Windows.Forms.Panel();
            this.splitterPanel_CSR = new System.Windows.Forms.Splitter();
            this.groupBoxTask_CSR.SuspendLayout();
            this.groupBoxInPutData_CSR.SuspendLayout();
            this.groupBoxOutPutData_CSR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_CSR)).BeginInit();
            this.panelRight_CSR.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_CSR
            // 
            this.groupBoxTask_CSR.Controls.Add(this.textBoxTask_CSR);
            this.groupBoxTask_CSR.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_CSR.Name = "groupBoxTask_CSR";
            this.groupBoxTask_CSR.Size = new System.Drawing.Size(366, 77);
            this.groupBoxTask_CSR.TabIndex = 0;
            this.groupBoxTask_CSR.TabStop = false;
            this.groupBoxTask_CSR.Text = "Условие";
            // 
            // textBoxTask_CSR
            // 
            this.textBoxTask_CSR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxTask_CSR.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_CSR.Multiline = true;
            this.textBoxTask_CSR.Name = "textBoxTask_CSR";
            this.textBoxTask_CSR.ReadOnly = true;
            this.textBoxTask_CSR.Size = new System.Drawing.Size(354, 48);
            this.textBoxTask_CSR.TabIndex = 0;
            this.textBoxTask_CSR.Text = "Протабулировать f(x) на заданном диапазоне  [-5; 5] с шагом 1.\r\nРезультат вывести" +
    " в textBox, построить график функции и сохранить в файл OutPutFileTask4V22.txt п" +
    "о нажатию кнопки.";
            // 
            // groupBoxInPutData_CSR
            // 
            this.groupBoxInPutData_CSR.Controls.Add(this.labelVarB);
            this.groupBoxInPutData_CSR.Controls.Add(this.labelVarA_CSR);
            this.groupBoxInPutData_CSR.Controls.Add(this.textBoxStopStep_CSR);
            this.groupBoxInPutData_CSR.Controls.Add(this.textBoxStartStep_CSR);
            this.groupBoxInPutData_CSR.Location = new System.Drawing.Point(384, 12);
            this.groupBoxInPutData_CSR.Name = "groupBoxInPutData_CSR";
            this.groupBoxInPutData_CSR.Size = new System.Drawing.Size(222, 77);
            this.groupBoxInPutData_CSR.TabIndex = 1;
            this.groupBoxInPutData_CSR.TabStop = false;
            this.groupBoxInPutData_CSR.Text = "Ввод данных:";
            // 
            // labelVarB
            // 
            this.labelVarB.AutoSize = true;
            this.labelVarB.Location = new System.Drawing.Point(109, 16);
            this.labelVarB.Name = "labelVarB";
            this.labelVarB.Size = new System.Drawing.Size(69, 13);
            this.labelVarB.TabIndex = 3;
            this.labelVarB.Text = "Конец шага:";
            // 
            // labelVarA_CSR
            // 
            this.labelVarA_CSR.AutoSize = true;
            this.labelVarA_CSR.Location = new System.Drawing.Point(6, 16);
            this.labelVarA_CSR.Name = "labelVarA_CSR";
            this.labelVarA_CSR.Size = new System.Drawing.Size(67, 13);
            this.labelVarA_CSR.TabIndex = 2;
            this.labelVarA_CSR.Text = "Старт шага:";
            // 
            // textBoxStopStep_CSR
            // 
            this.textBoxStopStep_CSR.Location = new System.Drawing.Point(112, 32);
            this.textBoxStopStep_CSR.Name = "textBoxStopStep_CSR";
            this.textBoxStopStep_CSR.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep_CSR.TabIndex = 1;
            // 
            // textBoxStartStep_CSR
            // 
            this.textBoxStartStep_CSR.Location = new System.Drawing.Point(6, 32);
            this.textBoxStartStep_CSR.Name = "textBoxStartStep_CSR";
            this.textBoxStartStep_CSR.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep_CSR.TabIndex = 0;
            // 
            // groupBoxOutPutData_CSR
            // 
            this.groupBoxOutPutData_CSR.Controls.Add(this.textBoxResult_CSR);
            this.groupBoxOutPutData_CSR.Controls.Add(this.panelLeft_CSR);
            this.groupBoxOutPutData_CSR.Location = new System.Drawing.Point(12, 95);
            this.groupBoxOutPutData_CSR.Name = "groupBoxOutPutData_CSR";
            this.groupBoxOutPutData_CSR.Size = new System.Drawing.Size(200, 343);
            this.groupBoxOutPutData_CSR.TabIndex = 2;
            this.groupBoxOutPutData_CSR.TabStop = false;
            this.groupBoxOutPutData_CSR.Text = "Вывод:";
            // 
            // textBoxResult_CSR
            // 
            this.textBoxResult_CSR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxResult_CSR.Location = new System.Drawing.Point(6, 19);
            this.textBoxResult_CSR.Multiline = true;
            this.textBoxResult_CSR.Name = "textBoxResult_CSR";
            this.textBoxResult_CSR.ReadOnly = true;
            this.textBoxResult_CSR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_CSR.Size = new System.Drawing.Size(188, 318);
            this.textBoxResult_CSR.TabIndex = 0;
            // 
            // panelLeft_CSR
            // 
            this.panelLeft_CSR.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_CSR.Location = new System.Drawing.Point(3, 16);
            this.panelLeft_CSR.Name = "panelLeft_CSR";
            this.panelLeft_CSR.Size = new System.Drawing.Size(197, 324);
            this.panelLeft_CSR.TabIndex = 1;
            // 
            // buttonDone_CSR
            // 
            this.buttonDone_CSR.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonDone_CSR.Location = new System.Drawing.Point(612, 31);
            this.buttonDone_CSR.Name = "buttonDone_CSR";
            this.buttonDone_CSR.Size = new System.Drawing.Size(75, 42);
            this.buttonDone_CSR.TabIndex = 0;
            this.buttonDone_CSR.Text = "Выполнить";
            this.buttonDone_CSR.UseVisualStyleBackColor = false;
            this.buttonDone_CSR.Click += new System.EventHandler(this.buttonDone_CSR_Click);
            this.buttonDone_CSR.MouseEnter += new System.EventHandler(this.buttonDone_CSR_MouseEnter);
            this.buttonDone_CSR.MouseLeave += new System.EventHandler(this.buttonDone_CSR_MouseLeave);
            // 
            // buttonSave_CSR
            // 
            this.buttonSave_CSR.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave_CSR.Location = new System.Drawing.Point(693, 31);
            this.buttonSave_CSR.Name = "buttonSave_CSR";
            this.buttonSave_CSR.Size = new System.Drawing.Size(75, 42);
            this.buttonSave_CSR.TabIndex = 1;
            this.buttonSave_CSR.Text = "Сохранить";
            this.buttonSave_CSR.UseVisualStyleBackColor = false;
            this.buttonSave_CSR.Click += new System.EventHandler(this.buttonSave_CSR_Click);
            this.buttonSave_CSR.MouseEnter += new System.EventHandler(this.buttonSave_CSR_MouseEnter);
            this.buttonSave_CSR.MouseLeave += new System.EventHandler(this.buttonSave_CSR_MouseLeave);
            // 
            // buttonHelp_CSR
            // 
            this.buttonHelp_CSR.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_CSR.Location = new System.Drawing.Point(774, 31);
            this.buttonHelp_CSR.Name = "buttonHelp_CSR";
            this.buttonHelp_CSR.Size = new System.Drawing.Size(75, 42);
            this.buttonHelp_CSR.TabIndex = 2;
            this.buttonHelp_CSR.Text = "Справка";
            this.buttonHelp_CSR.UseVisualStyleBackColor = false;
            this.buttonHelp_CSR.Click += new System.EventHandler(this.buttonHelp_CSR_Click);
            this.buttonHelp_CSR.MouseEnter += new System.EventHandler(this.buttonHelp_CSR_MouseEnter);
            this.buttonHelp_CSR.MouseLeave += new System.EventHandler(this.buttonHelp_CSR_MouseLeave);
            // 
            // chartFunction_CSR
            // 
            chartArea6.Name = "ChartArea1";
            this.chartFunction_CSR.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartFunction_CSR.Legends.Add(legend6);
            this.chartFunction_CSR.Location = new System.Drawing.Point(3, 95);
            this.chartFunction_CSR.Name = "chartFunction_CSR";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartFunction_CSR.Series.Add(series6);
            this.chartFunction_CSR.Size = new System.Drawing.Size(570, 343);
            this.chartFunction_CSR.TabIndex = 3;
            this.chartFunction_CSR.Text = "chartFunction_CSR";
            title6.Name = "Title1";
            title6.Text = "График функции f(x)";
            this.chartFunction_CSR.Titles.Add(title6);
            // 
            // panelTop_CSR
            // 
            this.panelTop_CSR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_CSR.Location = new System.Drawing.Point(0, 0);
            this.panelTop_CSR.Name = "panelTop_CSR";
            this.panelTop_CSR.Size = new System.Drawing.Size(218, 89);
            this.panelTop_CSR.TabIndex = 4;
            // 
            // panelRight_CSR
            // 
            this.panelRight_CSR.Controls.Add(this.chartFunction_CSR);
            this.panelRight_CSR.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight_CSR.Location = new System.Drawing.Point(218, 0);
            this.panelRight_CSR.Name = "panelRight_CSR";
            this.panelRight_CSR.Size = new System.Drawing.Size(643, 450);
            this.panelRight_CSR.TabIndex = 5;
            // 
            // splitterPanel_CSR
            // 
            this.splitterPanel_CSR.Location = new System.Drawing.Point(0, 89);
            this.splitterPanel_CSR.Name = "splitterPanel_CSR";
            this.splitterPanel_CSR.Size = new System.Drawing.Size(3, 361);
            this.splitterPanel_CSR.TabIndex = 6;
            this.splitterPanel_CSR.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.splitterPanel_CSR);
            this.Controls.Add(this.buttonHelp_CSR);
            this.Controls.Add(this.groupBoxOutPutData_CSR);
            this.Controls.Add(this.buttonSave_CSR);
            this.Controls.Add(this.groupBoxInPutData_CSR);
            this.Controls.Add(this.buttonDone_CSR);
            this.Controls.Add(this.groupBoxTask_CSR);
            this.Controls.Add(this.panelTop_CSR);
            this.Controls.Add(this.panelRight_CSR);
            this.MinimumSize = new System.Drawing.Size(877, 489);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 22 | Чепурных С. Р.";
            this.groupBoxTask_CSR.ResumeLayout(false);
            this.groupBoxTask_CSR.PerformLayout();
            this.groupBoxInPutData_CSR.ResumeLayout(false);
            this.groupBoxInPutData_CSR.PerformLayout();
            this.groupBoxOutPutData_CSR.ResumeLayout(false);
            this.groupBoxOutPutData_CSR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_CSR)).EndInit();
            this.panelRight_CSR.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_CSR;
        private System.Windows.Forms.TextBox textBoxTask_CSR;
        private System.Windows.Forms.GroupBox groupBoxInPutData_CSR;
        private System.Windows.Forms.TextBox textBoxStopStep_CSR;
        private System.Windows.Forms.TextBox textBoxStartStep_CSR;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_CSR;
        private System.Windows.Forms.TextBox textBoxResult_CSR;
        private System.Windows.Forms.Button buttonDone_CSR;
        private System.Windows.Forms.Button buttonSave_CSR;
        private System.Windows.Forms.Button buttonHelp_CSR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_CSR;
        private System.Windows.Forms.Label labelVarB;
        private System.Windows.Forms.Label labelVarA_CSR;
        private System.Windows.Forms.Panel panelTop_CSR;
        private System.Windows.Forms.Panel panelLeft_CSR;
        private System.Windows.Forms.Panel panelRight_CSR;
        private System.Windows.Forms.Splitter splitterPanel_CSR;
    }
}



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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonDone_CSR = new System.Windows.Forms.Button();
            this.buttonHelp_CSR = new System.Windows.Forms.Button();
            this.groupInput_CSR = new System.Windows.Forms.GroupBox();
            this.labelBoxStopStep_CSR = new System.Windows.Forms.Label();
            this.textBoxStopStep_CSR = new System.Windows.Forms.TextBox();
            this.labelBoxStartStep_CSR = new System.Windows.Forms.Label();
            this.textBoxStartStep_CSR = new System.Windows.Forms.TextBox();
            this.groupBoxResult_CSR = new System.Windows.Forms.GroupBox();
            this.groupBoxTask_CSR = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chartFunction_CSR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupInput_CSR.SuspendLayout();
            this.groupBoxResult_CSR.SuspendLayout();
            this.groupBoxTask_CSR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_CSR)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDone_CSR
            // 
            this.buttonDone_CSR.Location = new System.Drawing.Point(468, 112);
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
            this.buttonHelp_CSR.Location = new System.Drawing.Point(185, 123);
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
            this.groupInput_CSR.Location = new System.Drawing.Point(468, 6);
            this.groupInput_CSR.Name = "groupInput_CSR";
            this.groupInput_CSR.Size = new System.Drawing.Size(113, 100);
            this.groupInput_CSR.TabIndex = 2;
            this.groupInput_CSR.TabStop = false;
            this.groupInput_CSR.Text = "Ввод данных";
            // 
            // labelBoxStopStep_CSR
            // 
            this.labelBoxStopStep_CSR.AutoSize = true;
            this.labelBoxStopStep_CSR.Location = new System.Drawing.Point(6, 55);
            this.labelBoxStopStep_CSR.Name = "labelBoxStopStep_CSR";
            this.labelBoxStopStep_CSR.Size = new System.Drawing.Size(85, 13);
            this.labelBoxStopStep_CSR.TabIndex = 3;
            this.labelBoxStopStep_CSR.Text = "Че то конечное";
            // 
            // textBoxStopStep_CSR
            // 
            this.textBoxStopStep_CSR.Location = new System.Drawing.Point(6, 71);
            this.textBoxStopStep_CSR.Name = "textBoxStopStep_CSR";
            this.textBoxStopStep_CSR.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep_CSR.TabIndex = 2;
            // 
            // labelBoxStartStep_CSR
            // 
            this.labelBoxStartStep_CSR.AutoSize = true;
            this.labelBoxStartStep_CSR.Location = new System.Drawing.Point(6, 16);
            this.labelBoxStartStep_CSR.Name = "labelBoxStartStep_CSR";
            this.labelBoxStartStep_CSR.Size = new System.Drawing.Size(91, 13);
            this.labelBoxStartStep_CSR.TabIndex = 1;
            this.labelBoxStartStep_CSR.Text = "Че то начальное";
            this.labelBoxStartStep_CSR.Click += new System.EventHandler(this.labelBoxStartStep_CSR_Click);
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
            this.groupBoxResult_CSR.Controls.Add(this.chartFunction_CSR);
            this.groupBoxResult_CSR.Location = new System.Drawing.Point(6, 6);
            this.groupBoxResult_CSR.Name = "groupBoxResult_CSR";
            this.groupBoxResult_CSR.Size = new System.Drawing.Size(456, 420);
            this.groupBoxResult_CSR.TabIndex = 3;
            this.groupBoxResult_CSR.TabStop = false;
            this.groupBoxResult_CSR.Text = "Вывод данных";
            // 
            // groupBoxTask_CSR
            // 
            this.groupBoxTask_CSR.Controls.Add(this.textBox1);
            this.groupBoxTask_CSR.Controls.Add(this.buttonHelp_CSR);
            this.groupBoxTask_CSR.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_CSR.Name = "groupBoxTask_CSR";
            this.groupBoxTask_CSR.Size = new System.Drawing.Size(300, 248);
            this.groupBoxTask_CSR.TabIndex = 4;
            this.groupBoxTask_CSR.TabStop = false;
            this.groupBoxTask_CSR.Text = "Инструкция";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(7, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(286, 223);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // chartFunction_CSR
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_CSR.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_CSR.Legends.Add(legend1);
            this.chartFunction_CSR.Location = new System.Drawing.Point(6, 16);
            this.chartFunction_CSR.Name = "chartFunction_CSR";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_CSR.Series.Add(series1);
            this.chartFunction_CSR.Size = new System.Drawing.Size(444, 398);
            this.chartFunction_CSR.TabIndex = 1;
            this.chartFunction_CSR.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(318, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(595, 458);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonDone_CSR);
            this.tabPage1.Controls.Add(this.groupBoxResult_CSR);
            this.tabPage1.Controls.Add(this.groupInput_CSR);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(587, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Изотермический";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(587, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Изобарный";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(587, 367);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Изохорный";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(587, 367);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Адиабатный";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 482);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBoxTask_CSR);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выполнили: студентки группы ИСТНб-23-1 Чепурных Софья и Шаукерова Аделия";
            this.groupInput_CSR.ResumeLayout(false);
            this.groupInput_CSR.PerformLayout();
            this.groupBoxResult_CSR.ResumeLayout(false);
            this.groupBoxTask_CSR.ResumeLayout(false);
            this.groupBoxTask_CSR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_CSR)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_CSR;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}


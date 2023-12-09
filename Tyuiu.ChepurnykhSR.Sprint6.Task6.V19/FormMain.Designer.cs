
namespace Tyuiu.ChepurnykhSR.Sprint6.Task6.V19
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop_CSR = new System.Windows.Forms.Panel();
            this.buttonHelp_CSR = new System.Windows.Forms.Button();
            this.buttonDone_CSR = new System.Windows.Forms.Button();
            this.groupBoxTask_CSR = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonOpen_CSR = new System.Windows.Forms.Button();
            this.panelLeft_CSR = new System.Windows.Forms.Panel();
            this.groupBoxInPut_CSR = new System.Windows.Forms.GroupBox();
            this.textBoxInPut_CSR = new System.Windows.Forms.TextBox();
            this.panelRight_CSR = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_CSR = new System.Windows.Forms.GroupBox();
            this.textBoxOutPut_CSR = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_CSR = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_CSR = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop_CSR.SuspendLayout();
            this.groupBoxTask_CSR.SuspendLayout();
            this.panelLeft_CSR.SuspendLayout();
            this.groupBoxInPut_CSR.SuspendLayout();
            this.panelRight_CSR.SuspendLayout();
            this.groupBoxOutPut_CSR.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_CSR
            // 
            this.panelTop_CSR.BackColor = System.Drawing.SystemColors.Control;
            this.panelTop_CSR.Controls.Add(this.buttonHelp_CSR);
            this.panelTop_CSR.Controls.Add(this.buttonDone_CSR);
            this.panelTop_CSR.Controls.Add(this.groupBoxTask_CSR);
            this.panelTop_CSR.Controls.Add(this.buttonOpen_CSR);
            this.panelTop_CSR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_CSR.Location = new System.Drawing.Point(0, 0);
            this.panelTop_CSR.Name = "panelTop_CSR";
            this.panelTop_CSR.Size = new System.Drawing.Size(884, 146);
            this.panelTop_CSR.TabIndex = 0;
            // 
            // buttonHelp_CSR
            // 
            this.buttonHelp_CSR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_CSR.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_CSR.Image")));
            this.buttonHelp_CSR.Location = new System.Drawing.Point(797, 13);
            this.buttonHelp_CSR.Name = "buttonHelp_CSR";
            this.buttonHelp_CSR.Size = new System.Drawing.Size(75, 57);
            this.buttonHelp_CSR.TabIndex = 3;
            this.toolTip_CSR.SetToolTip(this.buttonHelp_CSR, "Сведения о программе");
            this.buttonHelp_CSR.UseVisualStyleBackColor = true;
            this.buttonHelp_CSR.Click += new System.EventHandler(this.buttonHelp_CSR_Click);
            // 
            // buttonDone_CSR
            // 
            this.buttonDone_CSR.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_CSR.Image")));
            this.buttonDone_CSR.Location = new System.Drawing.Point(93, 12);
            this.buttonDone_CSR.Name = "buttonDone_CSR";
            this.buttonDone_CSR.Size = new System.Drawing.Size(75, 58);
            this.buttonDone_CSR.TabIndex = 2;
            this.toolTip_CSR.SetToolTip(this.buttonDone_CSR, "Производит поиск в файле символов \"l\" и выводит строки в результирующую строку ");
            this.buttonDone_CSR.UseVisualStyleBackColor = true;
            this.buttonDone_CSR.Click += new System.EventHandler(this.buttonDone_CSR_Click);
            // 
            // groupBoxTask_CSR
            // 
            this.groupBoxTask_CSR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTask_CSR.Controls.Add(this.textBox1);
            this.groupBoxTask_CSR.Location = new System.Drawing.Point(12, 76);
            this.groupBoxTask_CSR.Name = "groupBoxTask_CSR";
            this.groupBoxTask_CSR.Size = new System.Drawing.Size(860, 70);
            this.groupBoxTask_CSR.TabIndex = 1;
            this.groupBoxTask_CSR.TabStop = false;
            this.groupBoxTask_CSR.Text = "Условие:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(7, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(847, 44);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // buttonOpen_CSR
            // 
            this.buttonOpen_CSR.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen_CSR.Image")));
            this.buttonOpen_CSR.Location = new System.Drawing.Point(12, 12);
            this.buttonOpen_CSR.Name = "buttonOpen_CSR";
            this.buttonOpen_CSR.Size = new System.Drawing.Size(75, 58);
            this.buttonOpen_CSR.TabIndex = 0;
            this.toolTip_CSR.SetToolTip(this.buttonOpen_CSR, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpen_CSR.UseVisualStyleBackColor = true;
            this.buttonOpen_CSR.Click += new System.EventHandler(this.buttonOpen_CSR_Click);
            // 
            // panelLeft_CSR
            // 
            this.panelLeft_CSR.Controls.Add(this.groupBoxInPut_CSR);
            this.panelLeft_CSR.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_CSR.Location = new System.Drawing.Point(0, 146);
            this.panelLeft_CSR.Name = "panelLeft_CSR";
            this.panelLeft_CSR.Size = new System.Drawing.Size(436, 365);
            this.panelLeft_CSR.TabIndex = 1;
            // 
            // groupBoxInPut_CSR
            // 
            this.groupBoxInPut_CSR.Controls.Add(this.textBoxInPut_CSR);
            this.groupBoxInPut_CSR.Location = new System.Drawing.Point(12, 6);
            this.groupBoxInPut_CSR.Name = "groupBoxInPut_CSR";
            this.groupBoxInPut_CSR.Size = new System.Drawing.Size(418, 347);
            this.groupBoxInPut_CSR.TabIndex = 0;
            this.groupBoxInPut_CSR.TabStop = false;
            this.groupBoxInPut_CSR.Text = "Ввод:";
            // 
            // textBoxInPut_CSR
            // 
            this.textBoxInPut_CSR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxInPut_CSR.Location = new System.Drawing.Point(6, 19);
            this.textBoxInPut_CSR.Multiline = true;
            this.textBoxInPut_CSR.Name = "textBoxInPut_CSR";
            this.textBoxInPut_CSR.ReadOnly = true;
            this.textBoxInPut_CSR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInPut_CSR.Size = new System.Drawing.Size(405, 322);
            this.textBoxInPut_CSR.TabIndex = 0;
            // 
            // panelRight_CSR
            // 
            this.panelRight_CSR.BackColor = System.Drawing.SystemColors.Control;
            this.panelRight_CSR.Controls.Add(this.groupBoxOutPut_CSR);
            this.panelRight_CSR.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight_CSR.Location = new System.Drawing.Point(436, 146);
            this.panelRight_CSR.Name = "panelRight_CSR";
            this.panelRight_CSR.Size = new System.Drawing.Size(448, 365);
            this.panelRight_CSR.TabIndex = 2;
            // 
            // groupBoxOutPut_CSR
            // 
            this.groupBoxOutPut_CSR.Controls.Add(this.textBoxOutPut_CSR);
            this.groupBoxOutPut_CSR.Location = new System.Drawing.Point(9, 6);
            this.groupBoxOutPut_CSR.Name = "groupBoxOutPut_CSR";
            this.groupBoxOutPut_CSR.Size = new System.Drawing.Size(427, 347);
            this.groupBoxOutPut_CSR.TabIndex = 0;
            this.groupBoxOutPut_CSR.TabStop = false;
            this.groupBoxOutPut_CSR.Text = "Вывод:";
            // 
            // textBoxOutPut_CSR
            // 
            this.textBoxOutPut_CSR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxOutPut_CSR.Location = new System.Drawing.Point(6, 19);
            this.textBoxOutPut_CSR.Multiline = true;
            this.textBoxOutPut_CSR.Name = "textBoxOutPut_CSR";
            this.textBoxOutPut_CSR.ReadOnly = true;
            this.textBoxOutPut_CSR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPut_CSR.Size = new System.Drawing.Size(415, 283);
            this.textBoxOutPut_CSR.TabIndex = 0;
            // 
            // openFileDialogTask_CSR
            // 
            this.openFileDialogTask_CSR.FileName = "openFileDialog1";
            // 
            // toolTip_CSR
            // 
            this.toolTip_CSR.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.panelRight_CSR);
            this.Controls.Add(this.panelLeft_CSR);
            this.Controls.Add(this.panelTop_CSR);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 19 | Чепурных С. Р.";
            this.panelTop_CSR.ResumeLayout(false);
            this.groupBoxTask_CSR.ResumeLayout(false);
            this.groupBoxTask_CSR.PerformLayout();
            this.panelLeft_CSR.ResumeLayout(false);
            this.groupBoxInPut_CSR.ResumeLayout(false);
            this.groupBoxInPut_CSR.PerformLayout();
            this.panelRight_CSR.ResumeLayout(false);
            this.groupBoxOutPut_CSR.ResumeLayout(false);
            this.groupBoxOutPut_CSR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_CSR;
        private System.Windows.Forms.GroupBox groupBoxTask_CSR;
        private System.Windows.Forms.Button buttonOpen_CSR;
        private System.Windows.Forms.Panel panelLeft_CSR;
        private System.Windows.Forms.Panel panelRight_CSR;
        private System.Windows.Forms.Button buttonHelp_CSR;
        private System.Windows.Forms.Button buttonDone_CSR;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxInPut_CSR;
        private System.Windows.Forms.TextBox textBoxInPut_CSR;
        private System.Windows.Forms.GroupBox groupBoxOutPut_CSR;
        private System.Windows.Forms.TextBox textBoxOutPut_CSR;
        private System.Windows.Forms.ToolTip toolTip_CSR;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_CSR;
    }
}


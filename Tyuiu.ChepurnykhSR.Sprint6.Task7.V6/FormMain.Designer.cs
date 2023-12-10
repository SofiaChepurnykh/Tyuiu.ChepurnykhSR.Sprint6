
namespace Tyuiu.ChepurnykhSR.Sprint6.Task7.V6
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
            this.groupBoxTask_CSR = new System.Windows.Forms.GroupBox();
            this.textBoxTask_CSR = new System.Windows.Forms.TextBox();
            this.panelLeft_CSR = new System.Windows.Forms.Panel();
            this.groupBoxInPut_CSR = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_CSR = new System.Windows.Forms.DataGridView();
            this.panelRight_CSR = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_CSR = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_CSR = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHelp_CSR = new System.Windows.Forms.Button();
            this.buttonSave_CSR = new System.Windows.Forms.Button();
            this.buttonDone_CSR = new System.Windows.Forms.Button();
            this.buttonOpenFile_CSR = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.openFileDialogTask_CSR = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_CSR = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_CSR = new System.Windows.Forms.SaveFileDialog();
            this.panelTop_CSR.SuspendLayout();
            this.groupBoxTask_CSR.SuspendLayout();
            this.panelLeft_CSR.SuspendLayout();
            this.groupBoxInPut_CSR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_CSR)).BeginInit();
            this.panelRight_CSR.SuspendLayout();
            this.groupBoxOutPut_CSR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_CSR)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_CSR
            // 
            this.panelTop_CSR.Controls.Add(this.groupBoxTask_CSR);
            this.panelTop_CSR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_CSR.Location = new System.Drawing.Point(0, 81);
            this.panelTop_CSR.Name = "panelTop_CSR";
            this.panelTop_CSR.Size = new System.Drawing.Size(800, 82);
            this.panelTop_CSR.TabIndex = 0;
            // 
            // groupBoxTask_CSR
            // 
            this.groupBoxTask_CSR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTask_CSR.Controls.Add(this.textBoxTask_CSR);
            this.groupBoxTask_CSR.Location = new System.Drawing.Point(12, 0);
            this.groupBoxTask_CSR.Name = "groupBoxTask_CSR";
            this.groupBoxTask_CSR.Size = new System.Drawing.Size(776, 76);
            this.groupBoxTask_CSR.TabIndex = 0;
            this.groupBoxTask_CSR.TabStop = false;
            this.groupBoxTask_CSR.Text = "Условие";
            // 
            // textBoxTask_CSR
            // 
            this.textBoxTask_CSR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTask_CSR.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_CSR.Multiline = true;
            this.textBoxTask_CSR.Name = "textBoxTask_CSR";
            this.textBoxTask_CSR.ReadOnly = true;
            this.textBoxTask_CSR.Size = new System.Drawing.Size(763, 50);
            this.textBoxTask_CSR.TabIndex = 0;
            this.textBoxTask_CSR.Text = resources.GetString("textBoxTask_CSR.Text");
            // 
            // panelLeft_CSR
            // 
            this.panelLeft_CSR.BackColor = System.Drawing.SystemColors.Control;
            this.panelLeft_CSR.Controls.Add(this.groupBoxInPut_CSR);
            this.panelLeft_CSR.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_CSR.Location = new System.Drawing.Point(0, 163);
            this.panelLeft_CSR.Name = "panelLeft_CSR";
            this.panelLeft_CSR.Size = new System.Drawing.Size(397, 287);
            this.panelLeft_CSR.TabIndex = 1;
            // 
            // groupBoxInPut_CSR
            // 
            this.groupBoxInPut_CSR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInPut_CSR.Controls.Add(this.dataGridViewInPut_CSR);
            this.groupBoxInPut_CSR.Location = new System.Drawing.Point(12, 6);
            this.groupBoxInPut_CSR.Name = "groupBoxInPut_CSR";
            this.groupBoxInPut_CSR.Size = new System.Drawing.Size(379, 269);
            this.groupBoxInPut_CSR.TabIndex = 0;
            this.groupBoxInPut_CSR.TabStop = false;
            this.groupBoxInPut_CSR.Text = "Ввод:";
            // 
            // dataGridViewInPut_CSR
            // 
            this.dataGridViewInPut_CSR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_CSR.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewInPut_CSR.Name = "dataGridViewInPut_CSR";
            this.dataGridViewInPut_CSR.ReadOnly = true;
            this.dataGridViewInPut_CSR.Size = new System.Drawing.Size(367, 244);
            this.dataGridViewInPut_CSR.TabIndex = 0;
            // 
            // panelRight_CSR
            // 
            this.panelRight_CSR.BackColor = System.Drawing.SystemColors.Control;
            this.panelRight_CSR.Controls.Add(this.groupBoxOutPut_CSR);
            this.panelRight_CSR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_CSR.Location = new System.Drawing.Point(397, 163);
            this.panelRight_CSR.Name = "panelRight_CSR";
            this.panelRight_CSR.Size = new System.Drawing.Size(403, 287);
            this.panelRight_CSR.TabIndex = 2;
            // 
            // groupBoxOutPut_CSR
            // 
            this.groupBoxOutPut_CSR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutPut_CSR.Controls.Add(this.dataGridViewOutPut_CSR);
            this.groupBoxOutPut_CSR.Location = new System.Drawing.Point(9, 6);
            this.groupBoxOutPut_CSR.Name = "groupBoxOutPut_CSR";
            this.groupBoxOutPut_CSR.Size = new System.Drawing.Size(382, 269);
            this.groupBoxOutPut_CSR.TabIndex = 0;
            this.groupBoxOutPut_CSR.TabStop = false;
            this.groupBoxOutPut_CSR.Text = "Вывод:";
            // 
            // dataGridViewOutPut_CSR
            // 
            this.dataGridViewOutPut_CSR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_CSR.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewOutPut_CSR.Name = "dataGridViewOutPut_CSR";
            this.dataGridViewOutPut_CSR.ReadOnly = true;
            this.dataGridViewOutPut_CSR.Size = new System.Drawing.Size(370, 244);
            this.dataGridViewOutPut_CSR.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHelp_CSR);
            this.panel1.Controls.Add(this.buttonSave_CSR);
            this.panel1.Controls.Add(this.buttonDone_CSR);
            this.panel1.Controls.Add(this.buttonOpenFile_CSR);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 81);
            this.panel1.TabIndex = 3;
            // 
            // buttonHelp_CSR
            // 
            this.buttonHelp_CSR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_CSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_CSR.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_CSR.Image")));
            this.buttonHelp_CSR.Location = new System.Drawing.Point(713, 12);
            this.buttonHelp_CSR.Name = "buttonHelp_CSR";
            this.buttonHelp_CSR.Size = new System.Drawing.Size(75, 52);
            this.buttonHelp_CSR.TabIndex = 3;
            this.toolTipButton_CSR.SetToolTip(this.buttonHelp_CSR, "Сведения о программе");
            this.buttonHelp_CSR.UseVisualStyleBackColor = true;
            this.buttonHelp_CSR.Click += new System.EventHandler(this.buttonHelp_CSR_Click);
            this.buttonHelp_CSR.MouseEnter += new System.EventHandler(this.buttonHelp_CSR_MouseEnter);
            this.buttonHelp_CSR.MouseLeave += new System.EventHandler(this.buttonHelp_CSR_MouseLeave);
            // 
            // buttonSave_CSR
            // 
            this.buttonSave_CSR.Enabled = false;
            this.buttonSave_CSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_CSR.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_CSR.Image")));
            this.buttonSave_CSR.Location = new System.Drawing.Point(174, 12);
            this.buttonSave_CSR.Name = "buttonSave_CSR";
            this.buttonSave_CSR.Size = new System.Drawing.Size(75, 52);
            this.buttonSave_CSR.TabIndex = 2;
            this.toolTipButton_CSR.SetToolTip(this.buttonSave_CSR, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSave_CSR.UseVisualStyleBackColor = true;
            this.buttonSave_CSR.Click += new System.EventHandler(this.buttonSave_CSR_Click);
            this.buttonSave_CSR.MouseEnter += new System.EventHandler(this.buttonSave_CSR_MouseEnter);
            this.buttonSave_CSR.MouseLeave += new System.EventHandler(this.buttonSave_CSR_MouseLeave);
            // 
            // buttonDone_CSR
            // 
            this.buttonDone_CSR.Enabled = false;
            this.buttonDone_CSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_CSR.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_CSR.Image")));
            this.buttonDone_CSR.Location = new System.Drawing.Point(93, 12);
            this.buttonDone_CSR.Name = "buttonDone_CSR";
            this.buttonDone_CSR.Size = new System.Drawing.Size(75, 52);
            this.buttonDone_CSR.TabIndex = 1;
            this.toolTipButton_CSR.SetToolTip(this.buttonDone_CSR, "Выполнить обработку данных");
            this.buttonDone_CSR.UseVisualStyleBackColor = true;
            this.buttonDone_CSR.Click += new System.EventHandler(this.buttonDone_CSR_Click);
            this.buttonDone_CSR.MouseEnter += new System.EventHandler(this.buttonDone_CSR_MouseEnter);
            this.buttonDone_CSR.MouseLeave += new System.EventHandler(this.buttonDone_CSR_MouseLeave);
            // 
            // buttonOpenFile_CSR
            // 
            this.buttonOpenFile_CSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_CSR.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_CSR.Image")));
            this.buttonOpenFile_CSR.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_CSR.Name = "buttonOpenFile_CSR";
            this.buttonOpenFile_CSR.Size = new System.Drawing.Size(75, 52);
            this.buttonOpenFile_CSR.TabIndex = 0;
            this.toolTipButton_CSR.SetToolTip(this.buttonOpenFile_CSR, "Открыть файл для обработки в формате CSV");
            this.buttonOpenFile_CSR.UseVisualStyleBackColor = true;
            this.buttonOpenFile_CSR.Click += new System.EventHandler(this.buttonOpenFile_CSR_Click);
            this.buttonOpenFile_CSR.MouseEnter += new System.EventHandler(this.buttonOpenFile_CSR_MouseEnter);
            this.buttonOpenFile_CSR.MouseLeave += new System.EventHandler(this.buttonOpenFile_CSR_MouseLeave);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(397, 163);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 287);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // openFileDialogTask_CSR
            // 
            this.openFileDialogTask_CSR.FileName = "openFileDialog1";
            // 
            // toolTipButton_CSR
            // 
            this.toolTipButton_CSR.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_CSR.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelRight_CSR);
            this.Controls.Add(this.panelLeft_CSR);
            this.Controls.Add(this.panelTop_CSR);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 6 | Чепурных С. Р.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop_CSR.ResumeLayout(false);
            this.groupBoxTask_CSR.ResumeLayout(false);
            this.groupBoxTask_CSR.PerformLayout();
            this.panelLeft_CSR.ResumeLayout(false);
            this.groupBoxInPut_CSR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_CSR)).EndInit();
            this.panelRight_CSR.ResumeLayout(false);
            this.groupBoxOutPut_CSR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_CSR)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_CSR;
        private System.Windows.Forms.Panel panelLeft_CSR;
        private System.Windows.Forms.Panel panelRight_CSR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button buttonHelp_CSR;
        private System.Windows.Forms.Button buttonSave_CSR;
        private System.Windows.Forms.Button buttonDone_CSR;
        private System.Windows.Forms.Button buttonOpenFile_CSR;
        private System.Windows.Forms.GroupBox groupBoxTask_CSR;
        private System.Windows.Forms.TextBox textBoxTask_CSR;
        private System.Windows.Forms.GroupBox groupBoxInPut_CSR;
        private System.Windows.Forms.GroupBox groupBoxOutPut_CSR;
        private System.Windows.Forms.DataGridView dataGridViewInPut_CSR;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_CSR;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_CSR;
        private System.Windows.Forms.ToolTip toolTipButton_CSR;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_CSR;
    }
}



namespace Tyuiu.ChepurnykhSR.Sprint6.Task3.V17
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
            this.buttonDone_CSR = new System.Windows.Forms.Button();
            this.groupBoxTask_CSR = new System.Windows.Forms.GroupBox();
            this.textBoxData_CSR = new System.Windows.Forms.TextBox();
            this.buttonHelp_CSR = new System.Windows.Forms.Button();
            this.groupBoxResult_CSR = new System.Windows.Forms.GroupBox();
            this.labelResult_CSR = new System.Windows.Forms.Label();
            this.dataGridViewInPutMatrix_CSR = new System.Windows.Forms.DataGridView();
            this.dataGridViewOutPutMatrix_CSR = new System.Windows.Forms.DataGridView();
            this.groupBoxTask_CSR.SuspendLayout();
            this.groupBoxResult_CSR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutMatrix_CSR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutMatrix_CSR)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_CSR
            // 
            this.buttonDone_CSR.Location = new System.Drawing.Point(770, 275);
            this.buttonDone_CSR.Name = "buttonDone_CSR";
            this.buttonDone_CSR.Size = new System.Drawing.Size(89, 32);
            this.buttonDone_CSR.TabIndex = 0;
            this.buttonDone_CSR.Text = "Выполнить";
            this.buttonDone_CSR.UseVisualStyleBackColor = true;
            this.buttonDone_CSR.Click += new System.EventHandler(this.buttonDone_CSR_Click);
            // 
            // groupBoxTask_CSR
            // 
            this.groupBoxTask_CSR.Controls.Add(this.textBoxData_CSR);
            this.groupBoxTask_CSR.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_CSR.Name = "groupBoxTask_CSR";
            this.groupBoxTask_CSR.Size = new System.Drawing.Size(239, 295);
            this.groupBoxTask_CSR.TabIndex = 0;
            this.groupBoxTask_CSR.TabStop = false;
            this.groupBoxTask_CSR.Text = "Условие";
            // 
            // textBoxData_CSR
            // 
            this.textBoxData_CSR.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxData_CSR.Location = new System.Drawing.Point(6, 19);
            this.textBoxData_CSR.Multiline = true;
            this.textBoxData_CSR.Name = "textBoxData_CSR";
            this.textBoxData_CSR.ReadOnly = true;
            this.textBoxData_CSR.Size = new System.Drawing.Size(226, 270);
            this.textBoxData_CSR.TabIndex = 0;
            this.textBoxData_CSR.Text = resources.GetString("textBoxData_CSR.Text");
            // 
            // buttonHelp_CSR
            // 
            this.buttonHelp_CSR.Location = new System.Drawing.Point(730, 275);
            this.buttonHelp_CSR.Name = "buttonHelp_CSR";
            this.buttonHelp_CSR.Size = new System.Drawing.Size(34, 32);
            this.buttonHelp_CSR.TabIndex = 1;
            this.buttonHelp_CSR.Text = "?";
            this.buttonHelp_CSR.UseVisualStyleBackColor = true;
            this.buttonHelp_CSR.Click += new System.EventHandler(this.buttonHelp_CSR_Click);
            // 
            // groupBoxResult_CSR
            // 
            this.groupBoxResult_CSR.Controls.Add(this.dataGridViewOutPutMatrix_CSR);
            this.groupBoxResult_CSR.Controls.Add(this.labelResult_CSR);
            this.groupBoxResult_CSR.Location = new System.Drawing.Point(564, 12);
            this.groupBoxResult_CSR.Name = "groupBoxResult_CSR";
            this.groupBoxResult_CSR.Size = new System.Drawing.Size(295, 257);
            this.groupBoxResult_CSR.TabIndex = 2;
            this.groupBoxResult_CSR.TabStop = false;
            this.groupBoxResult_CSR.Text = "Вывод данных:";
            // 
            // labelResult_CSR
            // 
            this.labelResult_CSR.AutoSize = true;
            this.labelResult_CSR.Location = new System.Drawing.Point(6, 16);
            this.labelResult_CSR.Name = "labelResult_CSR";
            this.labelResult_CSR.Size = new System.Drawing.Size(59, 13);
            this.labelResult_CSR.TabIndex = 1;
            this.labelResult_CSR.Text = "Результат";
            // 
            // dataGridViewInPutMatrix_CSR
            // 
            this.dataGridViewInPutMatrix_CSR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPutMatrix_CSR.Location = new System.Drawing.Point(257, 12);
            this.dataGridViewInPutMatrix_CSR.Name = "dataGridViewInPutMatrix_CSR";
            this.dataGridViewInPutMatrix_CSR.Size = new System.Drawing.Size(299, 289);
            this.dataGridViewInPutMatrix_CSR.TabIndex = 3;
            // 
            // dataGridViewOutPutMatrix_CSR
            // 
            this.dataGridViewOutPutMatrix_CSR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPutMatrix_CSR.Location = new System.Drawing.Point(6, 32);
            this.dataGridViewOutPutMatrix_CSR.Name = "dataGridViewOutPutMatrix_CSR";
            this.dataGridViewOutPutMatrix_CSR.Size = new System.Drawing.Size(280, 219);
            this.dataGridViewOutPutMatrix_CSR.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 319);
            this.Controls.Add(this.dataGridViewInPutMatrix_CSR);
            this.Controls.Add(this.groupBoxResult_CSR);
            this.Controls.Add(this.buttonHelp_CSR);
            this.Controls.Add(this.groupBoxTask_CSR);
            this.Controls.Add(this.buttonDone_CSR);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 17 | Чепурных С. Р.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_CSR.ResumeLayout(false);
            this.groupBoxTask_CSR.PerformLayout();
            this.groupBoxResult_CSR.ResumeLayout(false);
            this.groupBoxResult_CSR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutMatrix_CSR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutMatrix_CSR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_CSR;
        private System.Windows.Forms.GroupBox groupBoxTask_CSR;
        private System.Windows.Forms.Button buttonHelp_CSR;
        private System.Windows.Forms.TextBox textBoxData_CSR;
        private System.Windows.Forms.GroupBox groupBoxResult_CSR;
        private System.Windows.Forms.DataGridView dataGridViewInPutMatrix_CSR;
        private System.Windows.Forms.Label labelResult_CSR;
        private System.Windows.Forms.DataGridView dataGridViewOutPutMatrix_CSR;
    }
}


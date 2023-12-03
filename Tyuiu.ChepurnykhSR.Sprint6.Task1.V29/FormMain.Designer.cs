
namespace Tyuiu.ChepurnykhSR.Sprint6.Task1.V29
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
            this.groupBoxTask_CSR = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_CSR = new System.Windows.Forms.GroupBox();
            this.textBoxResult_CSR = new System.Windows.Forms.TextBox();
            this.buttonDone_CSR = new System.Windows.Forms.Button();
            this.buttonHelp_CSR = new System.Windows.Forms.Button();
            this.groupInput_CSR = new System.Windows.Forms.GroupBox();
            this.labelVarB_CSR = new System.Windows.Forms.Label();
            this.labelVarА_CSR = new System.Windows.Forms.Label();
            this.textBoxVarB_CSR = new System.Windows.Forms.TextBox();
            this.textBoxVarA_CSR = new System.Windows.Forms.TextBox();
            this.labelResult_CSR = new System.Windows.Forms.Label();
            this.lableCondition_CSR = new System.Windows.Forms.Label();
            this.lableConditionTwo_CSR = new System.Windows.Forms.Label();
            this.groupBoxTask_CSR.SuspendLayout();
            this.groupBoxResult_CSR.SuspendLayout();
            this.groupInput_CSR.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_CSR
            // 
            this.groupBoxTask_CSR.Controls.Add(this.lableConditionTwo_CSR);
            this.groupBoxTask_CSR.Controls.Add(this.lableCondition_CSR);
            this.groupBoxTask_CSR.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_CSR.Name = "groupBoxTask_CSR";
            this.groupBoxTask_CSR.Size = new System.Drawing.Size(437, 320);
            this.groupBoxTask_CSR.TabIndex = 0;
            this.groupBoxTask_CSR.TabStop = false;
            this.groupBoxTask_CSR.Text = "Условие";
            // 
            // groupBoxResult_CSR
            // 
            this.groupBoxResult_CSR.Controls.Add(this.labelResult_CSR);
            this.groupBoxResult_CSR.Controls.Add(this.textBoxResult_CSR);
            this.groupBoxResult_CSR.Location = new System.Drawing.Point(455, 12);
            this.groupBoxResult_CSR.Name = "groupBoxResult_CSR";
            this.groupBoxResult_CSR.Size = new System.Drawing.Size(305, 426);
            this.groupBoxResult_CSR.TabIndex = 1;
            this.groupBoxResult_CSR.TabStop = false;
            this.groupBoxResult_CSR.Text = "Вывод данных";
            // 
            // textBoxResult_CSR
            // 
            this.textBoxResult_CSR.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_CSR.Location = new System.Drawing.Point(6, 36);
            this.textBoxResult_CSR.Multiline = true;
            this.textBoxResult_CSR.Name = "textBoxResult_CSR";
            this.textBoxResult_CSR.ReadOnly = true;
            this.textBoxResult_CSR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_CSR.Size = new System.Drawing.Size(293, 384);
            this.textBoxResult_CSR.TabIndex = 0;
            // 
            // buttonDone_CSR
            // 
            this.buttonDone_CSR.BackColor = System.Drawing.Color.Green;
            this.buttonDone_CSR.Location = new System.Drawing.Point(355, 396);
            this.buttonDone_CSR.Name = "buttonDone_CSR";
            this.buttonDone_CSR.Size = new System.Drawing.Size(94, 36);
            this.buttonDone_CSR.TabIndex = 2;
            this.buttonDone_CSR.Text = "Выполнить";
            this.buttonDone_CSR.UseVisualStyleBackColor = false;
            this.buttonDone_CSR.Click += new System.EventHandler(this.buttonDone_CSR_Click);
            // 
            // buttonHelp_CSR
            // 
            this.buttonHelp_CSR.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_CSR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonHelp_CSR.Location = new System.Drawing.Point(275, 396);
            this.buttonHelp_CSR.Name = "buttonHelp_CSR";
            this.buttonHelp_CSR.Size = new System.Drawing.Size(74, 36);
            this.buttonHelp_CSR.TabIndex = 3;
            this.buttonHelp_CSR.Text = "Справка";
            this.buttonHelp_CSR.UseVisualStyleBackColor = false;
            this.buttonHelp_CSR.Click += new System.EventHandler(this.buttonHelp_CSR_Click);
            // 
            // groupInput_CSR
            // 
            this.groupInput_CSR.Controls.Add(this.labelVarB_CSR);
            this.groupInput_CSR.Controls.Add(this.labelVarА_CSR);
            this.groupInput_CSR.Controls.Add(this.textBoxVarB_CSR);
            this.groupInput_CSR.Controls.Add(this.textBoxVarA_CSR);
            this.groupInput_CSR.Location = new System.Drawing.Point(12, 338);
            this.groupInput_CSR.Name = "groupInput_CSR";
            this.groupInput_CSR.Size = new System.Drawing.Size(257, 100);
            this.groupInput_CSR.TabIndex = 4;
            this.groupInput_CSR.TabStop = false;
            this.groupInput_CSR.Text = "Ввод данных";
            // 
            // labelVarB_CSR
            // 
            this.labelVarB_CSR.AutoSize = true;
            this.labelVarB_CSR.Location = new System.Drawing.Point(109, 16);
            this.labelVarB_CSR.Name = "labelVarB_CSR";
            this.labelVarB_CSR.Size = new System.Drawing.Size(69, 13);
            this.labelVarB_CSR.TabIndex = 3;
            this.labelVarB_CSR.Text = "Конец шага:";
            // 
            // labelVarА_CSR
            // 
            this.labelVarА_CSR.AutoSize = true;
            this.labelVarА_CSR.Location = new System.Drawing.Point(6, 16);
            this.labelVarА_CSR.Name = "labelVarА_CSR";
            this.labelVarА_CSR.Size = new System.Drawing.Size(67, 13);
            this.labelVarА_CSR.TabIndex = 2;
            this.labelVarА_CSR.Text = "Старт шага:";
            // 
            // textBoxVarB_CSR
            // 
            this.textBoxVarB_CSR.Location = new System.Drawing.Point(112, 32);
            this.textBoxVarB_CSR.Name = "textBoxVarB_CSR";
            this.textBoxVarB_CSR.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarB_CSR.TabIndex = 1;
            // 
            // textBoxVarA_CSR
            // 
            this.textBoxVarA_CSR.Location = new System.Drawing.Point(6, 32);
            this.textBoxVarA_CSR.Name = "textBoxVarA_CSR";
            this.textBoxVarA_CSR.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarA_CSR.TabIndex = 0;
            // 
            // labelResult_CSR
            // 
            this.labelResult_CSR.AutoSize = true;
            this.labelResult_CSR.Location = new System.Drawing.Point(7, 20);
            this.labelResult_CSR.Name = "labelResult_CSR";
            this.labelResult_CSR.Size = new System.Drawing.Size(62, 13);
            this.labelResult_CSR.TabIndex = 1;
            this.labelResult_CSR.Text = "Результат:";
            // 
            // lableCondition_CSR
            // 
            this.lableCondition_CSR.AutoSize = true;
            this.lableCondition_CSR.Location = new System.Drawing.Point(9, 20);
            this.lableCondition_CSR.Name = "lableCondition_CSR";
            this.lableCondition_CSR.Size = new System.Drawing.Size(272, 13);
            this.lableCondition_CSR.TabIndex = 0;
            this.lableCondition_CSR.Text = "Протабулировать функцию на заданном диапазоне.";
            // 
            // lableConditionTwo_CSR
            // 
            this.lableConditionTwo_CSR.AutoSize = true;
            this.lableConditionTwo_CSR.Location = new System.Drawing.Point(9, 33);
            this.lableConditionTwo_CSR.Name = "lableConditionTwo_CSR";
            this.lableConditionTwo_CSR.Size = new System.Drawing.Size(190, 13);
            this.lableConditionTwo_CSR.TabIndex = 1;
            this.lableConditionTwo_CSR.Text = "Результат вывести в виде таблицы.";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.groupInput_CSR);
            this.Controls.Add(this.buttonHelp_CSR);
            this.Controls.Add(this.buttonDone_CSR);
            this.Controls.Add(this.groupBoxResult_CSR);
            this.Controls.Add(this.groupBoxTask_CSR);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Спринт 6 | Таск 0 | Вариант 11 | Чепурных С. Р.";
            this.groupBoxTask_CSR.ResumeLayout(false);
            this.groupBoxTask_CSR.PerformLayout();
            this.groupBoxResult_CSR.ResumeLayout(false);
            this.groupBoxResult_CSR.PerformLayout();
            this.groupInput_CSR.ResumeLayout(false);
            this.groupInput_CSR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_CSR;
        private System.Windows.Forms.GroupBox groupBoxResult_CSR;
        private System.Windows.Forms.TextBox textBoxResult_CSR;
        private System.Windows.Forms.Button buttonDone_CSR;
        private System.Windows.Forms.Button buttonHelp_CSR;
        private System.Windows.Forms.GroupBox groupInput_CSR;
        private System.Windows.Forms.TextBox textBoxVarB_CSR;
        private System.Windows.Forms.TextBox textBoxVarA_CSR;
        private System.Windows.Forms.Label labelVarB_CSR;
        private System.Windows.Forms.Label labelVarА_CSR;
        private System.Windows.Forms.Label labelResult_CSR;
        private System.Windows.Forms.Label lableConditionTwo_CSR;
        private System.Windows.Forms.Label lableCondition_CSR;
    }
}


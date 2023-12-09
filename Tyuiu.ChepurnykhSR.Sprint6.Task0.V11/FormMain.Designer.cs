
namespace Tyuiu.ChepurnykhSR.Sprint6.Task0.V11
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
            this.groupBoxCondition_CSR = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_CSR = new System.Windows.Forms.PictureBox();
            this.lableCondition_CSR = new System.Windows.Forms.Label();
            this.groupInput_CSR = new System.Windows.Forms.GroupBox();
            this.labelVarX_CSR = new System.Windows.Forms.Label();
            this.textBoxVarX_CSR = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_CSR = new System.Windows.Forms.GroupBox();
            this.labelResult_CSR = new System.Windows.Forms.Label();
            this.textBoxResult_CSR = new System.Windows.Forms.TextBox();
            this.buttonHelp_CSR = new System.Windows.Forms.Button();
            this.groupBoxCondition_CSR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_CSR)).BeginInit();
            this.groupInput_CSR.SuspendLayout();
            this.groupBoxOutput_CSR.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDone_CSR
            // 
            this.buttonDone_CSR.Location = new System.Drawing.Point(495, 315);
            this.buttonDone_CSR.Name = "buttonDone_CSR";
            this.buttonDone_CSR.Size = new System.Drawing.Size(119, 29);
            this.buttonDone_CSR.TabIndex = 0;
            this.buttonDone_CSR.Text = "Выполнить";
            this.buttonDone_CSR.UseVisualStyleBackColor = true;
            this.buttonDone_CSR.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // groupBoxCondition_CSR
            // 
            this.groupBoxCondition_CSR.Controls.Add(this.pictureBoxFormula_CSR);
            this.groupBoxCondition_CSR.Controls.Add(this.lableCondition_CSR);
            this.groupBoxCondition_CSR.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_CSR.Name = "groupBoxCondition_CSR";
            this.groupBoxCondition_CSR.Size = new System.Drawing.Size(602, 165);
            this.groupBoxCondition_CSR.TabIndex = 2;
            this.groupBoxCondition_CSR.TabStop = false;
            this.groupBoxCondition_CSR.Text = "Условие";
            // 
            // pictureBoxFormula_CSR
            // 
            this.pictureBoxFormula_CSR.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_CSR.Image")));
            this.pictureBoxFormula_CSR.Location = new System.Drawing.Point(334, 16);
            this.pictureBoxFormula_CSR.Name = "pictureBoxFormula_CSR";
            this.pictureBoxFormula_CSR.Size = new System.Drawing.Size(262, 37);
            this.pictureBoxFormula_CSR.TabIndex = 1;
            this.pictureBoxFormula_CSR.TabStop = false;
            // 
            // lableCondition_CSR
            // 
            this.lableCondition_CSR.AutoSize = true;
            this.lableCondition_CSR.Location = new System.Drawing.Point(6, 16);
            this.lableCondition_CSR.Name = "lableCondition_CSR";
            this.lableCondition_CSR.Size = new System.Drawing.Size(236, 13);
            this.lableCondition_CSR.TabIndex = 0;
            this.lableCondition_CSR.Text = "Вычислить значение выражения по формуле";
            // 
            // groupInput_CSR
            // 
            this.groupInput_CSR.Controls.Add(this.labelVarX_CSR);
            this.groupInput_CSR.Controls.Add(this.textBoxVarX_CSR);
            this.groupInput_CSR.Location = new System.Drawing.Point(12, 183);
            this.groupInput_CSR.Name = "groupInput_CSR";
            this.groupInput_CSR.Size = new System.Drawing.Size(303, 126);
            this.groupInput_CSR.TabIndex = 3;
            this.groupInput_CSR.TabStop = false;
            this.groupInput_CSR.Text = "Ввод данных";
            // 
            // labelVarX_CSR
            // 
            this.labelVarX_CSR.AutoSize = true;
            this.labelVarX_CSR.Location = new System.Drawing.Point(6, 16);
            this.labelVarX_CSR.Name = "labelVarX_CSR";
            this.labelVarX_CSR.Size = new System.Drawing.Size(84, 13);
            this.labelVarX_CSR.TabIndex = 1;
            this.labelVarX_CSR.Text = "Переменная X:";
            // 
            // textBoxVarX_CSR
            // 
            this.textBoxVarX_CSR.Location = new System.Drawing.Point(9, 32);
            this.textBoxVarX_CSR.Name = "textBoxVarX_CSR";
            this.textBoxVarX_CSR.Size = new System.Drawing.Size(92, 20);
            this.textBoxVarX_CSR.TabIndex = 0;
            this.textBoxVarX_CSR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_KeyPress);
            // 
            // groupBoxOutput_CSR
            // 
            this.groupBoxOutput_CSR.Controls.Add(this.labelResult_CSR);
            this.groupBoxOutput_CSR.Controls.Add(this.textBoxResult_CSR);
            this.groupBoxOutput_CSR.Location = new System.Drawing.Point(321, 183);
            this.groupBoxOutput_CSR.Name = "groupBoxOutput_CSR";
            this.groupBoxOutput_CSR.Size = new System.Drawing.Size(293, 126);
            this.groupBoxOutput_CSR.TabIndex = 4;
            this.groupBoxOutput_CSR.TabStop = false;
            this.groupBoxOutput_CSR.Text = "Вывод данных";
            // 
            // labelResult_CSR
            // 
            this.labelResult_CSR.AutoSize = true;
            this.labelResult_CSR.Location = new System.Drawing.Point(6, 16);
            this.labelResult_CSR.Name = "labelResult_CSR";
            this.labelResult_CSR.Size = new System.Drawing.Size(62, 13);
            this.labelResult_CSR.TabIndex = 1;
            this.labelResult_CSR.Text = "Результат:";
            // 
            // textBoxResult_CSR
            // 
            this.textBoxResult_CSR.Location = new System.Drawing.Point(9, 32);
            this.textBoxResult_CSR.Name = "textBoxResult_CSR";
            this.textBoxResult_CSR.ReadOnly = true;
            this.textBoxResult_CSR.Size = new System.Drawing.Size(89, 20);
            this.textBoxResult_CSR.TabIndex = 0;
            // 
            // buttonHelp_CSR
            // 
            this.buttonHelp_CSR.Location = new System.Drawing.Point(458, 315);
            this.buttonHelp_CSR.Name = "buttonHelp_CSR";
            this.buttonHelp_CSR.Size = new System.Drawing.Size(31, 29);
            this.buttonHelp_CSR.TabIndex = 5;
            this.buttonHelp_CSR.Text = "?";
            this.buttonHelp_CSR.UseVisualStyleBackColor = true;
            this.buttonHelp_CSR.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 356);
            this.Controls.Add(this.buttonHelp_CSR);
            this.Controls.Add(this.groupBoxOutput_CSR);
            this.Controls.Add(this.groupInput_CSR);
            this.Controls.Add(this.groupBoxCondition_CSR);
            this.Controls.Add(this.buttonDone_CSR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Спринт 6 | Таск 0 | Вариант 11 | Чепурных С. Р.";
            this.groupBoxCondition_CSR.ResumeLayout(false);
            this.groupBoxCondition_CSR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_CSR)).EndInit();
            this.groupInput_CSR.ResumeLayout(false);
            this.groupInput_CSR.PerformLayout();
            this.groupBoxOutput_CSR.ResumeLayout(false);
            this.groupBoxOutput_CSR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_CSR;
        private System.Windows.Forms.GroupBox groupBoxCondition_CSR;
        private System.Windows.Forms.Label lableCondition_CSR;
        private System.Windows.Forms.GroupBox groupInput_CSR;
        private System.Windows.Forms.Label labelVarX_CSR;
        private System.Windows.Forms.TextBox textBoxVarX_CSR;
        private System.Windows.Forms.GroupBox groupBoxOutput_CSR;
        private System.Windows.Forms.Label labelResult_CSR;
        private System.Windows.Forms.TextBox textBoxResult_CSR;
        private System.Windows.Forms.Button buttonHelp_CSR;
        private System.Windows.Forms.PictureBox pictureBoxFormula_CSR;
    }
}


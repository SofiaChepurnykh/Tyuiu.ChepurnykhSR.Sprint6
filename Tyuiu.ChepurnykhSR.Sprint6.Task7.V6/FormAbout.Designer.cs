
namespace Tyuiu.ChepurnykhSR.Sprint6.Task7.V6
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_CSR = new System.Windows.Forms.PictureBox();
            this.label_CSR = new System.Windows.Forms.Label();
            this.buttonOK_CSR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_CSR)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_CSR
            // 
            this.pictureBoxAvatar_CSR.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_CSR.Image")));
            this.pictureBoxAvatar_CSR.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxAvatar_CSR.Name = "pictureBoxAvatar_CSR";
            this.pictureBoxAvatar_CSR.Size = new System.Drawing.Size(131, 169);
            this.pictureBoxAvatar_CSR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar_CSR.TabIndex = 0;
            this.pictureBoxAvatar_CSR.TabStop = false;
            // 
            // label_CSR
            // 
            this.label_CSR.AutoSize = true;
            this.label_CSR.Location = new System.Drawing.Point(151, 13);
            this.label_CSR.Name = "label_CSR";
            this.label_CSR.Size = new System.Drawing.Size(284, 117);
            this.label_CSR.TabIndex = 1;
            this.label_CSR.Text = resources.GetString("label_CSR.Text");
            // 
            // buttonOK_CSR
            // 
            this.buttonOK_CSR.Location = new System.Drawing.Point(359, 158);
            this.buttonOK_CSR.Name = "buttonOK_CSR";
            this.buttonOK_CSR.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_CSR.TabIndex = 2;
            this.buttonOK_CSR.Text = "Ok";
            this.buttonOK_CSR.UseVisualStyleBackColor = true;
            this.buttonOK_CSR.Click += new System.EventHandler(this.buttonOK_CSR_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 194);
            this.Controls.Add(this.buttonOK_CSR);
            this.Controls.Add(this.label_CSR);
            this.Controls.Add(this.pictureBoxAvatar_CSR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_CSR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_CSR;
        private System.Windows.Forms.Label label_CSR;
        private System.Windows.Forms.Button buttonOK_CSR;
    }
}
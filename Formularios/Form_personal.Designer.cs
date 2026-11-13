namespace Generacion_de_utileria
{
    partial class Form_personal
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
            dgv_personal = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_personal).BeginInit();
            SuspendLayout();
            // 
            // dgv_personal
            // 
            dgv_personal.Location = new Point(2, 1);
            dgv_personal.Name = "dgv_personal";
            dgv_personal.Size = new Size(771, 369);
            dgv_personal.TabIndex = 0;
            // 
            // Form_personal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 367);
            Controls.Add(dgv_personal);
            Name = "Form_personal";
            Text = "Form_personal";
            Load += Form_personal_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_personal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_personal;
    }
}
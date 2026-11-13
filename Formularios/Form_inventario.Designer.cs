namespace Generacion_de_utileria
{
    partial class Form_inventario
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
            dgv_inventario = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_inventario).BeginInit();
            SuspendLayout();
            // 
            // dgv_inventario
            // 
            dgv_inventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_inventario.Location = new Point(12, 12);
            dgv_inventario.Name = "dgv_inventario";
            dgv_inventario.Size = new Size(694, 301);
            dgv_inventario.TabIndex = 0;
            // 
            // Form_inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_inventario);
            Name = "Form_inventario";
            Text = "Form_inventario";
            Load += Form_inventariol_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_inventario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_inventario;
    }
}
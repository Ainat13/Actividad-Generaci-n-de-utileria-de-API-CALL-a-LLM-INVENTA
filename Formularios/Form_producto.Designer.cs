namespace Generacion_de_utileria
{
    partial class Form_producto
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
            dgv_producto = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_producto).BeginInit();
            SuspendLayout();
            // 
            // dgv_producto
            // 
            dgv_producto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_producto.Location = new Point(1, 3);
            dgv_producto.Name = "dgv_producto";
            dgv_producto.Size = new Size(797, 446);
            dgv_producto.TabIndex = 0;
            // 
            // Form_producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_producto);
            Name = "Form_producto";
            Text = "Form_producto";
            Load += Form_producto_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_producto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_producto;
    }
}
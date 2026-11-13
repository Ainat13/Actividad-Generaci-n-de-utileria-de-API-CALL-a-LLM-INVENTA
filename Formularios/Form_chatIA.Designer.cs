namespace Generacion_de_utileria
{
    partial class Form_chatIA
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
            label_titulo_chat = new Label();
            rtb_conversacion = new RichTextBox();
            tb_pregunta_chat = new TextBox();
            btn_enviar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label_titulo_chat
            // 
            label_titulo_chat.AutoSize = true;
            label_titulo_chat.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_titulo_chat.ForeColor = Color.FromArgb(1, 157, 159);
            label_titulo_chat.Location = new Point(319, 12);
            label_titulo_chat.Name = "label_titulo_chat";
            label_titulo_chat.Size = new Size(118, 31);
            label_titulo_chat.TabIndex = 0;
            label_titulo_chat.Text = "InventAI";
            // 
            // rtb_conversacion
            // 
            rtb_conversacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtb_conversacion.Location = new Point(46, 61);
            rtb_conversacion.Name = "rtb_conversacion";
            rtb_conversacion.ReadOnly = true;
            rtb_conversacion.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtb_conversacion.Size = new Size(716, 218);
            rtb_conversacion.TabIndex = 1;
            rtb_conversacion.Text = "";
            // 
            // tb_pregunta_chat
            // 
            tb_pregunta_chat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_pregunta_chat.Location = new Point(46, 286);
            tb_pregunta_chat.Name = "tb_pregunta_chat";
            tb_pregunta_chat.Size = new Size(621, 23);
            tb_pregunta_chat.TabIndex = 2;
            // 
            // btn_enviar
            // 
            btn_enviar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_enviar.BackColor = Color.FromArgb(0, 168, 181);
            btn_enviar.Cursor = Cursors.Hand;
            btn_enviar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 121, 138);
            btn_enviar.FlatStyle = FlatStyle.Flat;
            btn_enviar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_enviar.ForeColor = Color.White;
            btn_enviar.Location = new Point(687, 285);
            btn_enviar.Name = "btn_enviar";
            btn_enviar.Size = new Size(75, 24);
            btn_enviar.TabIndex = 3;
            btn_enviar.Text = "Enviar";
            btn_enviar.UseVisualStyleBackColor = false;
            btn_enviar.Click += btn_enviar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(551, 37);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            // 
            // Form_chatIA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 250);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btn_enviar);
            Controls.Add(tb_pregunta_chat);
            Controls.Add(rtb_conversacion);
            Controls.Add(label_titulo_chat);
            Name = "Form_chatIA";
            Text = "Form_chatIA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_titulo_chat;
        private RichTextBox rtb_conversacion;
        private TextBox tb_pregunta_chat;
        private Button btn_enviar;
        private Label label1;
    }
}
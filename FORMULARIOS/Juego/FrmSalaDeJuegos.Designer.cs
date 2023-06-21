namespace FORMULARIOS
{
    partial class FrmSalaDeJuegos
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
            richTabla = new RichTextBox();
            btnIniciarPartida = new Button();
            btnCancelarPartida = new Button();
            SuspendLayout();
            // 
            // richTabla
            // 
            richTabla.Location = new Point(12, 12);
            richTabla.Name = "richTabla";
            richTabla.ReadOnly = true;
            richTabla.Size = new Size(550, 537);
            richTabla.TabIndex = 5;
            richTabla.Text = "";
            // 
            // btnIniciarPartida
            // 
            btnIniciarPartida.Location = new Point(584, 104);
            btnIniciarPartida.Name = "btnIniciarPartida";
            btnIniciarPartida.Size = new Size(75, 76);
            btnIniciarPartida.TabIndex = 6;
            btnIniciarPartida.Text = "Lanzar";
            btnIniciarPartida.UseVisualStyleBackColor = true;
            btnIniciarPartida.Click += btnLanzar_Click;
            // 
            // btnCancelarPartida
            // 
            btnCancelarPartida.Location = new Point(584, 186);
            btnCancelarPartida.Name = "btnCancelarPartida";
            btnCancelarPartida.Size = new Size(75, 76);
            btnCancelarPartida.TabIndex = 7;
            btnCancelarPartida.Text = "Cancelar";
            btnCancelarPartida.UseVisualStyleBackColor = true;
            btnCancelarPartida.Click += btnCancelar_Click;
            // 
            // FrmSalaDeJuegos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(684, 561);
            Controls.Add(btnCancelarPartida);
            Controls.Add(btnIniciarPartida);
            Controls.Add(richTabla);
            MaximumSize = new Size(700, 600);
            MinimumSize = new Size(700, 600);
            Name = "FrmSalaDeJuegos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSalaDeJuegos";
            Load += FrmSalaDeJuegos_Load;
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox richTabla;
        private Button btnIniciarPartida;
        private Button btnCancelarPartida;
    }
}
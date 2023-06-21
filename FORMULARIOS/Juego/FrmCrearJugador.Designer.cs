namespace FORMULARIOS
{
    partial class FrmCrearJugador
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
            btnAceptar = new Button();
            txtNombre = new TextBox();
            label2 = new Label();
            labelError = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.Location = new Point(31, 119);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(120, 29);
            btnAceptar.TabIndex = 61;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(110, 37);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(749, 23);
            txtNombre.TabIndex = 57;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 45);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 54;
            label2.Text = "NickName";
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(23, 165);
            labelError.Name = "labelError";
            labelError.Size = new Size(38, 15);
            labelError.TabIndex = 62;
            labelError.Text = "label1";
            // 
            // FrmCrearJugador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(934, 561);
            Controls.Add(labelError);
            Controls.Add(btnAceptar);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            ForeColor = Color.FromArgb(23, 21, 32);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCrearJugador";
            Text = "FrmLogin";
            Load += FrmCrearJugador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAceptar;
        private TextBox txtNombre;
        private Label label2;
        private Label labelError;
    }
}
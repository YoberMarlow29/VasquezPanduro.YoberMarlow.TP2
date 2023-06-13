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
            txtApellido = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.Location = new Point(173, 85);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(120, 29);
            btnAceptar.TabIndex = 61;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtApellido.Location = new Point(110, 37);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(302, 23);
            txtApellido.TabIndex = 57;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(23, 45);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 54;
            label2.Text = "NOMBRE:";
            // 
            // FrmCrearJugador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 344);
            Controls.Add(btnAceptar);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Name = "FrmCrearJugador";
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAceptar;
        private TextBox txtApellido;
        private Label label2;
    }
}
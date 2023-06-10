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
            btnCancelar = new Button();
            btnAceptar = new Button();
            txtClave = new TextBox();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.Location = new Point(171, 268);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 29);
            btnCancelar.TabIndex = 62;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.Location = new Point(171, 221);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(120, 29);
            btnAceptar.TabIndex = 61;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // txtClave
            // 
            txtClave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtClave.Location = new Point(110, 154);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(302, 23);
            txtClave.TabIndex = 60;
            // 
            // txtCorreo
            // 
            txtCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCorreo.Location = new Point(110, 116);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(302, 23);
            txtCorreo.TabIndex = 59;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(110, 76);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(302, 23);
            txtNombre.TabIndex = 58;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtApellido.Location = new Point(110, 37);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(302, 23);
            txtApellido.TabIndex = 57;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(23, 162);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 56;
            label5.Text = "CLAVE:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(23, 124);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 55;
            label3.Text = "CORREO:";
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(23, 84);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 53;
            label1.Text = "APELLIDO:";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 344);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtClave);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmLogin";
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtClave;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
namespace FORMULARIOS
{
    partial class FrmCrearUsuario
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
            labelError = new Label();
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
            btnCancelar.Anchor = AnchorStyles.Left;
            btnCancelar.Location = new Point(135, 260);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 29);
            btnCancelar.TabIndex = 64;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // labelError
            // 
            labelError.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelError.AutoSize = true;
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(48, 375);
            labelError.Name = "labelError";
            labelError.Size = new Size(43, 15);
            labelError.TabIndex = 63;
            labelError.Text = "ERROR";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Left;
            btnAceptar.Location = new Point(135, 213);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(120, 29);
            btnAceptar.TabIndex = 62;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click_1;
            // 
            // txtClave
            // 
            txtClave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtClave.Location = new Point(135, 175);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(241, 23);
            txtClave.TabIndex = 61;
            // 
            // txtCorreo
            // 
            txtCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCorreo.Location = new Point(135, 137);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(241, 23);
            txtCorreo.TabIndex = 60;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(135, 100);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(241, 23);
            txtNombre.TabIndex = 59;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtApellido.Location = new Point(135, 61);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(241, 23);
            txtApellido.TabIndex = 58;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(48, 183);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 57;
            label5.Text = "CLAVE:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(48, 145);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 56;
            label3.Text = "CORREO:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(48, 108);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 55;
            label2.Text = "NOMBRE:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(48, 69);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 54;
            label1.Text = "APELLIDO:";
            // 
            // FrmCrearUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(425, 450);
            Controls.Add(btnCancelar);
            Controls.Add(labelError);
            Controls.Add(btnAceptar);
            Controls.Add(txtClave);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCrearUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCrearUsuario";
            Load += FrmCrearUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Label labelError;
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
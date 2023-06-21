namespace FORMULARIOS
{
    partial class FrmBienvenida
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
            btnCrearCuenta = new Button();
            btnIngresar = new Button();
            label1 = new Label();
            label2 = new Label();
            btnProbarConexion = new Button();
            SuspendLayout();
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCrearCuenta.ForeColor = SystemColors.ActiveCaptionText;
            btnCrearCuenta.Location = new Point(209, 341);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(391, 37);
            btnCrearCuenta.TabIndex = 7;
            btnCrearCuenta.Text = "CREAR CUENTA";
            btnCrearCuenta.UseVisualStyleBackColor = true;
            btnCrearCuenta.Click += btnCrearCuenta_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnIngresar.ForeColor = Color.Black;
            btnIngresar.Location = new Point(209, 289);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(391, 37);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "INICIAR SESION";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(187, 25);
            label1.Name = "label1";
            label1.Size = new Size(426, 54);
            label1.TabIndex = 5;
            label1.Text = "Bienvenidos al Sistema";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(108, 108);
            label2.Name = "label2";
            label2.Size = new Size(620, 37);
            label2.TabIndex = 8;
            label2.Text = "Antes de ingresar pruebe conexion a base de datos";
            // 
            // btnProbarConexion
            // 
            btnProbarConexion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnProbarConexion.ForeColor = Color.Black;
            btnProbarConexion.Location = new Point(209, 176);
            btnProbarConexion.Name = "btnProbarConexion";
            btnProbarConexion.Size = new Size(391, 37);
            btnProbarConexion.TabIndex = 9;
            btnProbarConexion.Text = "PROBAR CONEXION";
            btnProbarConexion.UseVisualStyleBackColor = true;
            btnProbarConexion.Click += btnProbarConexion_Click;
            // 
            // FrmBienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(800, 450);
            Controls.Add(btnProbarConexion);
            Controls.Add(label2);
            Controls.Add(btnCrearCuenta);
            Controls.Add(btnIngresar);
            Controls.Add(label1);
            ForeColor = Color.White;
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "FrmBienvenida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmBienvenida";
            Load += FrmBienvenida_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrearCuenta;
        private Button btnIngresar;
        private Label label1;
        private Label label2;
        private Button btnProbarConexion;
    }
}
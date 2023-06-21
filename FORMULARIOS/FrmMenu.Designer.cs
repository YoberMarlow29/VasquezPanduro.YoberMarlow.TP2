namespace FORMULARIOS
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            panelFormularioHijo = new Panel();
            panelMenuPrincipal = new Panel();
            btnHistorial = new Button();
            btnEstadistica = new Button();
            btnCrearJugadores = new Button();
            btnCrearPartidas = new Button();
            panelUsuario = new Panel();
            lblFecha = new Label();
            lblNombreUsuario = new Label();
            lblCorreoUsuario = new Label();
            pictureBox2 = new PictureBox();
            panelMenuPrincipal.SuspendLayout();
            panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelFormularioHijo
            // 
            panelFormularioHijo.BackColor = Color.FromArgb(23, 21, 32);
            panelFormularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Location = new Point(250, 0);
            panelFormularioHijo.Name = "panelFormularioHijo";
            panelFormularioHijo.Size = new Size(934, 561);
            panelFormularioHijo.TabIndex = 3;
            // 
            // panelMenuPrincipal
            // 
            panelMenuPrincipal.AutoScroll = true;
            panelMenuPrincipal.BackColor = Color.Firebrick;
            panelMenuPrincipal.Controls.Add(btnHistorial);
            panelMenuPrincipal.Controls.Add(btnEstadistica);
            panelMenuPrincipal.Controls.Add(btnCrearJugadores);
            panelMenuPrincipal.Controls.Add(btnCrearPartidas);
            panelMenuPrincipal.Controls.Add(panelUsuario);
            panelMenuPrincipal.Dock = DockStyle.Left;
            panelMenuPrincipal.Location = new Point(0, 0);
            panelMenuPrincipal.Name = "panelMenuPrincipal";
            panelMenuPrincipal.Size = new Size(250, 561);
            panelMenuPrincipal.TabIndex = 2;
            // 
            // btnHistorial
            // 
            btnHistorial.Dock = DockStyle.Top;
            btnHistorial.FlatAppearance.BorderSize = 0;
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.ForeColor = Color.Gainsboro;
            btnHistorial.Location = new Point(0, 333);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Padding = new Padding(10, 0, 0, 0);
            btnHistorial.Size = new Size(250, 45);
            btnHistorial.TabIndex = 7;
            btnHistorial.Text = "HISTORIAL DE PARTIDAS";
            btnHistorial.TextAlign = ContentAlignment.MiddleLeft;
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnEstadistica
            // 
            btnEstadistica.Dock = DockStyle.Top;
            btnEstadistica.FlatAppearance.BorderSize = 0;
            btnEstadistica.FlatStyle = FlatStyle.Flat;
            btnEstadistica.ForeColor = Color.Gainsboro;
            btnEstadistica.Location = new Point(0, 288);
            btnEstadistica.Name = "btnEstadistica";
            btnEstadistica.Padding = new Padding(10, 0, 0, 0);
            btnEstadistica.Size = new Size(250, 45);
            btnEstadistica.TabIndex = 5;
            btnEstadistica.Text = "ESTADISTICAS";
            btnEstadistica.TextAlign = ContentAlignment.MiddleLeft;
            btnEstadistica.UseVisualStyleBackColor = true;
            btnEstadistica.Click += btnEstadistica_Click;
            // 
            // btnCrearJugadores
            // 
            btnCrearJugadores.Dock = DockStyle.Top;
            btnCrearJugadores.FlatAppearance.BorderSize = 0;
            btnCrearJugadores.FlatStyle = FlatStyle.Flat;
            btnCrearJugadores.ForeColor = Color.Gainsboro;
            btnCrearJugadores.Location = new Point(0, 243);
            btnCrearJugadores.Name = "btnCrearJugadores";
            btnCrearJugadores.Padding = new Padding(10, 0, 0, 0);
            btnCrearJugadores.Size = new Size(250, 45);
            btnCrearJugadores.TabIndex = 3;
            btnCrearJugadores.Text = "CREAR JUGADOR";
            btnCrearJugadores.TextAlign = ContentAlignment.MiddleLeft;
            btnCrearJugadores.UseVisualStyleBackColor = true;
            btnCrearJugadores.Click += btnCrearJugadores_Click;
            // 
            // btnCrearPartidas
            // 
            btnCrearPartidas.Dock = DockStyle.Top;
            btnCrearPartidas.FlatAppearance.BorderSize = 0;
            btnCrearPartidas.FlatStyle = FlatStyle.Flat;
            btnCrearPartidas.ForeColor = Color.Gainsboro;
            btnCrearPartidas.Location = new Point(0, 198);
            btnCrearPartidas.Name = "btnCrearPartidas";
            btnCrearPartidas.Padding = new Padding(10, 0, 0, 0);
            btnCrearPartidas.Size = new Size(250, 45);
            btnCrearPartidas.TabIndex = 1;
            btnCrearPartidas.Text = "CREAR PARTIDA";
            btnCrearPartidas.TextAlign = ContentAlignment.MiddleLeft;
            btnCrearPartidas.UseVisualStyleBackColor = true;
            btnCrearPartidas.Click += btnCrearPartidas_Click;
            // 
            // panelUsuario
            // 
            panelUsuario.BackColor = Color.Firebrick;
            panelUsuario.Controls.Add(lblFecha);
            panelUsuario.Controls.Add(lblNombreUsuario);
            panelUsuario.Controls.Add(lblCorreoUsuario);
            panelUsuario.Controls.Add(pictureBox2);
            panelUsuario.Dock = DockStyle.Top;
            panelUsuario.Location = new Point(0, 0);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(250, 198);
            panelUsuario.TabIndex = 0;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(12, 167);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "label3";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.ForeColor = Color.White;
            lblNombreUsuario.Location = new Point(12, 138);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(38, 15);
            lblNombreUsuario.TabIndex = 2;
            lblNombreUsuario.Text = "label2";
            // 
            // lblCorreoUsuario
            // 
            lblCorreoUsuario.AutoSize = true;
            lblCorreoUsuario.ForeColor = Color.White;
            lblCorreoUsuario.Location = new Point(12, 109);
            lblCorreoUsuario.Name = "lblCorreoUsuario";
            lblCorreoUsuario.Size = new Size(38, 15);
            lblCorreoUsuario.TabIndex = 1;
            lblCorreoUsuario.Text = "label1";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(67, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 86);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 561);
            Controls.Add(panelFormularioHijo);
            Controls.Add(panelMenuPrincipal);
            MaximumSize = new Size(1400, 800);
            MinimumSize = new Size(1200, 600);
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMenu";
            Load += FrmMenu_Load;
            panelMenuPrincipal.ResumeLayout(false);
            panelUsuario.ResumeLayout(false);
            panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFormularioHijo;
        private Panel panelMenuPrincipal;
        private Button btnEstadisticas;
        private Button btnHistorial;
        private Button btnEstadistica;
        private Button btnCrearJugadores;
        private Button btnCrearPartidas;
        private Panel panelUsuario;
        private Label lblFecha;
        private Label lblNombreUsuario;
        private Label lblCorreoUsuario;
        private PictureBox pictureBox2;
    }
}
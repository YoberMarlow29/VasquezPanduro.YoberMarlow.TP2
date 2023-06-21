namespace FORMULARIOS
{
    partial class FrmSeleccionarJugador
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
            lblJugadorUno = new Label();
            lblJugadorDos = new Label();
            cmb_JugadorUno = new ComboBox();
            cmb_JugadorDos = new ComboBox();
            btnCrearPartida = new Button();
            labelError = new Label();
            SuspendLayout();
            // 
            // lblJugadorUno
            // 
            lblJugadorUno.AutoSize = true;
            lblJugadorUno.ForeColor = Color.White;
            lblJugadorUno.Location = new Point(31, 120);
            lblJugadorUno.Name = "lblJugadorUno";
            lblJugadorUno.Size = new Size(55, 15);
            lblJugadorUno.TabIndex = 0;
            lblJugadorUno.Text = "Jugador1";
            // 
            // lblJugadorDos
            // 
            lblJugadorDos.AutoSize = true;
            lblJugadorDos.ForeColor = Color.White;
            lblJugadorDos.Location = new Point(448, 120);
            lblJugadorDos.Name = "lblJugadorDos";
            lblJugadorDos.Size = new Size(55, 15);
            lblJugadorDos.TabIndex = 1;
            lblJugadorDos.Text = "Jugador2";
            // 
            // cmb_JugadorUno
            // 
            cmb_JugadorUno.FormattingEnabled = true;
            cmb_JugadorUno.Location = new Point(31, 156);
            cmb_JugadorUno.Name = "cmb_JugadorUno";
            cmb_JugadorUno.Size = new Size(349, 23);
            cmb_JugadorUno.TabIndex = 2;
            // 
            // cmb_JugadorDos
            // 
            cmb_JugadorDos.FormattingEnabled = true;
            cmb_JugadorDos.Location = new Point(448, 156);
            cmb_JugadorDos.Name = "cmb_JugadorDos";
            cmb_JugadorDos.Size = new Size(349, 23);
            cmb_JugadorDos.TabIndex = 3;
            // 
            // btnCrearPartida
            // 
            btnCrearPartida.Location = new Point(357, 222);
            btnCrearPartida.Name = "btnCrearPartida";
            btnCrearPartida.Size = new Size(104, 23);
            btnCrearPartida.TabIndex = 4;
            btnCrearPartida.Text = "Crear Partida";
            btnCrearPartida.UseVisualStyleBackColor = true;
            btnCrearPartida.Click += btnCrearPartida_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(31, 280);
            labelError.Name = "labelError";
            labelError.Size = new Size(38, 15);
            labelError.TabIndex = 63;
            labelError.Text = "label1";
            // 
            // FrmSeleccionarJugador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(918, 522);
            Controls.Add(labelError);
            Controls.Add(btnCrearPartida);
            Controls.Add(cmb_JugadorDos);
            Controls.Add(cmb_JugadorUno);
            Controls.Add(lblJugadorDos);
            Controls.Add(lblJugadorUno);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1134, 761);
            MinimumSize = new Size(934, 561);
            Name = "FrmSeleccionarJugador";
            Text = "SalaDeJuego";
            Load += FrmSeleccionarJugador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJugadorUno;
        private Label lblJugadorDos;
        private ComboBox cmb_JugadorUno;
        private ComboBox cmb_JugadorDos;
        private Button btnCrearPartida;
        private Label labelError;
    }
}
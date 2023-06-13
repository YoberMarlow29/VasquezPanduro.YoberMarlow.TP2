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
            cbJugador1 = new ComboBox();
            cbJugador2 = new ComboBox();
            btnCrearPartida = new Button();
            SuspendLayout();
            // 
            // lblJugadorUno
            // 
            lblJugadorUno.AutoSize = true;
            lblJugadorUno.Location = new Point(12, 24);
            lblJugadorUno.Name = "lblJugadorUno";
            lblJugadorUno.Size = new Size(55, 15);
            lblJugadorUno.TabIndex = 0;
            lblJugadorUno.Text = "Jugador1";
            // 
            // lblJugadorDos
            // 
            lblJugadorDos.AutoSize = true;
            lblJugadorDos.Location = new Point(12, 100);
            lblJugadorDos.Name = "lblJugadorDos";
            lblJugadorDos.Size = new Size(55, 15);
            lblJugadorDos.TabIndex = 1;
            lblJugadorDos.Text = "Jugador2";
            // 
            // cbJugador1
            // 
            cbJugador1.FormattingEnabled = true;
            cbJugador1.Location = new Point(12, 52);
            cbJugador1.Name = "cbJugador1";
            cbJugador1.Size = new Size(121, 23);
            cbJugador1.TabIndex = 2;
            // 
            // cbJugador2
            // 
            cbJugador2.FormattingEnabled = true;
            cbJugador2.Location = new Point(12, 136);
            cbJugador2.Name = "cbJugador2";
            cbJugador2.Size = new Size(121, 23);
            cbJugador2.TabIndex = 3;
            // 
            // btnCrearPartida
            // 
            btnCrearPartida.Location = new Point(12, 187);
            btnCrearPartida.Name = "btnCrearPartida";
            btnCrearPartida.Size = new Size(104, 23);
            btnCrearPartida.TabIndex = 4;
            btnCrearPartida.Text = "Crear Partida";
            btnCrearPartida.UseVisualStyleBackColor = true;
            // 
            // SalaDeJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCrearPartida);
            Controls.Add(cbJugador2);
            Controls.Add(cbJugador1);
            Controls.Add(lblJugadorDos);
            Controls.Add(lblJugadorUno);
            Name = "SalaDeJuego";
            Text = "SalaDeJuego";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJugadorUno;
        private Label lblJugadorDos;
        private ComboBox cbJugador1;
        private ComboBox cbJugador2;
        private Button btnCrearPartida;
    }
}
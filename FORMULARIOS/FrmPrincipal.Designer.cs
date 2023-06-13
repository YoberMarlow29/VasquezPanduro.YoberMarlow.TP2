namespace FORMULARIOS
{
    partial class FrmPrincipal
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
            btnCrearPartida = new Button();
            btnEstadisticas = new Button();
            btnHistorial = new Button();
            btnCrearJugador = new Button();
            SuspendLayout();
            // 
            // btnCrearPartida
            // 
            btnCrearPartida.Location = new Point(158, 132);
            btnCrearPartida.Name = "btnCrearPartida";
            btnCrearPartida.Size = new Size(105, 23);
            btnCrearPartida.TabIndex = 0;
            btnCrearPartida.Text = "Crear Partida";
            btnCrearPartida.UseVisualStyleBackColor = true;
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.Location = new Point(158, 170);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Size = new Size(105, 23);
            btnEstadisticas.TabIndex = 1;
            btnEstadisticas.Text = "Estadisticas";
            btnEstadisticas.UseVisualStyleBackColor = true;
            // 
            // btnHistorial
            // 
            btnHistorial.Location = new Point(158, 211);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(105, 23);
            btnHistorial.TabIndex = 2;
            btnHistorial.Text = "Historial Partida";
            btnHistorial.UseVisualStyleBackColor = true;
            // 
            // btnCrearJugador
            // 
            btnCrearJugador.Location = new Point(158, 258);
            btnCrearJugador.Name = "btnCrearJugador";
            btnCrearJugador.Size = new Size(105, 23);
            btnCrearJugador.TabIndex = 3;
            btnCrearJugador.Text = "Crear jugador";
            btnCrearJugador.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 584);
            Controls.Add(btnCrearJugador);
            Controls.Add(btnHistorial);
            Controls.Add(btnEstadisticas);
            Controls.Add(btnCrearPartida);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCrearPartida;
        private Button btnEstadisticas;
        private Button btnHistorial;
        private Button btnCrearJugador;
    }
}
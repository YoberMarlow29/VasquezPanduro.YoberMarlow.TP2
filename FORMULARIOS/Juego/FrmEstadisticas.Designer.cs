namespace FORMULARIOS
{
    partial class FrmEstadisticas
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
            lblJugadorMasPartidas = new Label();
            lblJugadorMasPartidasGanadas = new Label();
            lblJugadorPartidasMasPerdidas = new Label();
            dgtMasVictorias = new DataGridView();
            dgtMasPuntos = new DataGridView();
            lblTituloUno = new Label();
            lblTituloDos = new Label();
            lblTituloTres = new Label();
            ((System.ComponentModel.ISupportInitialize)dgtMasVictorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgtMasPuntos).BeginInit();
            SuspendLayout();
            // 
            // lblJugadorMasPartidas
            // 
            lblJugadorMasPartidas.AutoSize = true;
            lblJugadorMasPartidas.Location = new Point(147, 105);
            lblJugadorMasPartidas.Name = "lblJugadorMasPartidas";
            lblJugadorMasPartidas.Size = new Size(38, 15);
            lblJugadorMasPartidas.TabIndex = 0;
            lblJugadorMasPartidas.Text = "label1";
            // 
            // lblJugadorMasPartidasGanadas
            // 
            lblJugadorMasPartidasGanadas.AutoSize = true;
            lblJugadorMasPartidasGanadas.Location = new Point(147, 132);
            lblJugadorMasPartidasGanadas.Name = "lblJugadorMasPartidasGanadas";
            lblJugadorMasPartidasGanadas.Size = new Size(38, 15);
            lblJugadorMasPartidasGanadas.TabIndex = 1;
            lblJugadorMasPartidasGanadas.Text = "label2";
            // 
            // lblJugadorPartidasMasPerdidas
            // 
            lblJugadorPartidasMasPerdidas.AutoSize = true;
            lblJugadorPartidasMasPerdidas.Location = new Point(147, 161);
            lblJugadorPartidasMasPerdidas.Name = "lblJugadorPartidasMasPerdidas";
            lblJugadorPartidasMasPerdidas.Size = new Size(38, 15);
            lblJugadorPartidasMasPerdidas.TabIndex = 2;
            lblJugadorPartidasMasPerdidas.Text = "label3";
            // 
            // dgtMasVictorias
            // 
            dgtMasVictorias.AllowUserToAddRows = false;
            dgtMasVictorias.AllowUserToDeleteRows = false;
            dgtMasVictorias.AllowUserToResizeRows = false;
            dgtMasVictorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgtMasVictorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgtMasVictorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtMasVictorias.EnableHeadersVisualStyles = false;
            dgtMasVictorias.Location = new Point(269, 59);
            dgtMasVictorias.MultiSelect = false;
            dgtMasVictorias.Name = "dgtMasVictorias";
            dgtMasVictorias.ReadOnly = true;
            dgtMasVictorias.RowHeadersVisible = false;
            dgtMasVictorias.RowTemplate.Height = 25;
            dgtMasVictorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgtMasVictorias.Size = new Size(414, 548);
            dgtMasVictorias.TabIndex = 10;
            dgtMasVictorias.TabStop = false;
            dgtMasVictorias.VirtualMode = true;
            // 
            // dgtMasPuntos
            // 
            dgtMasPuntos.AllowUserToAddRows = false;
            dgtMasPuntos.AllowUserToDeleteRows = false;
            dgtMasPuntos.AllowUserToResizeRows = false;
            dgtMasPuntos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgtMasPuntos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgtMasPuntos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtMasPuntos.EnableHeadersVisualStyles = false;
            dgtMasPuntos.Location = new Point(707, 59);
            dgtMasPuntos.MultiSelect = false;
            dgtMasPuntos.Name = "dgtMasPuntos";
            dgtMasPuntos.ReadOnly = true;
            dgtMasPuntos.RowHeadersVisible = false;
            dgtMasPuntos.RowTemplate.Height = 25;
            dgtMasPuntos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgtMasPuntos.Size = new Size(414, 548);
            dgtMasPuntos.TabIndex = 11;
            dgtMasPuntos.TabStop = false;
            dgtMasPuntos.VirtualMode = true;
            // 
            // lblTituloUno
            // 
            lblTituloUno.AutoSize = true;
            lblTituloUno.Location = new Point(12, 132);
            lblTituloUno.Name = "lblTituloUno";
            lblTituloUno.Size = new Size(82, 15);
            lblTituloUno.TabIndex = 12;
            lblTituloUno.Text = "El mas insano:";
            // 
            // lblTituloDos
            // 
            lblTituloDos.AutoSize = true;
            lblTituloDos.Location = new Point(12, 105);
            lblTituloDos.Name = "lblTituloDos";
            lblTituloDos.Size = new Size(105, 15);
            lblTituloDos.TabIndex = 13;
            lblTituloDos.Text = "Jugo mas partidas:";
            // 
            // lblTituloTres
            // 
            lblTituloTres.AutoSize = true;
            lblTituloTres.Location = new Point(12, 161);
            lblTituloTres.Name = "lblTituloTres";
            lblTituloTres.Size = new Size(72, 15);
            lblTituloTres.TabIndex = 14;
            lblTituloTres.Text = "El mas noob";
            // 
            // FrmEstadisticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 619);
            Controls.Add(lblTituloTres);
            Controls.Add(lblTituloDos);
            Controls.Add(lblTituloUno);
            Controls.Add(dgtMasPuntos);
            Controls.Add(dgtMasVictorias);
            Controls.Add(lblJugadorPartidasMasPerdidas);
            Controls.Add(lblJugadorMasPartidasGanadas);
            Controls.Add(lblJugadorMasPartidas);
            Name = "FrmEstadisticas";
            Text = "FrmEstadisticas";
            Load += FrmEstadisticas_Load;
            ((System.ComponentModel.ISupportInitialize)dgtMasVictorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgtMasPuntos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJugadorMasPartidas;
        private Label lblJugadorMasPartidasGanadas;
        private Label lblJugadorPartidasMasPerdidas;
        private DataGridView dgtMasVictorias;
        private DataGridView dgtMasPuntos;
        private Label lblTituloUno;
        private Label lblTituloDos;
        private Label lblTituloTres;
    }
}
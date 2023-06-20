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
            dtgListaDeJugadores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgListaDeJugadores).BeginInit();
            SuspendLayout();
            // 
            // lblJugadorMasPartidas
            // 
            lblJugadorMasPartidas.AutoSize = true;
            lblJugadorMasPartidas.Location = new Point(70, 111);
            lblJugadorMasPartidas.Name = "lblJugadorMasPartidas";
            lblJugadorMasPartidas.Size = new Size(38, 15);
            lblJugadorMasPartidas.TabIndex = 0;
            lblJugadorMasPartidas.Text = "label1";
            // 
            // lblJugadorMasPartidasGanadas
            // 
            lblJugadorMasPartidasGanadas.AutoSize = true;
            lblJugadorMasPartidasGanadas.Location = new Point(70, 139);
            lblJugadorMasPartidasGanadas.Name = "lblJugadorMasPartidasGanadas";
            lblJugadorMasPartidasGanadas.Size = new Size(38, 15);
            lblJugadorMasPartidasGanadas.TabIndex = 1;
            lblJugadorMasPartidasGanadas.Text = "label2";
            // 
            // lblJugadorPartidasMasPerdidas
            // 
            lblJugadorPartidasMasPerdidas.AutoSize = true;
            lblJugadorPartidasMasPerdidas.Location = new Point(70, 169);
            lblJugadorPartidasMasPerdidas.Name = "lblJugadorPartidasMasPerdidas";
            lblJugadorPartidasMasPerdidas.Size = new Size(38, 15);
            lblJugadorPartidasMasPerdidas.TabIndex = 2;
            lblJugadorPartidasMasPerdidas.Text = "label3";
            // 
            // dtgListaDeJugadores
            // 
            dtgListaDeJugadores.AllowUserToAddRows = false;
            dtgListaDeJugadores.AllowUserToDeleteRows = false;
            dtgListaDeJugadores.AllowUserToResizeRows = false;
            dtgListaDeJugadores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgListaDeJugadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgListaDeJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListaDeJugadores.EnableHeadersVisualStyles = false;
            dtgListaDeJugadores.Location = new Point(200, 39);
            dtgListaDeJugadores.MultiSelect = false;
            dtgListaDeJugadores.Name = "dtgListaDeJugadores";
            dtgListaDeJugadores.ReadOnly = true;
            dtgListaDeJugadores.RowHeadersVisible = false;
            dtgListaDeJugadores.RowTemplate.Height = 25;
            dtgListaDeJugadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgListaDeJugadores.Size = new Size(910, 479);
            dtgListaDeJugadores.TabIndex = 10;
            dtgListaDeJugadores.TabStop = false;
            dtgListaDeJugadores.VirtualMode = true;
            // 
            // FrmEstadisticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 619);
            Controls.Add(dtgListaDeJugadores);
            Controls.Add(lblJugadorPartidasMasPerdidas);
            Controls.Add(lblJugadorMasPartidasGanadas);
            Controls.Add(lblJugadorMasPartidas);
            Name = "FrmEstadisticas";
            Text = "FrmEstadisticas";
            Load += FrmEstadisticas_Load;
            ((System.ComponentModel.ISupportInitialize)dtgListaDeJugadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJugadorMasPartidas;
        private Label lblJugadorMasPartidasGanadas;
        private Label lblJugadorPartidasMasPerdidas;
        private DataGridView dtgListaDeJugadores;
    }
}
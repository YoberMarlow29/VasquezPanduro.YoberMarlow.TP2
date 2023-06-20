namespace FORMULARIOS
{
    partial class FrmHistorial
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
            dtgListaDeJugadores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgListaDeJugadores).BeginInit();
            SuspendLayout();
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
            dtgListaDeJugadores.Location = new Point(36, 12);
            dtgListaDeJugadores.MultiSelect = false;
            dtgListaDeJugadores.Name = "dtgListaDeJugadores";
            dtgListaDeJugadores.ReadOnly = true;
            dtgListaDeJugadores.RowHeadersVisible = false;
            dtgListaDeJugadores.RowTemplate.Height = 25;
            dtgListaDeJugadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgListaDeJugadores.Size = new Size(921, 529);
            dtgListaDeJugadores.TabIndex = 11;
            dtgListaDeJugadores.TabStop = false;
            dtgListaDeJugadores.VirtualMode = true;
            // 
            // FrmHistorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 553);
            Controls.Add(dtgListaDeJugadores);
            Name = "FrmHistorial";
            Text = "FrmHistorial";
            ((System.ComponentModel.ISupportInitialize)dtgListaDeJugadores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgListaDeJugadores;
    }
}
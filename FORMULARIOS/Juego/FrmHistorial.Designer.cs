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
            dgtHistorialPartidas = new DataGridView();
            btnDeserializarJson = new Button();
            btnDeserializarXml = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgtHistorialPartidas).BeginInit();
            SuspendLayout();
            // 
            // dgtHistorialPartidas
            // 
            dgtHistorialPartidas.AllowUserToAddRows = false;
            dgtHistorialPartidas.AllowUserToDeleteRows = false;
            dgtHistorialPartidas.AllowUserToResizeRows = false;
            dgtHistorialPartidas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgtHistorialPartidas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgtHistorialPartidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtHistorialPartidas.EnableHeadersVisualStyles = false;
            dgtHistorialPartidas.Location = new Point(12, 83);
            dgtHistorialPartidas.MultiSelect = false;
            dgtHistorialPartidas.Name = "dgtHistorialPartidas";
            dgtHistorialPartidas.ReadOnly = true;
            dgtHistorialPartidas.RowHeadersVisible = false;
            dgtHistorialPartidas.RowTemplate.Height = 25;
            dgtHistorialPartidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgtHistorialPartidas.Size = new Size(985, 458);
            dgtHistorialPartidas.TabIndex = 11;
            dgtHistorialPartidas.TabStop = false;
            dgtHistorialPartidas.VirtualMode = true;
            // 
            // btnDeserializarJson
            // 
            btnDeserializarJson.Location = new Point(300, 25);
            btnDeserializarJson.Name = "btnDeserializarJson";
            btnDeserializarJson.Size = new Size(81, 23);
            btnDeserializarJson.TabIndex = 12;
            btnDeserializarJson.Text = "DeserializarJ";
            btnDeserializarJson.UseVisualStyleBackColor = true;
            btnDeserializarJson.Click += btnDeserializarJson_Click;
            // 
            // btnDeserializarXml
            // 
            btnDeserializarXml.Location = new Point(300, 54);
            btnDeserializarXml.Name = "btnDeserializarXml";
            btnDeserializarXml.Size = new Size(81, 23);
            btnDeserializarXml.TabIndex = 13;
            btnDeserializarXml.Text = "DeserializarX";
            btnDeserializarXml.UseVisualStyleBackColor = true;
            btnDeserializarXml.Click += btnDeserializarXml_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(36, 29);
            label1.Name = "label1";
            label1.Size = new Size(258, 15);
            label1.TabIndex = 14;
            label1.Text = "Deserializar Historial de Partidas de archivo Json";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(36, 58);
            label2.Name = "label2";
            label2.Size = new Size(256, 15);
            label2.TabIndex = 15;
            label2.Text = "Deserializar Historial de Partidas de archivo Xml";
            // 
            // FrmHistorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 21, 32);
            ClientSize = new Size(1009, 553);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDeserializarXml);
            Controls.Add(btnDeserializarJson);
            Controls.Add(dgtHistorialPartidas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmHistorial";
            Text = "FrmHistorial";
            ((System.ComponentModel.ISupportInitialize)dgtHistorialPartidas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgtHistorialPartidas;
        private Button btnDeserializarJson;
        private Button btnDeserializarXml;
        private Label label1;
        private Label label2;
    }
}
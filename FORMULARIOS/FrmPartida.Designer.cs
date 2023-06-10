namespace FORMULARIOS
{
    partial class FrmPartida
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
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(12, 12);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(205, 75);
            btnEnviar.TabIndex = 0;
            btnEnviar.Text = "enviar mensaje";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // FrmPartida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnviar);
            Name = "FrmPartida";
            Text = "FrmPartida";
            Load += FrmPartida_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnEnviar;
    }
}
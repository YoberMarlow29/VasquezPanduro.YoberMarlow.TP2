namespace FORMULARIOS
{
    partial class FrmSalaDeJuegos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalaDeJuegos));
            dado1 = new PictureBox();
            dado2 = new PictureBox();
            dado3 = new PictureBox();
            dado4 = new PictureBox();
            dado5 = new PictureBox();
            richTextBox1 = new RichTextBox();
            btnIniciarPartida = new Button();
            btnCancelarPartida = new Button();
            ((System.ComponentModel.ISupportInitialize)dado1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dado2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dado3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dado4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dado5).BeginInit();
            SuspendLayout();
            // 
            // dado1
            // 
            dado1.Image = (Image)resources.GetObject("dado1.Image");
            dado1.Location = new Point(38, 29);
            dado1.Name = "dado1";
            dado1.Size = new Size(100, 100);
            dado1.SizeMode = PictureBoxSizeMode.StretchImage;
            dado1.TabIndex = 0;
            dado1.TabStop = false;
            // 
            // dado2
            // 
            dado2.Image = (Image)resources.GetObject("dado2.Image");
            dado2.Location = new Point(144, 29);
            dado2.Name = "dado2";
            dado2.Size = new Size(100, 100);
            dado2.SizeMode = PictureBoxSizeMode.StretchImage;
            dado2.TabIndex = 1;
            dado2.TabStop = false;
            // 
            // dado3
            // 
            dado3.Image = (Image)resources.GetObject("dado3.Image");
            dado3.Location = new Point(250, 29);
            dado3.Name = "dado3";
            dado3.Size = new Size(100, 100);
            dado3.SizeMode = PictureBoxSizeMode.StretchImage;
            dado3.TabIndex = 2;
            dado3.TabStop = false;
            // 
            // dado4
            // 
            dado4.Image = (Image)resources.GetObject("dado4.Image");
            dado4.Location = new Point(356, 29);
            dado4.Name = "dado4";
            dado4.Size = new Size(100, 100);
            dado4.SizeMode = PictureBoxSizeMode.StretchImage;
            dado4.TabIndex = 3;
            dado4.TabStop = false;
            // 
            // dado5
            // 
            dado5.Image = (Image)resources.GetObject("dado5.Image");
            dado5.Location = new Point(462, 29);
            dado5.Name = "dado5";
            dado5.Size = new Size(100, 100);
            dado5.SizeMode = PictureBoxSizeMode.StretchImage;
            dado5.TabIndex = 4;
            dado5.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(38, 151);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(524, 281);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // btnIniciarPartida
            // 
            btnIniciarPartida.Location = new Point(568, 104);
            btnIniciarPartida.Name = "btnIniciarPartida";
            btnIniciarPartida.Size = new Size(75, 76);
            btnIniciarPartida.TabIndex = 6;
            btnIniciarPartida.Text = "Lanzar";
            btnIniciarPartida.UseVisualStyleBackColor = true;
            btnIniciarPartida.Click += btnLanzar_Click;
            // 
            // btnCancelarPartida
            // 
            btnCancelarPartida.Location = new Point(568, 186);
            btnCancelarPartida.Name = "btnCancelarPartida";
            btnCancelarPartida.Size = new Size(75, 76);
            btnCancelarPartida.TabIndex = 7;
            btnCancelarPartida.Text = "Cancelar";
            btnCancelarPartida.UseVisualStyleBackColor = true;
            btnCancelarPartida.Click += btnCancelar_Click;
            // 
            // FrmSalaDeJuegos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 454);
            Controls.Add(btnCancelarPartida);
            Controls.Add(btnIniciarPartida);
            Controls.Add(richTextBox1);
            Controls.Add(dado5);
            Controls.Add(dado4);
            Controls.Add(dado3);
            Controls.Add(dado2);
            Controls.Add(dado1);
            Name = "FrmSalaDeJuegos";
            Text = "FrmSalaDeJuegos";
            Load += FrmSalaDeJuegos_Load;
            ((System.ComponentModel.ISupportInitialize)dado1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dado2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dado3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dado4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dado5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox dado1;
        private PictureBox dado2;
        private PictureBox dado3;
        private PictureBox dado4;
        private PictureBox dado5;
        private RichTextBox richTextBox1;
        private Button btnIniciarPartida;
        private Button btnCancelarPartida;
    }
}
namespace FORMULARIOS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIniciar = new Button();
            btnCerrar = new Button();
            dataGridView1 = new DataGridView();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(12, 12);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(112, 69);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(12, 87);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(112, 65);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "cerrar todo";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(162, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(384, 322);
            dataGridView1.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(567, 36);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(419, 334);
            listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 491);
            Controls.Add(listBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnCerrar);
            Controls.Add(btnIniciar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnIniciar;
        private Button btnCerrar;
        private DataGridView dataGridView1;
        private ListBox listBox1;
    }
}
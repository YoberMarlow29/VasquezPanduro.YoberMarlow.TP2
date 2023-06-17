﻿using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMULARIOS
{
    public partial class FrmCrearJugador : Form
    {
        public FrmCrearJugador()
        {
            InitializeComponent();
        }
        private void FrmCrearJugador_Load(object sender, EventArgs e)
        {
            labelError.Visible = false;

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                Sistema.AgregarJugador(nombre);
                txtNombre.Text = "";
                this.Close();
            }
            catch(Exception ex)
            {
                this.labelError.Text = $"       {ex.Message}";
                this.labelError.Visible = true;
            }
        }


    }
}

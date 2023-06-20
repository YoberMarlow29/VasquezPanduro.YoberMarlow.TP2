using Entidades;
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
    public partial class FrmHistorial : Form
    {
        public FrmHistorial()
        {
            InitializeComponent();
        }

        private void btnDeserializarJson_Click(object sender, EventArgs e)
        {
            UpdateDataGridJson(dgtHistorialPartidas);
        }

        private void btnDeserializarXml_Click(object sender, EventArgs e)
        {
            UpdateDataGridXml(dgtHistorialPartidas);
        }
        public void UpdateDataGridJson(DataGridView dataGridAeronave)
        {
            if (Sistema.ObtenerHistorialJson().Count > 0)
            {
                dataGridAeronave.DataSource = null;
                dataGridAeronave.DataSource = Sistema.ObtenerHistorialJson();
                dataGridAeronave.Visible = true;
            }
            else
            {
                dataGridAeronave.Visible = false;
            }
        }
        public void UpdateDataGridXml(DataGridView dataGridAeronave)
        {
            if (Sistema.ObtenerHistorialXml().Count > 0)
            {
                dataGridAeronave.DataSource = null;
                dataGridAeronave.DataSource = Sistema.ObtenerHistorialXml();
                dataGridAeronave.Visible = true;
            }
            else
            {
                dataGridAeronave.Visible = false;
            }
        }
    }
}

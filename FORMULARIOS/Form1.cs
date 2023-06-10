namespace FORMULARIOS
{
    public partial class Form1 : Form
    {
        public List<FrmPartida> PartidaList;
        public List<string> ListaMensajes;
        public Form1()
        {
            InitializeComponent();
            PartidaList = new List<FrmPartida>();
            ListaMensajes = new List<string>();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            FrmPartida frmPartida1 = new FrmPartida(PartidaList.Count + 1);
            frmPartida1.enviarMensaje += recibirMensaje;
            PartidaList.Add(frmPartida1);
            frmPartida1.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            foreach (FrmPartida item in PartidaList)
            {
                item.Close();
            }
        }

        public void recibirMensaje(object sender, string mensaje)
        {

            ListaMensajes.Add(mensaje);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaMensajes;
            listBox1.Items.Add(mensaje);
        }

    }
}
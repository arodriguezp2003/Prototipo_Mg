using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mg
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void acercaDelSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menu_Load(object sender, EventArgs e)
        {
            clientesBindingSource.DataSource = f.ListadoClientes();
        }

        private void verificarEstadoNotaPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ESTE ES UN MODULO PARA EL CLIENTE\rEL CLIENTE PUEDE VERRIFICAR SU INFORMACION CON LA NOTA DE PEDIDO");
        }

        private void todosMisPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LISTA TODOS LOS PEDIDOS REALIZADOS");
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LISTA TODOS LOS DESPACHOS REALIZADOS");
        }

        private void conDiferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LISTA TODOS LOS DESPACHOS REALIZADOS, QUE TENGAN DIFERENCIAS EN SUS ARTICULOS");
        }

        private void sinDiferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LISTA TODOS LOS DESPACHOS REALIZADOS, SIN DIFERENCIAS EN SUS ARTICULOS");
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CARGA LA MAESTRA DE PRODUCTOS DESDE WMS");
        }

        private void unidadesDeMedidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CARGA MAESTRA DE UNIDADES DE PEDIDOS DESDE WMS");
        }

        private void despachosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ruta a = new Ruta();
            a.ShowDialog();
        }
    }
}

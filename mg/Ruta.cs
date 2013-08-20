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
    public partial class Ruta : Form
    {
        public Ruta()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AL PROCESAR EL CIERRE PUEDE SER DE 2 FORMAS\r1.- QUE SE DESCUENTE TODO ENTREGANDO UNA IMPRESION QUE ESTA TODO BIEN\r2.-FINALIZAR CON DIFERENCIAS; ESTE ENTREGARA UN REPORTE CON LOS PRODUCTOS CON DIFIRENCIAS");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grillaBindingSource.DataSource = f.CargaGrilla();
        }
    }
}

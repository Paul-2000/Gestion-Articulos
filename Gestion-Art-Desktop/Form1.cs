using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Gestion_Art_Desktop
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pgbArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void ClickArt(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulos alta = new frmAltaArticulos();
            alta.ShowDialog();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            frmListadoArticulos listado = new frmListadoArticulos();
            listado.ShowDialog();
        }
    }
}

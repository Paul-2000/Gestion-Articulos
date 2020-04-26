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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            pgbArticulos.DataSource = negocio.Listar();
            pgbArticulos.Columns[0].Visible = false;
            pgbArticulos.Columns[4].Visible = false;
            pgbArticulos.Columns[5].Visible = false;
            pgbArticulos.Columns[6].Visible = false;
        }

        private void pgbArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pgbArticulos_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Articulos art;
                art = (Articulos)pgbArticulos.CurrentRow.DataBoundItem;
                picArt.Load(art.ImagURL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ClickArt(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulos alta = new frmAltaArticulos();
            alta.ShowDialog();
        }
    }
}

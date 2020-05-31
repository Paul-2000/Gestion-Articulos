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
    public partial class frmListadoArticulos : Form
    {
        public frmListadoArticulos()
        {
            InitializeComponent();
        }

        private void frmListadoArticulos_Load(object sender, EventArgs e)
        {
            ArticulosNegocio articulos = new ArticulosNegocio();
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            dvgArticulos.DataSource = articulos.Listar();
             
            dvgArticulos.Columns[0].Visible = false;
            dvgArticulos.Columns[4].Visible = false;
            dvgArticulos.Columns[5].Visible = false;
            dvgArticulos.Columns[6].Visible = false;
        }
        private void dvgArticulos_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Articulos art;
                art = (Articulos)dvgArticulos.CurrentRow.DataBoundItem;
                picArt.Load(art.ImagURL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void dvgArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

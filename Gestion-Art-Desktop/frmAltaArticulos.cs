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
    public partial class frmAltaArticulos : Form
    {
        public frmAltaArticulos()
        {
            InitializeComponent();
        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulos nArt = new Articulos();
            ArticulosNegocio negocioArt = new ArticulosNegocio();
            try
            {
                nArt.Codigo = txtCodigo.Text.Trim();
                nArt.Nombre = txtNombre.Text.Trim();
                nArt.Descripcion = txtDescripcion.Text.Trim();
                nArt.Marca = (Marca)cboMarca.SelectedItem; ;
                nArt.Categoria = (Categoria)cboCategoria.SelectedItem;
                nArt.ImagURL = txtImagenUrl.Text.Trim();
                //nArt.Precio = (decimal)txtPrecio;
                
                negocioArt.AgregarArt(nArt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("¿Estás seguro que queres salir?");
            Dispose();
        }

        private void frmAltaArticulos_Load(object sender, EventArgs e)
        {
            CategoriaNegocio cate = new CategoriaNegocio();
            MarcaNegocio Marc = new MarcaNegocio();
            try
            {
                cboCategoria.DataSource = cate.Listar();
                cboMarca.DataSource = Marc.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}

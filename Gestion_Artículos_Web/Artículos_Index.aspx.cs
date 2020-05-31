using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Gestion_Artículos_Web
{
    public partial class Artículos_Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticulosNegocio Negocio = new ArticulosNegocio();
            dgvArtículos.DataSource = Negocio.Listar();
            dgvArtículos.DataBind();
        }

        protected void dgvArtículos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gestion_Artículos_Web
{
    public partial class Alta_Artículos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //txtemail.Text = "Ejemplo@gmail.com";
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Session.Add(Session.SessionID + "¡Nombre de Bienvenida!", txtemail.Text);
            Response.Redirect("Bienvenida.aspx");
        }
    }
}
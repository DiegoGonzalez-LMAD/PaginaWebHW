using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaginaWebHW
{
    public partial class PaginaPrincipalaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ( Session["NombreUsuario"]==null)
            {
                Response.Redirect("Inicio_Sesion.aspx");
            }   
        }
        protected void SalirDeSesion(object sender, EventArgs e)
        {
            if (Session["NombreUsuario"] != null)
            {
                Session.Clear();
                Session.Abandon();
                if (Request.Cookies["ASP.NET_SessionId"] != null)
                {
                    Response.Cookies["ASP.NET_SessionId"].Expires = DateTime.Now.AddDays(-1);
                }

                Response.Redirect("Inicio_Sesion.aspx");
            }
        }
    }
}
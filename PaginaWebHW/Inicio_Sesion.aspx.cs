using PaginaWebHW.Data;
using PaginaWebHW.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaginaWebHW
{
    public partial class Inicio_Sesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NombreUsuario"] != null)
            {
                Response.Redirect("PaginaPrincipal.aspx");
            }
            
        }

        protected void IniciarSesion(object sender, EventArgs e)
        {
            var myDB = new DataAcces();
            string name = nombre_Correo_UsuarioTxt_Ini.Text.Trim();
            string contrasenia=ContraOriginalTxt_Ini.Text.Trim();
            try
            {
                SqlParameter[] paramsInicioSesion = new SqlParameter[] {
                        new SqlParameter("@Nombre_Correo", name),
                        new SqlParameter("@contrasenia", contrasenia),
                        

                };
                ET_Usuario usuario = (ET_Usuario)myDB.ExecuteFunction("InicioDeSesion", paramsInicioSesion);
                if (usuario != null)
                {
                    Session["NombreUsuario"]=usuario.nombreUsuario;
                    Session["CorreoElectronico"]=usuario.correoElectronico;
                    Session["IdUsuario"]=usuario.id_Usuario;
                    Response.Redirect("PaginaPrincipal.aspx");
                }
                else {
                    Response.Write("<script>alert('Usuario no encontrado ');</script>");

                }
                

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error: " + ex.Message + "');</script>");

            }

        }
    }
}
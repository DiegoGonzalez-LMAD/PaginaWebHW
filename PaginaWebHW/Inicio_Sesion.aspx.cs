using PaginaWebHW.Data;
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

                var resultado = myDB.ExecuteFunction("InicioDeSesion", paramsInicioSesion);
                bool login = (bool)resultado;
                if (resultado != null && Convert.ToBoolean(resultado))
                {
                    Response.Write("<script>alert('Usuario encontrado con éxito');</script>");
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
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.Net;
using PaginaWebHW.Data;
using System.Data.SqlClient;
using PaginaWebHW.Entities;

namespace PaginaWebHW
{
    public partial class RegistroHW : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }     
        protected void btnSubmit_Click(object sender,EventArgs e)
        {
            var myDB = new DataAcces();
            ET_Usuario usuario = new ET_Usuario();
            usuario.nombreUsuario=nombreUsuarioTxt.Text.Trim();
            usuario.conrasenia= ContraOriginalTxt.Text.Trim();
            string contraseniaDupl = ContraDuplicTxt.Text.Trim();
            usuario.correoElectronico =correoElectronicoTxt.Text.Trim();

            if (!usuario.VerificarCampos(usuario.nombreUsuario, usuario.conrasenia, usuario.correoElectronico))
            {
                Response.Write("<script>alert('No debe haber campos vacios'); window.history.back();</script>");
                
                return;
            }

            if (usuario.conrasenia != contraseniaDupl)
            {
                Response.Write("<script>alert('Las contraseñas no coinciden'); window.history.back();</script>");
                
                return;
            }else
            {
                try
                {
                    SqlParameter[] paramsInsertarUsuario = new SqlParameter[] {
                        new SqlParameter("@aux_NombreUsuario", usuario.nombreUsuario),
                        new SqlParameter("@aux_CorreoElectronico", usuario.correoElectronico),
                        new SqlParameter("@aux_Contrasenia", usuario.conrasenia)

                    };
                    
                    myDB.Execute("SPS_InsertarUsuario", paramsInsertarUsuario);
                    Response.Write("<script>alert('Usuario registrado con éxito');</script>");
                    Response.Redirect("Inicio_Sesion.aspx");

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
                    
                }
            }

        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaginaWebHW.Entities
{
    public class ET_Usuario
    {
        #region Propiedades
        public int id_Usuario {  get; set; }
        public string nombreUsuario {  get; set; }
        public string conrasenia {  get; set; }
        public string correoElectronico { get; set; }

        #endregion

        public ET_Usuario(string aux_nombreUsuario,string aux_contrasenia,string aux_correoElectronico) {
        
            nombreUsuario=aux_nombreUsuario;
            conrasenia=aux_contrasenia;
            correoElectronico=aux_correoElectronico;
        }

        public ET_Usuario()
        {
        }

        public bool VerificarCampos(string aux_nombreUsuario, string aux_contrasenia, string aux_correoElectronico)
        {
            if (aux_nombreUsuario != "" && aux_contrasenia!="" && aux_correoElectronico!="")
            {
                return true;
            }
            else { return false;
            }
                
        }   
    }
}
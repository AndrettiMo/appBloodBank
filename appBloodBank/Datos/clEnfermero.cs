using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBloodBank.Datos
{
    class clEnfermero
    {
        public int idEnfermero { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string NombreEnfermero { get; set; }
        public string ApellidoEnfermero { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int idEntidad { get; set; }

        clConexion objconexion = new clConexion();

        public int  mtdRegistrar()
        {
            string fecha = "";

            fecha = Convert.ToDateTime(FechaNacimiento).ToString("yyyy-MM-dd");

            string consulta = "insert into enfermero(Usuario,Contraseña,NombreEnfermero,ApellidoEnfermero,TipoDocumento,NumeroDocumento,FechaNacimiento,Telefono,Email) values ('" + Usuario + "','" + Contraseña + "','" + NombreEnfermero + "','" + ApellidoEnfermero + "','" + TipoDocumento + "','" + NumeroDocumento + "','" + fecha + "','" + Telefono + "','" + Email + "')";


            int Datos = objconexion.mtdConectado(consulta);
            return Datos;


        }

        public List<clEnfermero> mtdListar()
        {
            string consulta = "select * from enfermero";
            clConexion objConexion = new clConexion();
            DataTable tblenfermero = new DataTable();
            tblenfermero = objConexion.mtdDesconectado(consulta);

            List<clEnfermero> RegistrarEnfermero = new List<clEnfermero>();

            for (int i = 0; i < tblenfermero.Rows.Count; i++)
            {
                clEnfermero objMostrarEnfermero = new clEnfermero();
                objMostrarEnfermero.idEnfermero = int.Parse((tblenfermero.Rows[i]["idEnfermero"].ToString()));
                objMostrarEnfermero.Usuario = (tblenfermero.Rows[i]["Usuario"].ToString());
                objMostrarEnfermero.NombreEnfermero = (tblenfermero.Rows[i]["NombreEnfermero"].ToString());
                objMostrarEnfermero.ApellidoEnfermero = (tblenfermero.Rows[i]["ApellidoEnfermero"].ToString());
                objMostrarEnfermero.TipoDocumento = (tblenfermero.Rows[i]["TipoDocumento"].ToString());
                objMostrarEnfermero.NumeroDocumento = (tblenfermero.Rows[i]["NumeroDocumento"].ToString());
                objMostrarEnfermero.FechaNacimiento = DateTime.Parse(tblenfermero.Rows[i]["FechaNacimiento"].ToString());
                objMostrarEnfermero.Telefono = (tblenfermero.Rows[i]["Telefono"].ToString());
                objMostrarEnfermero.Email = (tblenfermero.Rows[i]["Email"].ToString());
                objMostrarEnfermero.idEntidad = (tblenfermero.Rows[i]["idEntidad"].ToString());

                RegistrarEnfermero.Add(objMostrarEnfermero);
            }
            return RegistrarEnfermero;
        }







    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBloodBank.Datos
{
    class clMostrar
    {
        public List<clDonante> mtdListar()
        {
            string consulta = "select * from donante";
            clConexion objConexion = new clConexion();
            DataTable tblDonante = new DataTable();
            tblDonante = objConexion.mtdDesconectado(consulta);

            List<clDonante> RegistrarDonante = new List<clDonante>();

            for (int i = 0; i < tblDonante.Rows.Count; i++)
            {
                clDonante objMostrarDonante = new clDonante();
                objMostrarDonante.Nombre = (tblDonante.Rows[i]["Nombre"].ToString());
                objMostrarDonante.Apellido = (tblDonante.Rows[i]["Apellido"].ToString());
                objMostrarDonante.Documento = (tblDonante.Rows[i]["Documento"].ToString());
                objMostrarDonante.FechaNacimiento = DateTime.Parse(tblDonante.Rows[i]["fechaNacimiento"].ToString());
                objMostrarDonante.Edad = (tblDonante.Rows[i]["Edad"].ToString());
                objMostrarDonante.Peso = (tblDonante.Rows[i]["Peso"].ToString());
                objMostrarDonante.Genero = (tblDonante.Rows[i]["Genero"].ToString());
                objMostrarDonante.Rh = (tblDonante.Rows[i]["Rh"].ToString());
                objMostrarDonante.PresionArterial = (tblDonante.Rows[i]["PresionArterial"].ToString());
                objMostrarDonante.Temperatura = (tblDonante.Rows[i]["Temperatura"].ToString());
                objMostrarDonante.Telefono = (tblDonante.Rows[i]["Telefono"].ToString());
                objMostrarDonante.Email = (tblDonante.Rows[i]["Email"].ToString());

                RegistrarDonante.Add(objMostrarDonante);
            }
            return RegistrarDonante;
        }
    }
}

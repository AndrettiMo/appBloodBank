using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace appBloodBank.Datos
{
    class clDonante
    {
        public int  idDonante  { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Edad { get; set; }
        public string Peso { get; set; }
        public string Genero { get; set; }
        public string Rh { get; set; }
        public string PresionArterial { get; set; }
        public string Temperatura { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }



        clConexion objConexion = new clConexion();

        public int mtdRegistrar()
        {
            string fecha = "";

            fecha = Convert.ToDateTime(FechaNacimiento).ToString("yyyy-MM-dd");

            string consulta = "insert into donante(Nombre,Apellido,NumeroDocumento,FechaNacimiento,Edad,Peso,Genero,Rh,PresionArterial,Temperatura,Telefono,Email)" +
                                "values('" + Nombre + "','" + Apellido + "','" + Documento + "','" + fecha+"','" +Edad + "','" + Peso + "','" +
                                "" + Genero + "','" + Rh + "','" + PresionArterial + "','" + Temperatura + "','" + Telefono + "','" + Email + "')";


            int registros = objConexion.mtdConectado(consulta);
            return registros;
        }

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
                objMostrarDonante.idDonante =int.Parse( (tblDonante.Rows[i]["idDonante"].ToString()));
                objMostrarDonante.Nombre = (tblDonante.Rows[i]["Nombre"].ToString());
                objMostrarDonante.Apellido = (tblDonante.Rows[i]["Apellido"].ToString());
                objMostrarDonante.Documento = (tblDonante.Rows[i]["NumeroDocumento"].ToString());
                objMostrarDonante.FechaNacimiento = DateTime.Parse(tblDonante.Rows[i]["FechaNacimiento"].ToString());
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


        public int mtdEliminar()
        {
            string consulta = "delete from donante where idDonante =" + idDonante + "";
           int filas= objConexion.mtdConectado(consulta);
           return filas;





        }

        public int mtdActualizar()
        {
           string fecha = Convert.ToDateTime(FechaNacimiento).ToString("yyyy-MM-dd");
           string consulta = "update donante set Nombre='" + Nombre + "',Apellido='" + Apellido + "',NumeroDocumento='" + Documento + "',FechaNacimiento='" + fecha + "',Edad=" + Edad + "',Peso='" + Peso + "',Genero='" + Genero + "',Rh='" + Rh + "',PresionArterial='" + PresionArterial + "',Temperatura='" + Temperatura + "',Email='" + Email + "'";
          int filas= objConexion.mtdConectado(consulta);
            return filas;

           




        }

    }
}

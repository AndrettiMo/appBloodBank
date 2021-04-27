using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBloodBank.Datos
{
    class clDonante
    {
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

    }
}

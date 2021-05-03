using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBloodBank.Datos
{
    class clEntidad
    {
        public int idEntidad { get; set; }
        public string NombreEntidad { get; set; }
        public string CodigoNacional { get; set; }
        public string NombreCiudad { get; set; }
        public string CodigoPostal { get; set; }
        public string Sector { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public int idCiudad { get; set; }

}
}

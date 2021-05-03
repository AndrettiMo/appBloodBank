using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace appBloodBank.Datos
{
    class clJornada
    {
        public int idJornada { get; set; }
        public string NombreJornada { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFinal { get; set; }
        public string Descripcion { get; set; }
        public int idEntidadCiudad { get; set; }

        clConexion objconexion = new clConexion();

        public void mtdconsultarEntidad()
        {

            string consulta = "select entidadciudad.idEntidadCiudad, entidad.NombreEntidad, ciudad.NombreCiudad from entidadciudad inner join entidad on entidad.idEntidad=entidadciudad.idEntidad inner join ciudad on entidadciudad.idCiudad=ciudad.idCiudad";


            List<clJornada> listaconsulta = new List<clJornada>();
            DataTable mostrarJornada = new DataTable();
            mostrarJornada = objconexion.mtdDesconectado(consulta);

            for 
           
        }
    

}
}

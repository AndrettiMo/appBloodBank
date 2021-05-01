using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appBloodBank.Datos
{
    class clBolsaSangre
    {
        public int idBolsaSangre { get; set; }
        public string Nombre { get; set; }
        public string Modificacion { get; set; }
        public string MetodoObtencion { get; set; }
        public string TemperaturaAlmacenamiento { get; set; }
        public string Volumen { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string clasificacionDonante { get; set; }
        public string grupoSanguineo { get; set; }
        public string FactorRHO { get; set; }
        public string ResultadoPrueba { get; set; }

        clConexion objConexion = new clConexion();

        public int mtdRegistrarBolsaSangre()
        {
            string fecha = "";


            fecha = Convert.ToDateTime(FechaVencimiento).ToString("yyyy-MM-dd");

            string consulta = "insert into BolsaSangre (Nombre,Modificacion,MetodoObtencion,TemperaturaAlma,Volumen,FechaVencimiento,ClasificacionDonante,GrupoSanguineo,FactorRho,ResultadoPrueba)"
                + "values('" + Nombre + "','" + Modificacion + "','" + MetodoObtencion + "','" + TemperaturaAlmacenamiento + "','" + Volumen + "'," + fecha + "','" + clasificacionDonante + "','" + grupoSanguineo + "','" + FactorRHO + "','" + ResultadoPrueba + "')";

            int Registro = objConexion.mtdConectado(consulta);
            return Registro;
        }


        public List<clBolsaSangre> mtdListarBolsa()
        {
            string consulta = "select*from BolsaSangre";
            clConexion objConexion = new clConexion();
            DataTable tblBolsaSabgre = new DataTable();
            tblBolsaSabgre = objConexion.mtdDesconectado(consulta);

            List<clBolsaSangre> RegistrarBolsa = new List<clBolsaSangre>();

            for (int i = 0; i < tblBolsaSabgre.Rows.Count; i++)
            {
                clBolsaSangre objVisualizarRegistro = new clBolsaSangre();

                objVisualizarRegistro.idBolsaSangre = int.Parse((tblBolsaSabgre.Rows[i]["idBolsaSangre"].ToString()));
                objVisualizarRegistro.Nombre = (tblBolsaSabgre.Rows[i]["Nombre"].ToString());
                objVisualizarRegistro.Modificacion = (tblBolsaSabgre.Rows[i]["Modificacion"].ToString());
                objVisualizarRegistro.MetodoObtencion = (tblBolsaSabgre.Rows[i]["MetodoObtencion"].ToString());
                objVisualizarRegistro.TemperaturaAlmacenamiento = (tblBolsaSabgre.Rows[i]["TemperaturaAlmacenamiento"].ToString());
                objVisualizarRegistro.Volumen = (tblBolsaSabgre.Rows[i]["Volumen"].ToString());
                objVisualizarRegistro.FechaVencimiento = DateTime.Parse(tblBolsaSabgre.Rows[i]["FechaVencimiento"].ToString());
                objVisualizarRegistro.clasificacionDonante = (tblBolsaSabgre.Rows[i]["ClasificacionDonante"].ToString());
                objVisualizarRegistro.grupoSanguineo = (tblBolsaSabgre.Rows[i]["GrupoSanguineo"].ToString());
                objVisualizarRegistro.FactorRHO = (tblBolsaSabgre.Rows[i]["FactorRho"].ToString());
                objVisualizarRegistro.ResultadoPrueba = (tblBolsaSabgre.Rows[i]["ResultadoPrueba"].ToString());


                RegistrarBolsa.Add(objVisualizarRegistro);


            }
            return RegistrarBolsa;
        }


        public int mtdModificar()
        {
            string fecha = Convert.ToDateTime(FechaVencimiento).ToString("yyyy-MM-dd");
            string consulta = "update BolsaSangre set Nombre='" + Nombre + "',Modificacion='" + Modificacion + "',MetodoObtencion='" + MetodoObtencion + "',TemperaturaAlmacenamiento='" + TemperaturaAlmacenamiento + "',VolumenContenido='" + Volumen + "',FechaVencimiento='"+fecha+"'ClasificacionDonante'"+clasificacionDonante+"',GrupoSanguineo='"+grupoSanguineo+"',FactorRho='"+FactorRHO+"',ResultadoPrueba='"+ResultadoPrueba+"'";
            int filas = objConexion.mtdConectado(consulta);
                                
            return filas;
    }

        public int mtdEliminar()
        {
            string consulta = "delete from BolsaSangre where idBolsaSangre =" + idBolsaSangre + "";
            int Eliminar = objConexion.mtdConectado(consulta);
            return Eliminar;

        }
}     
                
       



         
       
    
}

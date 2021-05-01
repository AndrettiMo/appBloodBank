using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appBloodBank.Datos
{
    class clConexion
    {
        MySqlConnection objConexion = null;


        public clConexion()
        {
            try
            {
                objConexion = new MySqlConnection("server=localhost; user id=root;Port=3306;database=bdbloodbank;Password=1234");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }


        public DataTable mtdDesconectado(string consulta)
        {
            DataTable tblDatos = new DataTable();
            objConexion.Open();
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, objConexion);

            adaptador.Fill(tblDatos);
            objConexion.Close();
            return tblDatos;





        }

        public int mtdConectado(string consulta)
        {
            objConexion.Open();
            MySqlCommand comando = new MySqlCommand(consulta, objConexion);
            int filasAfectadas = comando.ExecuteNonQuery();
            objConexion.Close();
            return filasAfectadas;
        }
    }
}

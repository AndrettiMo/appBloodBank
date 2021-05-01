using appBloodBank.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appBloodBank.Presentacion
{
    public partial class frmBolsaSangre : Form
    {
        clConexion objConexion = new clConexion();
        clBolsaSangre objBolsaSangre = new clBolsaSangre();

        public frmBolsaSangre()
        {
            InitializeComponent();
        }

        private void frmBolsaSangre_Load(object sender, EventArgs e)
        {
            mtdRecargarGrid();
        }

        public void mtdRecargarGrid()
        {
            List<clBolsaSangre> ListarBolsaSangre = new List<clBolsaSangre>();
            ListarBolsaSangre = objBolsaSangre.mtdListarBolsa();
            dgvBolsaSangre.DataSource = ListarBolsaSangre;
                        
        }


        public void mtdCargar()
        {
            objBolsaSangre.Nombre = txtNombreProducto.Text;
            objBolsaSangre.Modificacion = cmbModificacion.Text;
            objBolsaSangre.MetodoObtencion = cmbModificacion.Text;
            objBolsaSangre.


          /*  objRegistrar.Nombre = txtNombre.Text;
            objRegistrar.Apellido = txtApellido.Text;
            objRegistrar.Documento = txtDocumento.Text;
            objRegistrar.FechaNacimiento = DateTime.Parse(dtpFecha.Text);
            objRegistrar.Edad = txtEdad.Text;

            objRegistrar.Peso = txtPeso.Text;
            objRegistrar.Genero = cmbGenero.Text;
            objRegistrar.Rh = cmbRh.Text;
            objRegistrar.PresionArterial = txtPresion.Text;
            objRegistrar.Temperatura = txtTemperatura.Text;
            objRegistrar.Telefono = txtTelefono.Text;
            objRegistrar.Email = txtEmail.Text;*/


        }



    }
}

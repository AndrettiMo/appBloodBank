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
    public partial class frmDonante : Form
    {
        clDonante objDonante = new clDonante();
        string extension = "";

        
        public frmDonante()
        {
            InitializeComponent();
        }

        clConexion conexion = new clConexion();

        private void frmDonante_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }
        List<clDonante> RegistrarDonante = new List<clDonante>();
        private void MostrarProductos()
        {
            clMostrar objDonante = new clMostrar();

           
            RegistrarDonante = objDonante.mtdListar();

            dgvDonante.DataSource = RegistrarDonante;

        }

        

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            clDonante objRegistrar = new clDonante();

            objRegistrar.Nombre = txtNombre.Text;
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
            objRegistrar.Email = txtEmail.Text;

            int Registro = 0;
            Registro = objRegistrar.mtdRegistrar();
            if (Registro > 0)
            {
                MessageBox.Show("Datos insertados correctamente");
            }

            else
            {
                MessageBox.Show("hubo un error, revisar datos");
            }


        }
    }
}
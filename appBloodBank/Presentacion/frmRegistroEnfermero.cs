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
    public partial class frmRegistroEnfermero : Form
    {

        clEnfermero objEnfermero = new clEnfermero();
        string extension = "";


        public frmRegistroEnfermero()
        {
            InitializeComponent();
        }

        clConexion conexion = new clConexion();


        private void frmRegistroEnfermero_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        List<clEnfermero> RegistrarEnfermero = new List<clEnfermero>();
        private void MostrarProductos()
        {

            clEnfermero objmostrar = new clEnfermero();
            RegistrarEnfermero = objmostrar.mtdListar();
            

            dgvEnfermero.DataSource = RegistrarEnfermero;

        }
        clEnfermero objRegistrar = new clEnfermero();

        public void mtdCargar()
        {


            objRegistrar.Usuario = txtUsuario.Text;
            objRegistrar.Contraseña = txtPassword.Text;
            objRegistrar.NombreEnfermero = txtNombreEnfermero.Text;
            objRegistrar.ApellidoEnfermero = txtApellidoEnfermero.Text;
            objRegistrar.NumeroDocumento = txtNumeroDocumento.Text;
            objRegistrar.TipoDocumento = txtTipoDocumento.Text;
            objRegistrar.FechaNacimiento = DateTime.Parse(dtpFecha.Text);
            objRegistrar.Telefono = txtTelefono.Text;
            objRegistrar.Email = txtEmail.Text;

           

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            mtdCargar();

            int Registro = 0;
            Registro = objRegistrar.mtdRegistrar();
            if (Registro > 0)
            {
                MessageBox.Show("Datos Registrados correctamente");
                MostrarProductos(); 
              
            }

            else
            {
                MessageBox.Show("hubo un error, revisar datos");
            }
        }
    }
}

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




            dgvDonante.DataSource = RegistrarDonante;
               


        }
        clDonante objRegistrar = new clDonante();

        public void mtdCargar()
        {


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

        }


        public void mtdLimpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDocumento.Clear();
            txtEdad.Clear();
            txtPeso.Clear();
            txtPresion.Clear();
            txtTemperatura.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();


        }



        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            mtdCargar();

            int Registro = 0;
            Registro = objRegistrar.mtdRegistrar();
            if (Registro > 0)
            {
                MessageBox.Show("Datos insertados correctamente");
                mtdRecargarGrid();
                mtdLimpiar();
            }

            else
            {
                MessageBox.Show("hubo un error, revisar datos");
            }


        }

        public void mtdRecargarGrid()
        {
            List<clDonante> listaDonante = new List<clDonante>();
            listaDonante = objDonante.mtdListar();
            dgvDonante.DataSource = listaDonante;
        }

        private void frmDonante_Load_2(object sender, EventArgs e)
        {
            mtdRecargarGrid();
        }


        int idDonante = 0;

        private void dgvDonante_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvDonante.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                dgvDonante.CurrentRow.Selected = true;
                idDonante = int.Parse(dgvDonante.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                txtNombre.Text = dgvDonante.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtApellido.Text = dgvDonante.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtDocumento.Text = dgvDonante.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                dtpFecha.Value = DateTime.Parse(dgvDonante.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
                txtEdad.Text = dgvDonante.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                txtPeso.Text = dgvDonante.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                cmbGenero.Text = dgvDonante.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                cmbRh.Text = dgvDonante.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
                txtPresion.Text = dgvDonante.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
                txtTemperatura.Text = dgvDonante.Rows[e.RowIndex].Cells[10].FormattedValue.ToString();
                txtTelefono.Text = dgvDonante.Rows[e.RowIndex].Cells[11].FormattedValue.ToString();
                txtEmail.Text = dgvDonante.Rows[e.RowIndex].Cells[12].FormattedValue.ToString();

            }

            }


        public void mtdComprobar(int filas)
        {
            if (filas > 0)
            {
                MessageBox.Show("Proceso Realizado Exitosamente", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtdRecargarGrid();
                mtdLimpiar();

            }
            else
            {
                MessageBox.Show("No Se Pudo Realizar El Proceso", "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        
       

        private void Modificar_Click(object sender, EventArgs e)
        {
            mtdCargar();
            int filas = objRegistrar.mtdActualizar();
            mtdComprobar(filas);
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

            objDonante.idDonante = idDonante;
            DialogResult respuesta = MessageBox.Show("Desea Eliminar el Registro", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            int filas = 0;
            if (respuesta == DialogResult.OK)
            {
                filas = objDonante.mtdEliminar();

            }
            mtdComprobar(filas);
        }

       
    }
    
}
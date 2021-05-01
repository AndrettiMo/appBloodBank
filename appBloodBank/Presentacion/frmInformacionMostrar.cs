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
    public partial class frmInformacionMostrar : Form
    {
        public frmInformacionMostrar()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            
            frmPreguntas mostrar = new frmPreguntas();
            mostrar.lblPregunta.Text = txtMostrar.Text;
         
            
        }

        private void frmInformacionMostrar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form principal = new frmPrincipal();
            principal.Show();
        }

        private void txtMostrar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

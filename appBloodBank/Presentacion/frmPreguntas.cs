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
    public partial class frmPreguntas : Form
    {
        public frmPreguntas()
        {
            InitializeComponent();
        }

        public frmPreguntas(string text)
        {
            InitializeComponent();

            lblPregunta.Text = "Pregunta recibida" + text;
        }

        
    }
}

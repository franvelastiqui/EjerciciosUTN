using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Hola__Windows_Forms_
{
    public partial class frmSaludo : Form
    {
        private string titulo;
        private string mensaje;

        public frmSaludo(string titulo, string mensaje)
        {
            this.titulo = titulo;
            this.mensaje = mensaje;

            InitializeComponent();
        }

        private void frmSaludo_Load(object sender, EventArgs e)
        {
            lblHola.Text = titulo;
            lblNombrePantalla.Text = mensaje;
        }
    }
}

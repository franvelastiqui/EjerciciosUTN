using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmTestDelegados : Form
    {
        private Action<string> delegadoActualizar;

        public FrmTestDelegados(Action<string> delegado)
        {
            InitializeComponent();
            delegadoActualizar = delegado;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (delegadoActualizar != null)
            {
                delegadoActualizar.Invoke(txtNombre.Text);
            }
        }
    }
}

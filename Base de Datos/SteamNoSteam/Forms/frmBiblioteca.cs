using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Forms
{
    public partial class frmBiblioteca : Form
    {
        public frmBiblioteca()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefrescarBiblioteca();
        }

        private void RefrescarBiblioteca()
        {
            dtgvBiblioteca.DataSource = JuegoDAO.Leer();
            dtgvBiblioteca.Refresh();
            dtgvBiblioteca.Update();
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dtgvBiblioteca.SelectedRows.Count > 0)
            {
                int codigoJuego = ((Biblioteca)dtgvBiblioteca.CurrentRow.DataBoundItem).CodigoJuego;
                
                JuegoDAO.Eliminar(codigoJuego);

                RefrescarBiblioteca();
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAlta alta = new frmAlta();

            if(alta.ShowDialog() == DialogResult.OK)
            {
                RefrescarBiblioteca();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dtgvBiblioteca.SelectedRows.Count > 0)
            {
                int codigoJuego = ((Biblioteca)dtgvBiblioteca.CurrentRow.DataBoundItem).CodigoJuego;
                frmAlta alta = new frmAlta(codigoJuego);

                if (alta.ShowDialog() == DialogResult.OK)
                {
                    RefrescarBiblioteca();
                }
            }
        }
    }
}

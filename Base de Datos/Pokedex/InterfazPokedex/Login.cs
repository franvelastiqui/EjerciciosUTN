using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazPokedex
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal;
            string entrenador = string.Empty;

            foreach (RadioButton r in Controls)
            {
                if (r.Checked)
                {
                    entrenador = r.Text;
                    break;
                }
            }

            principal = new(entrenador);

            principal.ShowDialog();
        }
    }
}

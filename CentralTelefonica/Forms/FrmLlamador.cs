using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centralita;
using Central = Centralita.Centralita;

namespace Forms
{
    public partial class FrmLlamador : Form
    {
        Central centralita;

        public FrmLlamador(Central centralita)
        {
            this.centralita = centralita;
            InitializeComponent();
        }

        public Central Centralita
        {
            get
            {
                return centralita;
            }
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            cmbFranja.Enabled = false;
        }

        #region Numeros
        private void btn1_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "9";
        }

        private void ntmAst_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "*";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "0";
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "#";
        }
        #endregion

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtNroDestino.Text) && (txtNroDestino.Text)[0] == '#')
            {
                cmbFranja.Enabled = true;
            }
            else
            {
                cmbFranja.Enabled = false;
            }
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtNroDestino.Text) && !String.IsNullOrWhiteSpace(txtNroOrigen.Text))
            {
                StringBuilder sb = new StringBuilder();
                Random random = new Random();
                float duracion = random.Next(1, 51);

                if (txtNroDestino.Text[0] != '#')
                {
                    float costo = ((float)random.NextDouble()) * (5.6f - 0.5f) + 0.5f;

                    try
                    {
                        _ = centralita + new Local(duracion, txtNroDestino.Text, txtNroOrigen.Text, costo);
                        sb.AppendLine($"Nro Destino: {txtNroDestino.Text}");
                        sb.AppendLine($"Nro Orígen: {txtNroOrigen.Text}");
                        sb.AppendLine($"Duración: {(int)duracion} segundos");
                        sb.Append($"Costo: ${costo.ToString("N2")}");
                        MessageBox.Show(sb.ToString());
                    }
                    catch(CentralitaException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    Provincial.Franja franja;
                    Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franja);

                    try
                    {
                        _ = centralita + new Provincial(duracion, txtNroDestino.Text, txtNroOrigen.Text, franja);
                        sb.AppendLine($"Nro Destino: {txtNroDestino.Text}");
                        sb.AppendLine($"Nro Orígen: {txtNroOrigen.Text}");
                        sb.AppendLine($"Duración: {(int)duracion} segundos");
                        sb.Append($"{franja.ToString()}");
                        MessageBox.Show(sb.ToString());
                    }
                    catch(CentralitaException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }

            txtNroDestino.Text = "";
            txtNroOrigen.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

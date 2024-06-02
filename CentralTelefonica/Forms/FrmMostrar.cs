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
    public partial class FrmMostrar : Form
    {
        Central centralita;
        Llamada.TipoLlamada tipo;
        public FrmMostrar(Central centralita, Llamada.TipoLlamada tipo)
        {
            this.centralita = centralita;
            this.tipo = tipo;
            InitializeComponent();
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            if(centralita.ListaLlamada.Count > 0)
            {
                foreach(Llamada llamada in centralita.ListaLlamada)
                {
                    if ((tipo == Llamada.TipoLlamada.Todas || tipo == Llamada.TipoLlamada.Local) && llamada is Local)
                    {
                        richTextBox1.Text += llamada.ToString();
                        richTextBox1.Text += "\n";
                    }
                    else if ((tipo == Llamada.TipoLlamada.Todas || tipo == Llamada.TipoLlamada.Provincial) && llamada is Provincial)
                    {
                        richTextBox1.Text += llamada.ToString();
                        richTextBox1.Text += "\n";
                    }
                }

                if (tipo == Llamada.TipoLlamada.Local)
                {
                    richTextBox1.Text += "\n-----Ganancia Total por Llamadas Locales-----\n";
                    richTextBox1.Text += $"Facturación total: ${centralita.GananciaPorLocal.ToString("N2")}";
                }
                else if (tipo == Llamada.TipoLlamada.Provincial)
                {
                    richTextBox1.Text += "\n-----Ganancia Total por Llamadas Provinciales-----\n";
                    richTextBox1.Text += $"Facturación total: ${centralita.GananciaPorProvincial.ToString("N2")}";
                }
                else
                {
                    richTextBox1.Text += "\n-----Ganancia Total por Llamadas Totales-----\n";
                    richTextBox1.Text += $"Facturación total: ${centralita.GananciaPorTotal.ToString("N2")}";
                }
            }
        }
    }
}

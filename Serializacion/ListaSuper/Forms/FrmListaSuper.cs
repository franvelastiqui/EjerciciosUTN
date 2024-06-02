using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Forms
{
    public partial class FrmListaSuper : Form
    {
        private List<string> listaSupermercado;
        private static string rutaArchivo;

        static FrmListaSuper()
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            rutaArchivo = Path.Combine(ruta, "listaSupermercado.xml");
        }

        public FrmListaSuper()
        {
            InitializeComponent();
            listaSupermercado = new List<string>();
        }

        private void FrmListaSuper_Load(object sender, EventArgs e)
        {
            ConfigurarToolTips();

            if(File.Exists(rutaArchivo))
            {
                using(StreamReader streamReader =  new StreamReader(rutaArchivo))
                {

                    try
                    {
                        XmlSerializer deserializador = new(listaSupermercado.GetType());
                        listaSupermercado = deserializador.Deserialize(streamReader) as List<string>;
                    }
                    catch (Exception ex)
                    {
                        MostrarMensajeDeError(ex);
                    }
                }
            }

            ActualizarLista();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaModificacion formulario = new FrmAltaModificacion("Agregar objeto", string.Empty, "Agregar");
            formulario.ShowDialog();

            if (formulario.DialogResult == DialogResult.OK)
            {
                listaSupermercado.Add(formulario.Objeto);
            }

            GuardarCambios();
            ActualizarLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string objetoSeleccionado = lstObjetos.SelectedItem as string;

            if (objetoSeleccionado is not null)
            {
                listaSupermercado.Remove(objetoSeleccionado);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento de la lista.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            GuardarCambios();
            ActualizarLista();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string objetoSeleccionado = lstObjetos.SelectedItem as string;

            if(objetoSeleccionado is not null)
            {
                FrmAltaModificacion formulario = new FrmAltaModificacion("Modificar objeto", objetoSeleccionado, "Modificar");
                formulario.ShowDialog();

                if (formulario.DialogResult == DialogResult.OK)
                {
                    int indice = listaSupermercado.IndexOf(objetoSeleccionado);
                    listaSupermercado[indice] = formulario.Objeto;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento de la lista.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            GuardarCambios();
            ActualizarLista();
        }

        private void ConfigurarToolTips()
        {
            toolTipAgregar.SetToolTip(btnAgregar, "Agregar Objeto");
            toolTipEliminar.SetToolTip(btnEliminar, "Eliminar Objeto");
            toolTipModificar.SetToolTip(btnModificar, "Modificar Objeto");
        }

        private void GuardarCambios()
        {
            using(StreamWriter streamWriter = new(rutaArchivo))
            {
                try
                {
                    XmlSerializer serializador = new(listaSupermercado.GetType());
                    serializador.Serialize(streamWriter, listaSupermercado);
                }
                catch(Exception ex)
                {
                    MostrarMensajeDeError(ex);
                }
            }
        }

        private void ActualizarLista()
        {
            lstObjetos.DataSource = null;
            lstObjetos.DataSource = listaSupermercado;
        }

        private void MostrarMensajeDeError(Exception ex)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(ex.Message);
            stringBuilder.AppendLine();
            stringBuilder.AppendLine(ex.StackTrace);

            MessageBox.Show(stringBuilder.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

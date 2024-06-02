using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class FrmCartelera : Form
    {
        private static string rutaConfiguracion;
        private static string rutaActual;

        static FrmCartelera()
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            rutaConfiguracion = Path.Combine(ruta, "configuracion.json");
            rutaActual = "";
        }
        public FrmCartelera()
        {
            InitializeComponent();
        }

        private void FrmCartelera_Load(object sender, EventArgs e)
        {
            CargarJson(rutaConfiguracion);
        }

        #region Cambios de texto
        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            lblTitulo.Text = txtTitulo.Text;
        }

        private void rtxtMensaje_TextChanged(object sender, EventArgs e)
        {
            lblMensaje.Text = rtxtMensaje.Text;
        }

        #endregion

        #region Cambio de colores
        private void btnColorPanel_Click(object sender, EventArgs e)
        {
            pnlCartel.BackColor = SeleccionarColor(pnlCartel.BackColor);
        }

        private void btnColorTitulo_Click(object sender, EventArgs e)
        {
            lblTitulo.ForeColor = SeleccionarColor(lblTitulo.ForeColor);
        }

        private void btnColorMensaje_Click(object sender, EventArgs e)
        {
            lblMensaje.ForeColor = SeleccionarColor(lblMensaje.ForeColor);
        }

        private Color SeleccionarColor(Color color)
        {
            colorDialog.Color = color;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
            }

            return color;
        }
        #endregion

        private void MostrarMensajeDeError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGuardarConfiguracion_Click(object sender, EventArgs e)
        {
            Texto titulo = new Texto(lblTitulo.Text, lblTitulo.ForeColor.ToArgb());
            Texto mensaje = new Texto(lblMensaje.Text, lblMensaje.ForeColor.ToArgb());

            Cartel cartel = new Cartel(pnlCartel.BackColor.ToArgb(), titulo, mensaje);

            try
            {
                string cartelJson = JsonSerializer.Serialize(cartel);

                File.WriteAllText(rutaConfiguracion, cartelJson);
            }
            catch (Exception ex)
            {
                MostrarMensajeDeError(ex);
            }
        }

        private void btnImportarConfiguracion_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Json files (*.json)|*.json";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                CargarJson(ofd.FileName);
            }
        }

        private void CargarJson(string ruta)
        {
            try
            {
                string configuracionJson = File.ReadAllText(ruta);

                Cartel cartel = JsonSerializer.Deserialize<Cartel>(configuracionJson);

                pnlCartel.BackColor = Color.FromArgb(cartel.ColorARGB);

                txtTitulo.Text = cartel.Titulo.Contenido;
                lblTitulo.ForeColor = Color.FromArgb(cartel.Titulo.ColorARGB);

                rtxtMensaje.Text = cartel.Mensaje.Contenido;
                lblMensaje.ForeColor = Color.FromArgb(cartel.Mensaje.ColorARGB);

                rutaActual = ruta;
            }
            catch (JsonException)
            {
                MessageBox.Show("El archivo de configuración no se encuentra en el formato correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MostrarMensajeDeError(ex);
            }
        }

        private void btnEliminarConfiguracion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar la configuración?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if(resultado == DialogResult.OK)
            {
                try
                {
                    if (File.Exists(rutaActual))
                    {
                        File.Delete(rutaActual);
                    }

                    txtTitulo.Text = "Título";
                    lblTitulo.ForeColor = Control.DefaultForeColor;

                    rtxtMensaje.Text = "Mensaje";
                    lblMensaje.ForeColor = Control.DefaultForeColor;

                    pnlCartel.BackColor = Control.DefaultBackColor;
                }
                catch(Exception ex)
                {
                    MostrarMensajeDeError(ex);
                }
            }
        }
    }
}

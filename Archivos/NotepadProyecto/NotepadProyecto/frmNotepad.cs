using System.Text;
using IO;

namespace NotepadProyecto
{
    public partial class frmNotepad : Form
    {
        OpenFileDialog openFileDialog;
        SaveFileDialog saveFileDialog;
        string archivo;

        private PuntoJson<string> puntoJson;
        private PuntoXml<string> puntoXml;
        private PuntoTxt puntoTxt;

        public frmNotepad()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();

            openFileDialog.Filter = "Archivo de texto|*.txt|Archivo JSON|*.json|Archivo XML|*.xml";
            saveFileDialog.Filter = "Archivo de texto|*.txt|Archivo JSON|*.json|Archivo XML|*.xml";
            archivo = string.Empty;

            puntoJson = new();
            puntoXml = new();
            puntoTxt = new();
        }

        private void frmNotepad_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "0 Caracteres";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    archivo = openFileDialog.FileName;

                    switch (Path.GetExtension(archivo))
                    {
                        case ".json":
                            rtbTexto.Text = puntoJson.Leer(archivo);
                            break;
                        case ".xml":
                            rtbTexto.Text = puntoXml.Leer(archivo);
                            break;
                        case ".txt":
                            rtbTexto.Text = puntoTxt.Leer(archivo);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MostrarMensajeError(ex);
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(archivo))
            {
                GuardarComo();
            }
            else
            {
                Guardar();
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarComo();
        }

        private void MostrarMensajeError(Exception ex)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Error: {ex.Message}");
            sb.AppendLine(ex.StackTrace);

            MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Guardar()
        {
            switch (Path.GetExtension(archivo))
            {
                case ".json":
                    puntoJson.Guardar(archivo, rtbTexto.Text);
                    break;
                case ".xml":
                    puntoXml.Guardar(archivo, rtbTexto.Text);
                    break;
                case ".txt":
                    puntoTxt.Guardar(archivo, rtbTexto.Text);
                    break;
            }
        }
        private void GuardarComo()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                archivo = saveFileDialog.FileName;

                switch (Path.GetExtension(archivo))
                {
                    case ".json":
                        puntoJson.GuardarComo(archivo, rtbTexto.Text);
                        break;
                    case ".xml":
                        puntoXml.GuardarComo(archivo, rtbTexto.Text);
                        break;
                    case ".txt":
                        puntoTxt.GuardarComo(archivo, rtbTexto.Text);
                        break;
                }
            }
        }

        private void rtbTexto_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = $"{rtbTexto.Text.Length} caracteres";
        }
    }
}
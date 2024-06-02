using PokedexClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace InterfazPokedex
{
    public partial class FrmSerializacion : Form
    {
        string rutaCarpeta;
        List<Pokemon> lista;

        public FrmSerializacion(List<Pokemon> lista)
        {
            this.lista = lista;
            rutaCarpeta = "..\\..\\..\\..\\ObjetosSerializados";
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtNombreArchivo.Text))
            {
                string ruta = Path.Combine(rutaCarpeta, txtNombreArchivo.Text);

                if (rdbJSON.Checked)
                {
                    try
                    {
                        ruta += ".json";
                        JsonSerializerOptions opciones = new JsonSerializerOptions();
                        opciones.WriteIndented = true;

                        string jsonString = JsonSerializer.Serialize(lista, opciones);

                        //File.Create(ruta);

                        File.WriteAllText(ruta, jsonString);

                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    catch
                    {
                        throw;
                    }
                }
                else if (rdbXML.Checked)
                {
                    try
                    {
                        ruta += ".xml";
                        using (StreamWriter streamWriter = new StreamWriter(ruta))
                        {
                            XmlSerializer xmlSerializer = new XmlSerializer(lista.GetType());

                            xmlSerializer.Serialize(streamWriter, lista);
                        }

                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    catch
                    {
                        throw;
                    }
                }
                else
                {
                    MessageBox.Show("Selecciones una opción");
                }
            }
        }
    }
}

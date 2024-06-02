using Biblioteca;

namespace Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Documento documento = new Documento();
            Foto foto = new Foto();
            Contrato contrato = new Contrato();

            Impresora impresora = new Impresora();

            impresora.AgregarImprimible(documento);
            impresora.AgregarImprimible(foto);
            impresora.AgregarImprimible(contrato);

            richTextBox1.Text = impresora.ImprimirTodo();
        }
    }
}
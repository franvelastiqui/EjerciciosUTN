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
            Pato pato = new(25);
            Boing747 boing747 = new Boing747();
            BuzzLightyear buzzLightyear = new BuzzLightyear();

            TorreDeControl torreDeControl = new TorreDeControl();

            torreDeControl.AgregarVolador(pato);
            torreDeControl.AgregarVolador(boing747);
            torreDeControl.AgregarVolador(buzzLightyear);

            richTextBox1.Text = torreDeControl.VuelenTodos();
        }
    }
}
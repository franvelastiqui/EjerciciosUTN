namespace Atrapame_si_puedes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            rchCalculador.Text = "";
            try
            {
                if (string.IsNullOrWhiteSpace(txtKilometros.Text) || string.IsNullOrWhiteSpace(txtLitros.Text))
                {
                    throw new ParametrosVaciosException("Algunos de los campos está vacío");
                }

                rchCalculador.Text = $"{Calculador.Calcular(int.Parse(txtKilometros.Text), int.Parse(txtLitros.Text))}";
            }
            catch(ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(FormatException)
            {
                MessageBox.Show("El formato de entrada no es el correcto");
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir por 0");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
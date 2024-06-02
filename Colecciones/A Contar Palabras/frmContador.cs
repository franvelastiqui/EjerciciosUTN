using System.Text;

namespace A_Contar_Palabras
{
    public partial class frmContador : Form
    {
        public frmContador()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> lista = new Dictionary<string, int>();
            string[] palabras = rtbPalabras.Text.Split(' ');
            List<KeyValuePair<string,int>> aux = new List<KeyValuePair<string,int>>();
            StringBuilder sb = new StringBuilder();
            int contador = 0;

            foreach (string palabra in palabras)
            {

                if (lista.ContainsKey(palabra))
                {
                    
                    lista[palabra] = lista[palabra] + 1;
                }

                if (!lista.ContainsKey(palabra))
                {
                    lista.Add(palabra, 1);
                }
            }

            aux = lista.ToList();
            aux.Sort(OrdenarDescendente);

            foreach (KeyValuePair<string,int> par in aux)
            {
                sb.AppendLine($"{par.Key}: {par.Value}");
                contador++;

                if(contador == 3)
                {
                    break;
                }
            }

            MessageBox.Show(sb.ToString());
        }

        static int OrdenarDescendente(KeyValuePair<string,int> a, KeyValuePair<string, int> b)
        {
            return b.Value - a.Value;
        }
    }
}
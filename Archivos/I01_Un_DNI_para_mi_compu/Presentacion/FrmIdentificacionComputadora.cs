using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmIdentificacionComputadora : Form
    {
        public FrmIdentificacionComputadora()
        {
            InitializeComponent();
        }

        private void FrmIdentificacionComputadora_Load(object sender, System.EventArgs e)
        {
            Text = $"Compu de {Environment.UserName}";

            ConfigurarLogoSistemaOperativo();

            lblSistemaOperativo.Text = $"Sistema operativo: {Environment.OSVersion}";
            lblNombreMaquina.Text = $"Nombre de la máquina: {Environment.MachineName}";

            ConfigurarArquitectura();

            lblCantProcesadores.Text = $"Cant. procesadores: {Environment.ProcessorCount} procesadores lógicos";

            lblDirectorioActual.Text = $"Identificación ejecutada en: {Environment.NewLine}{Environment.CurrentDirectory}";

            ConfigurarEspacioTotalYDisponible();
        }

        private void ConfigurarLogoSistemaOperativo()
        {
            if(OperatingSystem.IsWindows())
            {
                picboxSistemaOperativo.Image = Properties.Resources.windows;
            }
            else if(OperatingSystem.IsLinux())
            {
                picboxSistemaOperativo.Image = Properties.Resources.linux;
            }
            else if (OperatingSystem.IsMacOS())
            {
                picboxSistemaOperativo.Image = Properties.Resources.mac;
            }
        }

        private void ConfigurarArquitectura()
        {
            if(Environment.Is64BitOperatingSystem)
            {
                lblArquitectura.Text = "Arquitectura: 64 bits";
            }
            else
            {
                lblArquitectura.Text = "Arquitectura: 32 bits";
            }
        }

        private void ConfigurarEspacioTotalYDisponible()
        {
            DriveInfo[] volumenes = DriveInfo.GetDrives();

            lblEspacioTotal.Text = $"Espacio total: {volumenes[0].TotalSize / 1073741824} Gigabytes";
            lblEspacioDisponible.Text = $"Espacio disponible: {volumenes[0].AvailableFreeSpace / 1073741824} Gigabytes";
        }
    }
}

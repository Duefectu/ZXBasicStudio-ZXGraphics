using Avalonia.Controls;
using System.Reflection;

namespace ZXBasicStudio.Dialogs
{
    public partial class SplashScreen : Window
    {
        public SplashScreen()
        {
            InitializeComponent();

            Assembly assembly = Assembly.GetExecutingAssembly();
            // Obtiene la informaci�n de versi�n del ensamblado
            var version = assembly.GetName().Version.ToString();
            txtVersion.Text = "Version " + version + "-beta";
        }
    }
}

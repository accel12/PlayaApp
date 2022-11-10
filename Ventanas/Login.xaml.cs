using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PlayaApp.Ventanas
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, RoutedEventArgs e)
        {
            this.InicioSesion.Visibility=Visibility.Collapsed;
            this.Registro.Visibility=Visibility.Visible;
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            this.InicioSesion.Visibility = Visibility.Visible;
            this.Registro.Visibility = Visibility.Collapsed;
        }
    }
}

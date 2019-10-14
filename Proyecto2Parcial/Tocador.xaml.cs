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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Proyecto2Parcial
{
    /// <summary>
    /// Lógica de interacción para Tocador.xaml
    /// </summary>
    public partial class Tocador : UserControl
    {
        public Tocador()
        {
            InitializeComponent();

            txtAviso.Visibility = Visibility.Hidden;
        }

        private void TbDiseñoTocador_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtAviso.Visibility = Visibility.Hidden;
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (cbTamaño.Text == string.Empty || cbNumeroDePatas.Text == string.Empty || cbBarniz.Text == string.Empty || cbEspejo.Text == string.Empty || cbColor.Text == string.Empty || tbDiseñoTocador.Text == string.Empty)
            {
                txtAviso.Visibility = Visibility.Visible;
            }

            else
            {
                grdUserControl.Children.Clear();
            }
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            grdUserControl.Children.Clear();
        }
    }
}

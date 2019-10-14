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
    /// Lógica de interacción para Puerta.xaml
    /// </summary>
    public partial class Puerta : UserControl
    {
        public Puerta()
        {
            InitializeComponent();

            txtAviso.Visibility = Visibility.Hidden;
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (cbTamaño.Text == string.Empty || cbVentana.Text == string.Empty || cbBarniz.Text == string.Empty|| tbDiseñoPuerta.Text == string.Empty || tbDiseñoVentana.Text == string.Empty)
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

        private void TbDiseñoPuerta_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtAviso.Visibility = Visibility.Hidden;
        }

        private void TbDiseñoVentana_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtAviso.Visibility = Visibility.Hidden;
        }
    }
}

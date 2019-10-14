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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CbProducto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdDatos.Children.Clear();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            switch (cbProducto.SelectedIndex)
            {
                case 0: //Silla
                    grdDatos.Children.Add(new Silla());
                    break;
                case 1: //Mesa
                    grdDatos.Children.Add(new Mesa());
                    break;
                case 2: //Puerta
                    grdDatos.Children.Add(new Puerta());
                    break;
                case 3: //Tocador
                    grdDatos.Children.Add(new Tocador());
                    break;
                case 4: //Cama
                    grdDatos.Children.Add(new Cama());
                    break;
                case 5: //Closet
                    grdDatos.Children.Add(new Closet());
                    break;
                default:
                    break;
            }
        }
    }
}

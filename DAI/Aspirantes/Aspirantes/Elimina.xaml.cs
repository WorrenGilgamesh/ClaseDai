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

namespace Aspirantes
{
    /// <summary>
    /// Lógica de interacción para Elimina.xaml
    /// </summary>
    public partial class Elimina : Window
    {
        public Elimina()
        {
            InitializeComponent();
        }

        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            Connection con = new Connection();
            con.llenarComboAspirante(cb_aspirante);
        }

        private void btn_baja_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cb_aspirante_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

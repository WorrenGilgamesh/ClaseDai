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

namespace Practica
{
    /// <summary>
    /// Lógica de interacción para SegundaVentana.xaml
    /// </summary>
    public partial class SegundaVentana : Window
    {
        private String name;

        public SegundaVentana(String name)
        {
            InitializeComponent();
            this.name = name;
        }

        private void lb_nombre_Loaded(object sender, RoutedEventArgs e)
        {
            lb_nombre.Content = lb_nombre.Content.ToString() + " " + name;
        }

        private void dataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            Conection con = new Conection();
            con.infoUser(dataGrid);
        }
    }
}

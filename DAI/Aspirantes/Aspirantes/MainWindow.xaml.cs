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

namespace Aspirantes
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

        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            Connection con = new Connection();
            con.llenarComboProgramas(cb_programa);
        }

        private void btn_agrega_Click(object sender, RoutedEventArgs e)
        {
            String sexo = rdBtn_hombre.IsChecked == true ? "masculino" : "femenino";
            String gradoStr = rdBtn_4.IsChecked == true ? "4" : rdBtn_5.IsChecked == true ? "5" : "6";
            int grado = int.Parse(gradoStr);
            String fechaNac = dt_fecha.SelectedDate.ToString();
            int prog = 0;
            if (tb_nombre.Text != "" && tb_correo.Text != "" && dt_fecha.SelectedDate.ToString() != "")
            {

                switch (cb_programa.SelectedItem.ToString().Trim())
                {
                    case "Computacion":
                        prog = 1;
                        break;
                    case "Mecatronica":
                        prog = 2;
                        break;
                    case "Telecom":
                        prog = 3;
                        break;
                    case "Industrial":
                        prog = 4;
                        break;
                    case "Negocios":
                        prog = 5;
                        break;
                    default:
                        Console.WriteLine("No entro ningún Programa");
                        break;
                }
            }
        }
    }
}

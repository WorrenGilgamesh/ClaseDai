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
            String sexo = radioH.IsChecked == true ? "masculino" : "femenino";
            String gradoStr = radio1.IsChecked == true ? "4" : radio2.IsChecked == true ? "5" : "6";
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
                Aspirante a = new Aspirante(tb_nombre.Text, sexo, fechaNac, tb_correo.Text, grado, prog);

                tb_nombre.Text = "";
                tb_correo.Text = "";
                cb_programa.SelectedIndex = 0;

                Connection con = new Connection();
                int res = con.agregaAspirante(a);
                if (res > 0)
                {
                    MessageBox.Show("Se ha dado de alta correctamente");

                }
                else
                {
                    MessageBox.Show("Error, no se dio de alta");
                }
            }
            else
            {
                MessageBox.Show("Falta rellenar campos");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Elimina frame = new Elimina();
            frame.Show();
        }

        private void btn_modifica_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Modifica elimina_frm = new Modifica();
            elimina_frm.Show();
        }

        private void btn_reporte_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Reporte reporte_frm = new Reporte();
            reporte_frm.Show();
        }

        private void btn_inicioSesion_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            LogIn reporte_frm = new LogIn();
            reporte_frm.Show();
        }
    }
}

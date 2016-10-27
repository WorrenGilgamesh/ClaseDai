using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for Modifica.xaml
    /// </summary>
    public partial class Modifica : Window
    {
        public Modifica()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Connection con = new Connection();
            con.llenarComboAspirante(cb_aspirante);
            con.llenarComboProgramas(cb_programa);
            con.rellenarDatos(cb_aspirante, tb_correo, radio1, radio2, radio3, cb_programa);
        }

        private void btn_regreso_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow main_frm = new MainWindow();
            main_frm.Show();
        }

        private void cb_aspirante_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Connection con = new Connection();

            if (con != null)
            {
                con.rellenarDatos(cb_aspirante, tb_correo, radio1, radio2, radio3, cb_programa);               
            }
            else
            {
                MessageBox.Show("No se llenaron los datos adecuadamente");
            }
        }

        private void btn_modifica_Click(object sender, RoutedEventArgs e)
        {
            Connection con = new Connection();

            if (con != null)
            {
                con.modificacion(cb_aspirante, tb_correo, cb_programa, radio1, radio2);                
            }
            else
            {
                MessageBox.Show("No se llenaron los datos adecuadamente");
            }
        }
    }
}

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
    /// Interaction logic for Reporte.xaml
    /// </summary>
    public partial class Reporte : Window
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void btn_regreso_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow main_frm = new MainWindow();
            main_frm.Show();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Connection con = new Connection();
            con.llenarComboProgramas(cb_programa);
            cb_programa.Items.Add("Todos");
        }

        private void cb_programa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Connection con = new Connection();
            con.llenaGrid(grid1, cb_programa);
        }

        
    }
}

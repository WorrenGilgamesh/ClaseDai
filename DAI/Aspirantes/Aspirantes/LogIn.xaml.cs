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
    /// Lógica de interacción para LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            Connection con = new Connection();
        }

        private void btn_enviar_Click(object sender, RoutedEventArgs e)
        {
            String usuario = tb_usuario.ToString();
            String contraseña = tb_contraseña.ToString();
            Usuario us = new Usuario(usuario, contraseña);
            Connection con = new Connection();
            int res = con.ChecaUsuario;
            if (res > 0)
            {
                MessageBox.Show("Se encontro");

            }
        }
    }
}

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

namespace Practica
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

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            String name = tb_user.Text.ToString().Trim();
            String pass = tb_password.Text.ToString().Trim();
            if (!name.Equals("") && !pass.Equals(""))
            {
                Boolean res;
                Conection con = new Conection();
                res = con.ChecaUsuario(name, pass);

                if (res)
                {
                    SegundaVentana segVen = new SegundaVentana();
                    segVen.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecta");
                }
            }
            else
                MessageBox.Show("Faltan Datos");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Practica
{
    class Conection
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader dr;

        public static SqlConnection Connect()
        {
            try
            {
                SqlConnection cnn;
                String computadora = "CC201-21";
                String baseDatos = "Login";
                //Data Source=WORRENGILGAMESH;Initial Catalog=Login;Integrated Security=True
                //Data Source=CC201-21;Initial Catalog=Login;Persist Security Info=True;User ID=sa;Password=sqladmin
                cnn = new SqlConnection("Data Source=WORRENGILGAMESH;Initial Catalog=Login;Integrated Security=True");
                //tabla Users, id int; name navchar(50); pass navchar(50);
                cnn.Open();
                MessageBox.Show("Conexion Exitosa");
                return cnn;
            }
            catch (Exception)
            {

                return null;
            }            
        }

        public Boolean ChecaUsuario(String user, String pass)
        {
            con = Connect();
            Boolean res = false;            
            if (con != null)
            {
                String query = "SELECT Users.pass FROM Users WHERE Users.name = '" + user + "'";
                cmd = new SqlCommand(query, con);

                try
                {
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr.GetString(0).Equals(pass))
                        {
                            res = true;
                        }
                    }
                    dr.Close();
                    con.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    MessageBox.Show(e.Message);
                    return res;
                }               
            }
            return res;        
        }

        public void infoUser(DataGrid dtaGrid)
        {
            con = Connect();
            if (con != null)
            {
                String query = "SELECT Users.* FROM Users";
                cmd = new SqlCommand(query, con);
                dr= cmd.ExecuteReader();
                dtaGrid.ItemsSource = dr;                
            }
        }


    }
}

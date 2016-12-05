using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
                String computadora = "112SALAS31";
                String baseDatos = "Login";
                cnn = new SqlConnection("Data Source=112SALAS31;Initial Catalog=Login;Persist Security Info=True;User ID=sa;Password=sqladmin");
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

    }
}

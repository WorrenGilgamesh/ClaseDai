using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Aspirantes
{
    class Connection
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;

        public static SqlConnection Connect()
        {
            SqlConnection cnn;
            cnn = new SqlConnection("Data Source=112SALAS13;Initial Catalog=SistemaAspirantes;Persist Security Info=True;User ID=sa;Password=sqladmin");
            cnn.Open();
            MessageBox.Show("Conexion Exitosa");
            return cnn;
        }

        public void llenarComboProgramas(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("SELECT Carreras.Programa FROM Carreras", Connect());
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cb.Items.Add(dr["Programa"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show(e.Message);
            }
        }
        
    }
}

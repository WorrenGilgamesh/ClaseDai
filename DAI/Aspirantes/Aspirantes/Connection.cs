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
            //Data Source=WORRENGILGAMESH;Initial Catalog=SistemaAspirantes;Integrated Security=True
            //Data Source=112SALAS12;Initial Catalog=SistemaAspirantes;Persist Security Info=True;User ID=sa;Password=sqladmin
            cnn = new SqlConnection("Data Source=WORRENGILGAMESH;Initial Catalog=SistemaAspirantes;Integrated Security=True");
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

        public int agregaAspirante(Aspirante a)
        {
            try
            {
                return Aspirante.agregarAspirante(a);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show(e.Message);
                return -1;
            }
        }

        public void llenarComboAspirante(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("SELECT aspirante.Nombre FROM aspirante", Connect());
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cb.Items.Add(dr["Nombre"].ToString());
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

        public int eliminaAspirante(Aspirante a)
        {
            try
            {
                return Aspirante.eliminaAspirante(a);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show(e.Message);
                return -1;
            }
        }

        public void rellenarDatos(ComboBox cb, TextBox tb, RadioButton rb1, RadioButton rb2, RadioButton rb3, ComboBox cb2)
        {
                String user = cb.SelectedValue.ToString();
                if (user != "")
                {
                    String query = "SELECT aspirante.correo, aspirante.grado, Carreras.Programa FROM aspirante INNER JOIN Carreras ON Carreras.idPrograma = aspirante.idPrograma WHERE aspirante.nombre ='" + user + "'";
                    cmd = new SqlCommand(query, Connect());
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        tb.Text = dr["Correo"].ToString();
                        switch (dr["Grado"].ToString())
                        {
                            case "4":
                                rb1.IsChecked = true;
                                break;
                            case "5":
                                rb2.IsChecked = true;
                                break;
                            case "6":
                                rb3.IsChecked = true;
                                break;
                        }
                        cb2.SelectedValue = dr["Programa"];
                    }
                }
            Connect().Close();
        }

        public void modificacion(ComboBox cb, TextBox tb, ComboBox cb2, RadioButton rb1, RadioButton rb2)
        {
            if (cb.HasItems && cb.SelectedItem.ToString() != "" && tb.Text != "" && cb2.SelectedValue.ToString() != "")
            {
                String user = cb.SelectedValue.ToString();
                String gradoStr = rb1.IsChecked == true ? "4" : rb2.IsChecked == true ? "5" : "6";
                int prog = 0;
                switch (cb2.SelectedItem.ToString().Trim())
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
                String query = "UPDATE aspirante SET aspirante.Correo = '" + tb.Text + "',aspirante.idPrograma = '" + prog + "',aspirante.Grado = '" + gradoStr + "' WHERE aspirante.Nombre ='" + user + "'";
                SqlCommand cmd = new SqlCommand(query, Connect());
                int res = cmd.ExecuteNonQuery();
                if (res > 0) MessageBox.Show("Modificacion correcta"); else MessageBox.Show("No se pudo dar la modificacion");
            }
            else
            {
                MessageBox.Show("Faltan los campos por rellenar");
            }
            Connect().Close();
        }

        public void llenaGrid(DataGrid dtGrd, ComboBox cb)
        {
            try
            {
                String prog = cb.SelectedItem.ToString();
                String query;
                if (prog != "Todos")
                {                    
                    query = "SELECT aspirante.Nombre, aspirante.Sexo, aspirante.Fecha, aspirante.correo,aspirante.grado FROM aspirante INNER JOIN Carreras ON Carreras.idPrograma = aspirante.idPrograma WHERE Carreras.Programa = '" + prog + "'";
                }
                else
                {
                    query = "SELECT * FROM aspirante;";
                }
                SqlCommand cmd = new SqlCommand(query, Connect());
                SqlDataReader dr = cmd.ExecuteReader();
                dtGrd.ItemsSource = dr;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show(e.Message);
            }
        }

    }
}

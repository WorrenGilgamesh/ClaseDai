using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspirantes
{
    class Usuario
    {
        public String usuario { get; set; }
        public String Contraseña { get; set; }

        public Usuario(string usuario, string Contraseña)
        {
            this.usuario = usuario;
            this.Contraseña = Contraseña;
        }

        public static int BuscaUsuario(Usuario u)
        {
            SqlConnection cnn;
            cnn = Connection.Connect();
            SqlCommand cmd = new SqlCommand(String.Format("SELECT * FROM Sesion WHERE usuario='{0}' AND Contraseña = '{1}' ",u.usuario,u.Contraseña), cnn);
            int res = cmd.ExecuteNonQuery();
            cnn.Close();
            return res;
        }

    }
}

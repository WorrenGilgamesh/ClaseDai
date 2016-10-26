using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspirantes
{
    class Aspirante
    {
        public int grado { get; set; }
        public int ingenieria { get; set; }
        public String fechaNac { get; set; }
        public String nombre { get; set; }
        public String sexo { get; set; }
        public String correo { get; set; }

        public Aspirante(String nombre, String sexo, String fechaNac, String correo, int grado, int ingenieria)
        {
            this.nombre = nombre;
            this.fechaNac = fechaNac;
            this.sexo = sexo;
            this.correo = correo;
            this.grado = grado;
            this.ingenieria = ingenieria;
        }

        public String convierteFecha()
        {
            String aux = fechaNac;
            String año = aux.Substring(6, 4);
            String dia = aux.Substring(0, 2);
            String mes = aux.Substring(3, 2);
            aux = año + "-" + mes + "-" + dia;
            return aux;
        }

        public static int agregarAspirante(Aspirante a)
        {
            SqlConnection cnn;
            cnn = Connection.Connect();
            SqlCommand cmd = new SqlCommand(String.Format("INSERT INTO aspirante2(Nombre,Sexo,Fecha,Correo,Grado,Programa) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", a.nombre, a.sexo, a.convierteFecha(), a.correo, a.grado, a.ingenieria), cnn);
            int res = cmd.ExecuteNonQuery();
            cnn.Close();
            return res;
        }

        public static int eliminaAspirante(Aspirante a)
        {
            SqlConnection cnn;
            cnn = Connection.Connect();
            SqlCommand cmd = new SqlCommand(String.Format("DELETE FROM aspirante WHERE aspirante.nombre = '{0}'", a.nombre), cnn);
            int res = cmd.ExecuteNonQuery();
            cnn.Close();
            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MySql
{
    public class ConectorBD
    {
        public MySqlConnection con;
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public ConectorBD()
        {
            con = new MySqlConnection("server=localhost; database=zonafranca; uid=root; password=068856187030");
        }

        public void Conectar()
        {
            con.Open();
        }

        public void Desconectar()
        {
            con.Close();
        }

        public bool VerificarExistencia(string tabla, string columna, string id)
        {
            bool existencia = false;
            Conectar();
            string query = String.Format("SELECT {0} FROM {1} WHERE {0}=?id", columna, tabla);
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.Add("?id", MySqlDbType.VarChar).Value = id;
            var resultado = cmd.ExecuteScalar();
            if((resultado!=null) && (id == Convert.ToString(resultado)))
            {
                existencia = true;
                Desconectar();
                return existencia;
            }
            else
            {
                Desconectar();
                return existencia;
            }
        }
    }
}

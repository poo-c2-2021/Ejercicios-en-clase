using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MensajesEntidades
{
    public class DB
    {
        private string connstr;

        public DB(string connstr)
        {
            this.connstr = connstr;
        }

        public List<Usuario> RetornarUsuarios()
        {
            string consulta = "select id, usuario,  nombre from usuarios";
            List<Usuario> usuarios = new List<Usuario>();
            //establece la conexion
            SqlConnection cn = new SqlConnection(this.connstr);
            //establece la consulta
            SqlCommand cm = new SqlCommand(consulta, cn);
            try
            {
                //abre la conexion
                cn.Open();
                //ejecuta la consulta
                SqlDataReader sqlDataReader =  cm.ExecuteReader();
                //recorro las filas que retorna la consulta
                while(sqlDataReader.Read())
                {
                    Usuario user = new Usuario();
                    //por cada fila verifico las celdas, por indice de columna o por no nombre de las mismas
                    user.Id =  (int)(decimal)sqlDataReader[0];
                    user.NombreUsuario =  sqlDataReader[1].ToString();
                    user.Nombre =  sqlDataReader["Nombre"].ToString();
                    
                    usuarios.Add(user);
                }

                return usuarios;
            }
            finally
            {
                cn.Close();

            }

        }

        internal Usuario LoguearUsuarios(Usuario usuario)
        {
            Usuario salida = null;

            string consulta = $"Select * from usuarios where usuario = @usuario and pass = @password";
            
            

            SqlConnection connection = new SqlConnection(this.connstr);
            SqlCommand command = new SqlCommand(consulta, connection);
            
            command.Parameters.Add(new SqlParameter("@usuario", usuario.NombreUsuario));
            command.Parameters.Add(new SqlParameter("@password", procesarPass(usuario.Pass)));

            try
            {
                connection.Open();

                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    salida = new Usuario();
                    salida.Id = (int)(decimal)dr["id"];
                    salida.Nombre = dr["nombre"].ToString();                    
                    salida.NombreUsuario = dr["usuario"].ToString();

                }
                return salida;
            }
            finally
            {
                connection.Close();
            }


        }

        public static string procesarPass(string pass)
        {
            pass = "~uT3" + pass + "\"@!/";
            pass =  MD5Hash(pass);

            return pass.Substring(1, 8);
        }

        public static string MD5Hash(string input)
        {
            using (var md5 = MD5.Create())
            {
                var result = md5.ComputeHash(Encoding.ASCII.GetBytes(input));
                var strResult = BitConverter.ToString(result);
                return strResult.Replace("-", "");
            }
        }
        public int CrearUsuario(Usuario usuario)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = this.connstr;
            SqlCommand sqlCommand = new SqlCommand();
            


            sqlCommand.CommandText = $"insert into usuarios (usuario, pass, nombre) values ('{usuario.NombreUsuario}', '{procesarPass(usuario.Pass)}', '{usuario.Nombre}' )";
            sqlCommand.Connection = sqlConnection;

            try
            {
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                sqlConnection.Close();
            }


        }


    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
            string consulta = "select id, usuario, pass, Nombre from usuarios";
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
                    user.Pass =  sqlDataReader[2].ToString();
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

        public int CrearUsuario(Usuario usuario)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = this.connstr;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = $"insert into usuarios (usuario, pass, nombre) values ('{usuario.NombreUsuario}', '{usuario.Pass}', '{usuario.Nombre}' )";
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

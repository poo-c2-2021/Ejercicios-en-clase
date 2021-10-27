using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajesEntidades
{
    public class Mensajeria
    {
        static List<Usuario> usuarios;
        public static Usuario usuarioLogueado;


        public static bool TieneUsuario()
        {
            return !(Mensajeria.usuarioLogueado is null);
        }

        public static void Loguear(Usuario usuario)
        {
            DB miBase = new DB("Data Source=190.210.161.90;Integrated Security=false;User ID=alumno;Password=alumno;Initial Catalog=UTN");
            Mensajeria.usuarioLogueado = miBase.LoguearUsuarios(usuario);            
        }

        public static bool BuscarUSuarios()
        {
            DB miBase = new DB("Data Source=190.210.161.90;Integrated Security=false;User ID=alumno;Password=alumno;Initial Catalog=UTN");
            Mensajeria.usuarios =  miBase.RetornarUsuarios();
            return true;

        }

        public static bool InsertarUsuario(Usuario nuevoUSuario)
        {
            DB miBase = new DB("Data Source=190.210.161.90;Integrated Security=false;User ID=alumno;Password=alumno;Initial Catalog=UTN");
            return  miBase.CrearUsuario(nuevoUSuario) == 1;
            
        }

    }
}

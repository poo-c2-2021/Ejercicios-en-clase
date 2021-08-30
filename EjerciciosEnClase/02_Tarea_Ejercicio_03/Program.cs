using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_T_Ej_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Eze", 150000);

            cuenta1.Mostrar();
            cuenta1.Ingresar(600);
            cuenta1.Mostrar();
            cuenta1.Retirar(300);
            cuenta1.Mostrar();
            Console.ReadKey();

        }
    }
}

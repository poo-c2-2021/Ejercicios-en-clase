using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeritoString;
            int num1 = 2;
            int num2 = 5;
            int resultado;

            Console.WriteLine("Ingrese un numero");

            numeritoString = Console.ReadLine();

            while (!int.TryParse(numeritoString, out num1))
            {
                Console.WriteLine("ERROR,Ingrese un numero");
                numeritoString = Console.ReadLine();
            }

            Console.WriteLine("Ingrese otro numero");

            while (!int.TryParse(Console.ReadLine(), out num2))
                Console.WriteLine("ERROR,Ingrese un numero");

            resultado = num1 + num2;

            Console.WriteLine($"El resultado es {resultado}");


        }
    }
}

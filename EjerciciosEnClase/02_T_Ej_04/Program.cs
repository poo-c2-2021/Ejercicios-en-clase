using System;

namespace _02_T_Ej_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Conductor conductor1 = new Conductor("Lucas", new int[] { 200, 599, 899, 0, 256, 0, 0});
            Conductor conductor2 = new Conductor("Eze", new int[] { 400, 500, 900, 100, 250, 0, 0});
            Conductor conductor3 = new Conductor("Juampi", new int[] { 100, 300, 860, 200, 260, 70, 800});

            Conductor auxiliar;

            if (conductor1.GetDia3() < conductor2.GetDia3())
            {
                if (conductor2.GetDia3() < conductor3.GetDia3())
                {
                    auxiliar = conductor3;
                }
                else
                {
                    auxiliar = conductor2;
                }
            }
            else 
            {

                if (conductor1.GetDia3() < conductor3.GetDia3())
                {
                    auxiliar = conductor3;
                }
                else
                {
                    auxiliar = conductor1;
                }
            }

            Console.WriteLine($"El que manejó más el día 3: {auxiliar.MostrarNombre()}");

        }
    }
}

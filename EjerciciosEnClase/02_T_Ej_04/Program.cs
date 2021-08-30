using System;

namespace _02_T_Ej_04
{
    class Program
    {

        #region forma 1 
        //int[] kmsAux = new int[7];

        //kmsAux[0] = 200;
        //kmsAux[1] = 200;
        //kmsAux[2] = 200;
        //kmsAux[3] = 200;
        //kmsAux[4] = 200;
        //kmsAux[5] = 200;
        //kmsAux[6] = 200;
        #endregion

        #region forma 2
        //int[] kmsAux = { 300, 44, 0, 0, 4, 5, 6 };

        #endregion

        static void Main(string[] args)
        {
            int[] kmsAux = new int[7]
                  {
                        300,400,55,66,1,2,5
                  };


            Empresa unaEmpresa = new Empresa("Transportes Juampi");


            Conductor c1 = new Conductor("PEPE", kmsAux);

            Conductor c2 = new Conductor("JUANA");











        }
    }
}

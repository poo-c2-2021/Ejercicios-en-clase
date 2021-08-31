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
            Conductor conductor1 = new Conductor("Lucas", new int[] { 200, 599, 899, 0, 256, 0, 0});
            Conductor conductor2 = new Conductor("Eze", new int[] { 400, 500, 900, 100, 250, 0, 0});
            Conductor conductor3 = new Conductor("Juampi", new int[] { 100, 300, 860, 200, 260, 70, 800});

            Empresa miEmpresa = new Empresa("Empresa Juampi");

            miEmpresa.AgregarConductor(conductor1);
            miEmpresa.AgregarConductor(conductor2);
            miEmpresa.AgregarConductor(conductor3);






        }
    }
}

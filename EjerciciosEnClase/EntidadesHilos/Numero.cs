using System;

namespace EntidadesHilos
{



    public class Numero
    {
        private static Random rnd;
        public event CaidoDelegate Caido;

        private int posY;
        private int posX;
        public static int limiteX;
        public static int limiteY;
        public int valor;

      
        static Numero()
        {
            rnd = new Random(DateTime.Now.Millisecond);
            
        }

        public Numero()
        {
            this.posX = rnd.Next(limiteX);
            this.posY = 0;
            valor = rnd.Next(9);
        }

     


        public int PosY
        {
            get { return posY; }

        }

        public int PosX
        {
            get { return posX; }

        }

        public int Valor { get {
                return this.valor;

            } }

        public void Caer()
        {

            this.posY++;
            if (this.posY == limiteY)
            {
                if (!(Caido is null))
                    Caido.Invoke();
            }

        }

    }
}

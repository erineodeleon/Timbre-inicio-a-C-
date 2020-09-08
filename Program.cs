using System;

namespace CoreEscuela
{
    class Escuela
    {
        public string nombre;
        public string direccion;
        public int añoFundacion;

        public string ceo ;

        public void Timbrar()
        {
            //Todo
            Console.Beep(2000,3000);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var miEcsula = new Escuela();
            miEcsula.nombre = "Platzi Academy";
            miEcsula.direccion = "Cr 9 calle 72";
            miEcsula.añoFundacion =  2012 ;
            Console.WriteLine("Timbre");
            miEcsula.Timbrar();
            
            //Console.WriteLine("Hello World!");
        }
    }
}

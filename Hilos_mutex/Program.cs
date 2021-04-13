using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Hilos_mutex
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones objop = new Operaciones(5, 7);
            //creacion de hilos
            Thread H1 = new Thread(new ThreadStart(objop.Sumar));
            H1.Name = string.Format("Hilo 1");

            Thread H2 = new Thread(new ThreadStart(objop.Restar));
            H2.Name = string.Format("Hilo 2");

            Thread H3 = new Thread(new ThreadStart(objop.Multiplicar));
            H3.Name = string.Format("Hilo 3");


            //inicio de ejecucion de cada hilo

            H1.Start() ;
            H2.Start();
            H3.Start();




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Hilos_mutex
{

    class Operaciones
    {
         private int v1, v2, resultado;
         private static Mutex mut = new Mutex();

    public Operaciones(int valor1, int valor2)
        {

            v1 = valor1;
            v2 = valor2;

        }

        public void Sumar()
        {
            mut.WaitOne();
            Console.WriteLine("{0} Ingresando Codigo Protegido",Thread.CurrentThread.Name);
            resultado = v1 + v2;
            Thread.Sleep(1000);
            Console.WriteLine("El resultado de la suma es: "+ resultado);
            Console.WriteLine("{0} Saliendo de codigo protegido",Thread.CurrentThread.Name);
            Console.WriteLine(" ");
            mut.ReleaseMutex();

        }

        public void Restar()
        {

            mut.WaitOne();
            Console.WriteLine("{0} Ingresando Codigo Protegido", Thread.CurrentThread.Name);
            resultado = v1 - v2;
            Thread.Sleep(1000);
            Console.WriteLine("El resultado de la resta es: " + resultado);
            Console.WriteLine("{0} Saliendo de codigo protegido", Thread.CurrentThread.Name);
            Console.WriteLine(" ");
            mut.ReleaseMutex();

        }


        public void Multiplicar()
        {

            mut.WaitOne();
            Console.WriteLine("{0} Ingresando Codigo Protegido", Thread.CurrentThread.Name);
            resultado = v1 * v2;
            Thread.Sleep(1000);
            Console.WriteLine("El resultado de la multiplicacion es: " + resultado);
            Console.WriteLine("{0} Saliendo de codigo protegido", Thread.CurrentThread.Name);
            Console.WriteLine(" ");

           mut.ReleaseMutex();

        }




    }
}

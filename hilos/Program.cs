using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hilos
{
    class Program
    {
        static void metodo()
        {
            String texto = Thread.CurrentThread.Name;
            Console.WriteLine(texto);
            Thread.Sleep(3000);
            for (int x = 0; x <= 1000; x++)
            {
                Console.Write('x');
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(metodo));
            t.Name = "hilo1";
            t.Start();
            for (int x = 0; x <= 1000; x++)
            {
                Console.Write('y');
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[4];
            Boolean pasa = true;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese el digito {0}: ", i+1);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    if (numeros[i] == numeros[i+1] || numeros[i] == numeros[i + 2] || numeros[i] == numeros[i + 3])
                    {
                        pasa = false;
                    }
                }
                if (i == 1 && pasa == true)
                {
                    if (numeros[i] == numeros[i - 1] || numeros[i] == numeros[i + 1] || numeros[i] == numeros[i + 2])
                    {
                        pasa = false;
                    }
                }
                if(i == 2 && pasa == true)
                {

                    if (numeros[i] == numeros[i-2] || numeros[i] == numeros[i-1] || numeros[i] == numeros[i + 1])
                    {
                        pasa = false;
                    }
                }
                if(i == 3 && pasa == true)
                {
                    if (numeros[i] == numeros[i-3] || numeros[i] == numeros[i-2] || numeros[i] == numeros[i-1])
                    {
                        pasa = false;
                    }
                }
               
            }
            for (int i = 0; i < 4; i++)
            {
                if(numeros[i] == i+1)
                {
                    pasa = false;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (i == 0 || i == 1 || i == 2)
                {
                    if (numeros[i] == numeros[i + 1])
                    {
                        pasa = false;
                    }
                }
                else
                {
                    if (numeros[i] % 2 == 1)
                    {
                        pasa = false;
                    }
                }
            }
            if (pasa == true)
            {
                Console.WriteLine("Correcto");
            }
            else
            {
                Console.WriteLine("Incorrecto");
            }
            Console.ReadKey();
        }
    }
}

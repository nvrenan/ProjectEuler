using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosVeica
{
    public class EvenFibonaccinumbers
    {
         /*List<int> listaNumeros = new List<int>();}
        listaNumeros.Add(1);
        listaNumeros.Add(2);
        var total = 3;
        while (listaNumeros[listaNumeros.Count - 1] < 4000000)
        {
            listaNumeros.Add(listaNumeros[listaNumeros.Count - 2] + listaNumeros[listaNumeros.Count - 1]);
            total += listaNumeros[listaNumeros.Count-1];
        }
        total -= listaNumeros[listaNumeros.Count - 1];
        Console.WriteLine(total);*/

        public long executar()
        {
            long fib1 = 1;
            long fib2 = 1;
            long result = 0;
            long summed = 0;

            while (result < 4000000)
            {
                if ((result%2) == 0)
                {
                    summed += result;
                }

                result = fib1 + fib2;
                fib2 = fib1;
                fib1 = result;
            }
            return summed;
        }

        /*
        Console.WriteLine(summed);
            

        public long executar()
        {
            long[] fib = { 2, 0 };
            int i = 0;
            long summed = 0;

            while (fib[i] < 4000000)
            {
                summed += fib[i];
                i = (i + 1) % 2;
                fib[i] = 4 * fib[(i + 1) % 2] + fib[i];
            }
            return summed;
        }*/
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosVeica
{
    class Program
    {
        static void Main(string[] args)
        {
            Largestprimefactor largestprimefactor = new Largestprimefactor();
            Console.WriteLine(largestprimefactor.executar());
            Console.ReadKey();
        }
    }
}

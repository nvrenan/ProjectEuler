using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosVeica
{
    public class Multiplesof3and5
    {
        public int executar()
        {
            var total = 0;
            for (int i = 0; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    total += i;
                }
            }
            return total;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosBasicos
{
    public class AluguelCarro
    {
        public static double Aluguel(int diasAluguel, double kmFinal, double kmInicial)
        {
            return Math.Round((95 * diasAluguel) + ((kmFinal - kmInicial) * 0.35), 2);
        }
    }
}

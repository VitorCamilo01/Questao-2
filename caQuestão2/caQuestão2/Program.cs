using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestão2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumComplexo z1 = new NumComplexo(1, 1);
            NumComplexo z2 = new NumComplexo(3, -1);

            NumComplexo z3 = z1.soma(z2);
            z3.imprimeFormaPolar();

            NumComplexo z4 = z1.vezes(z2);
            z4.imprimeFormaPolar();

            Console.ReadLine();
        }
    }
}

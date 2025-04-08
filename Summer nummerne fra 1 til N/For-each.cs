using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer_nummerne_fra_1_til_N
{
    public class ForEachSum : ISumBeregn
    {
        public int Beregn(int input)
        {
            int sum = 0;
            int totalSum = 0;
            int predefinedNum = 1;

            var talListe = Enumerable.Range(1, input); // liste fra 1 til input

            foreach (var _ in talListe)
            {
                sum += predefinedNum;
                totalSum += sum;
                Console.WriteLine($"[FOREACH] Summen er {sum}");
            }

            return totalSum;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer_nummerne_fra_1_til_N
{
    public class While : ISumBeregn
    {
        public int Beregn(int input) 
        {
            int predefinedNum = 1;
            int sum = 0;
            int totalSum = 0;

            while (input > 0)
            {
                sum += predefinedNum;
                totalSum += sum;
                input--;
                Console.WriteLine($"Summen af det indtastede tal og det prædefinerede tal 1 er {sum}");
            }

            return totalSum;
        }
    }
}

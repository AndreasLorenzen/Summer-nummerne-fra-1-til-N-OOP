using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer_nummerne_fra_1_til_N
{
    public class Matematiske_udregning : ISumBeregn
    {
        public int Beregn(int input)
        {
            int sum = 0;
            int totalSum = 0;
            int predefinedNum = 1;

            totalSum = input * (input + predefinedNum) / 2;



            return totalSum;
        }
    }
}

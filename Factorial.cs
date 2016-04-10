using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZopperPerm
{
    public partial class CalculatePermutations 
    {
        //Maximum factorial using ulong
        //Going above 20 is pointless
        private const int maxF = 20;

        //Precomputed factorials, up to maxF
        private List<ulong> facts = new List<ulong>() { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880, 3628800, 39916800, 479001600, 6227020800, 87178291200, 1307674368000, 20922789888000, 355687428096000, 6402373705728000, 121645100408832000, 2432902008176640000 };

        //Calculate factorial
        private ulong factorial(int n)
        {
            return facts[n];
        }
    }
}

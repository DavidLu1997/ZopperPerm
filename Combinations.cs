using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace ZopperPerm
{
    public partial class CalculatePermutations
    {
        //Get number of output lines for combinations
        public ulong numComb(int k)
        {
            if (str.Length == 0)
                return 0;

            //As combinations are actually really small
            //Several order of magnitudes smaller
            //And finding out how to deal with repetitions is hard
            //We just calculate it
            comb(k);
            return (ulong)l.Count(); ;
        }



        //Find Combinations of length k
        public void comb(int k)
        {
            //Immediately exit if k invalid
            if (k > str.Length || k == 0)
            {
                return;
            }

            //Initialize output
            initOutput(k);

            //Recursive call
            recursiveComb(str, 0, 0, str.Length - 1, k);

            //Finish
            finishOutput();
        }

        //Recursive version of combinations
        private void recursiveComb(string s, int id, int st, int en, int k)
        {
            //If finished, output
            if (id == k)
            {
                processOutput(s.Substring(0, k));
                Debug.WriteLine(s.Substring(0, k));
            }

            //Otherwise recurse through all possibilities
            else
            {
                char[] temp;
                //Run through all cases
                for (int i = st; i <= en && en - i + 1 >= k - id; i++)
                {
                    temp = s.ToCharArray();
                    temp[id] = str.ElementAt(i);
                    temp[i] = str.ElementAt(id);

                    //Call recursively
                    recursiveComb(new string(temp), id + 1, st + 1, en, k);
                }
            }
        }
    }
}

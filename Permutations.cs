using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace ZopperPerm
{
    public partial class CalculatePermutations
    {
        //Get number of output lines for permutations
        public ulong numPerm(int k)
        {
            if (str.Length == 0)
                return 0;

            //Get raw number
            ulong num = factorial(str.Length) / factorial(str.Length - k);

            //Get repeats
            foreach (char v in str.ToList().Distinct())
            {
                num /= (ulong)str.ToList().Count(val => val == v);
            }

            return num;
        }

        //Find permutations of length k
        public void perm(int k)
        {
            //Immediately exit if k invalid
            if (k > str.Length || k == 0)
            {
                return;
            }

            //Initialize output
            initOutput(k);

            //Recursive call
            recursivePerm("", str, k);

            //Finish
            finishOutput();
        }

        //Find permutations, recursive
        private void recursivePerm(string cur, string next, int k)
        {
            //If done, return
            if (cur.Length == k)
            {
                processOutput(cur);
                //Debug.WriteLine(cur);
            }

            //Otherwise keep going
            else
            {
                for (int i = 0; i < next.Length; i++)
                {
                    recursivePerm(cur + next.ElementAt(i), next.Substring(0, i) + next.Substring(i + 1), k);
                    //Thread t = new Thread(() => recursivePerm(cur + next.ElementAt(i), next.Substring(0, i) + next.Substring(i + 1), k));
                    //t.Start();
                }
            }
        }
    }
}

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
        //Iterative solution
        public void perm(int k)
        {
            //Immediately exit if k invalid
            if (k > str.Length || k == 0)
            {
                return;
            }

            //Get all combinations (n choose k)
            string temp = filename;
            setStreamWriter("");
            comb(k);
            List<string> s = l;
            setStreamWriter(temp);
            initOutput(k);

            //Generate all permutations for each combination
            //Using Heap's Algorithm
            for (int i = 0; i < s.Count; i++)
            {
                List<int> q = new List<int>(new int[k]);
                char[] n = s[i].ToCharArray();

                for (int j = 0; j < q.Count; j++)
                {
                    q[j] = 0;
                }

                //Add current
                processOutput(s[i]);

                //Start index and jndex
                int idx = 1;
                int jdx = 0;
                char tmp;
                while (idx < k)
                {
                    if (q[idx] < idx)
                    {
                        jdx = idx % 2 * q[idx];
                        tmp = n[jdx];
                        n[jdx] = n[idx];
                        n[idx] = tmp;
                        processOutput(new string(n));
                        q[idx]++;
                        idx = 1;
                    }
                    else
                    {
                        q[idx] = 0;
                        idx++;
                    }
                }
            }

            finishOutput();
        }

        //Find permutations, recursive
        public void recursivePerm(string cur, string next, int k)
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
                }
            }
        }
    }
}

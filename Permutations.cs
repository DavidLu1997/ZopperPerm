using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        public List<string> perm(int k, string filename = "", bool progress = false)
        {
            //Immediately exit if k invalid
            if (k > str.Length || k == 0)
            {
                return null;
            }

            //Create list
            List<string> l = new List<string>();


            //Create streamWriter
            StreamWriter w = null;
            if (filename != "")
            {
                w = new StreamWriter(filename);
            }

            //Get all combinations (n choose k)
            List<string> s = comb(k);

            //Set progressBar
            if (progress)
            {
                p.Maximum = (int)(factorial(str.Length) / factorial(str.Length - k)) + 50;
                p.Minimum = 0;
                p.Value = 0;
            }

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
                if (w != null)
                {
                    w.WriteLine(s[i]);
                }
                else
                {
                    l.Add(s[i]);
                }
                if (progress)
                {
                    p.Value++;
                }

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
                        if (w != null)
                        {
                            w.WriteLine(new string(n));
                        }
                        else
                        {
                            l.Add(new string(n));
                        }
                        if (progress)
                        {
                            p.Value++;
                        }
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

            //Sort
            l = l.Distinct().ToList();
            l.Sort();

            if (progress)
            {
                p.Value = 0;
            }
            //Close and return
            if (w != null)
            {
                w.Close();
            }
            return l;
        }
    }
}

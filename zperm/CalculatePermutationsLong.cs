using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zperm
{
    public class CalculatePermutationsLong
    {
        //String to permute
        private string str;

        //Maximum factorial using ulong
        private const int maxF = 20;

        //Number of total permutations, n!
        //Only computed once
        private ulong nF;

        //k!
        //Only computed once
        private ulong kF;

        //(n-k)!
        //Only computed once
        private ulong nkF;

        //Precomputed factorials, up to maxF
        private List<ulong> facts = new List<ulong>() { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880, 3628800, 39916800, 479001600, 6227020800, 87178291200, 1307674368000, 20922789888000, 355687428096000, 6402373705728000, 121645100408832000, 2432902008176640000};

        //Calculate factorial
        private ulong factorial(int n)
        {
            //If precomputed
            if(n < facts.Count) 
            {
                return facts[n];
            }

            //Otherwise return 0, signal to use BigInteger
            return 0;
        }

        //Constructor, string
        CalculatePermutationsLong(string s)
        {
            this.str = s;
            if (s.Length < facts.Count)
            {
                nF = facts[s.Length];
            }
        }

        //Constructor, empty
        CalculatePermutationsLong()
        {
            this.str = "";
            if (this.str.Length < facts.Count)
            {
                nF = facts[str.Length];
            }
        }

        //Set string
        public void setString(string s)
        {
            this.str = s;
        }

        //Find permutations of length k
        public List<string> perm(int k, int max = 10000)
        {
            //Immediately exit if k invalid
            if (k > str.Length || k == 0)
            {
                return null;
            }

            //Create list
            List<string> l = new List<string>();

            //Calculate kF
            if (k < facts.Count)
            {
                kF = facts[k];
            }

            //Using Heap's Algorithm
            //TODO: General implementation to come
            if (k == str.Length)
            {
                List<int> p = new List<int>(new int[k]);
                char[] n = str.ToCharArray();

                for(int i = 0; i < p.Count; i++) {
                    p[i] = 0;
                }

                //Add initial string
                l.Add(str);

                //Start index and jndex
                int idx = 1;
                int jdx = 0;
                char tmp;
                while (idx < k)
                {
                    if (p[idx] < idx)
                    {
                        jdx = idx % 2 * p[idx];
                        tmp = n[jdx];
                        n[jdx] = n[idx];
                        n[idx] = tmp;
                        l.Add(n.ToString());
                        p[idx]++;
                        idx = 1;
                    }
                    else
                    {
                        p[idx] = 0;
                        idx++;
                    }
                }
            }

            return l;
        }

        //Find Combinations of length k
        public List<string> comb(int k, uint max = 10000)
        {
            //Immediately exit if k invalid
            if (k > str.Length || k == 0)
            {
                return null;
            }

            //Create list
            List<string> l = new List<string>();

            //Find kF
            if (k < facts.Count)
            {
                kF = facts[k];
            }

            //Find nkF
            if ((str.Length - k) < facts.Count)
            {
                nkF = facts[str.Length - k];
            }

            //TODO: Code here
            //Low priority

            return l;
        }
    }

    
}

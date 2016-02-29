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
        }

        //Constructor, empty
        CalculatePermutationsLong()
        {
            this.str = "";
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

            //Get all combinations (n choose k)
            List<string> s = comb(k);

            //Generate all permutations for each combination
            //Using Heap's Algorithm
            for (int i = 0; i < s.Count; i++) 
            {
                List<int> p = new List<int>(new int[k]);
                char[] n = s[i].ToCharArray();

                for (int j = 0; j < p.Count; j++)
                {
                    p[j] = 0;
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
        public List<string> comb(int k)
        {
            //Immediately exit if k invalid
            if (k > str.Length || k == 0)
            {
                return null;
            }

            //Create list
            List<string> l = new List<string>();

            //Convert to char array
            char[] inp = str.ToCharArray();

            //Temp string
            string temp;

            //Stacks
            Stack<string> s = new Stack<string>();
            Stack<int> start = new Stack<int>();
            Stack<int> end = new Stack<int>();
            Stack<int> index = new Stack<int>();

            //Initialization
            s.Push(str);
            start.Push(0);
            end.Push(str.Length - 1);
            index.Push(0);

            return l;
        }

    }

    
}

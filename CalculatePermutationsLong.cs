using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZopperPerm
{
    public class CalculatePermutationsLong
    {
        //String to permute
        private string str;

        //Maximum factorial using ulong
        private const int maxF = 20;

        //Precomputed factorials, up to maxF
        private List<ulong> facts = new List<ulong>() { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880, 3628800, 39916800, 479001600, 6227020800, 87178291200, 1307674368000, 20922789888000, 355687428096000, 6402373705728000, 121645100408832000, 2432902008176640000};

        //ProgressBar
        System.Windows.Forms.ProgressBar p;

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
        public CalculatePermutationsLong(string s)
        {
            this.str = s;
        }

        //Constructor, empty
        public CalculatePermutationsLong()
        {
            this.str = "";
        }

        //Set string
        public void setString(string s)
        {
            this.str = s;
        }

        //Set progress bar
        public void setProgressBar(System.Windows.Forms.ProgressBar p)
        {
            this.p = p;
        }

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

        //Get number of output lines for combinations
        public ulong numComb(int k)
        {
            if (str.Length == 0)
                return 0;

            //As combinations are actually really small
            //Several order of magnitudes smaller
            //And finding out how to deal with repetitions is hard
            //We just calculate it

            return (ulong)comb(k).Count();
        }

        //Find permutations of length k
        public List<string> perm(int k, bool progress = false)
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

            //Set progressBar
            if (progress)
            {
                p.Maximum = (int)numPerm(k) + 50;
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
                l.Add(s[i]);
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
                        l.Add(new string(n));
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

            return l;
        }

        //Find Combinations of length k
        public List<string> comb(int k, bool progress = false)
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

            //Temp char array
            char[] tempA;

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

            //Set progressBar
            if (progress)
            {
                p.Maximum = (int)(factorial(str.Length) / (factorial(k) * factorial(str.Length - k))) + 50;
                p.Minimum = 0;
                p.Value = 0;
            }

            int st, en, idx;

            //While we still have more things to do
            while (s.Count != 0)
            {
                if (index.First() == k)
                {
                    l.Add(s.First().Substring(0, k));
                    if (progress)
                    {
                        p.Value++;
                    }
                    index.Pop();
                    s.Pop();
                    start.Pop();
                    end.Pop();
                }

                else
                {
                    //Pop
                    st = start.First();
                    start.Pop();
                    en = end.First();
                    end.Pop();
                    idx = index.First();
                    index.Pop();
                    temp = s.First();
                    s.Pop();
                    for (int i = st; i <= en && en - i + 1 >= k - idx; i++)
                    {
                        //Change character
                        tempA = temp.ToCharArray();
                        tempA[idx] = inp[i];

                        //Push
                        s.Push(new string(tempA));
                        start.Push(i + 1);
                        end.Push(en);
                        index.Push(idx + 1);
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
            return l;
        }

    }

    
}

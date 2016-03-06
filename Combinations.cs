﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

            return (ulong)comb(k).Count();
        }



        //Find Combinations of length k
        public List<string> comb(int k, string filename = "", bool progress = false)
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
                    if (w != null)
                    {
                        w.WriteLine(s.First().Substring(0, k));
                    }
                    else
                    {
                        l.Add(s.First().Substring(0, k));
                    }
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
                        if (w != null)
                        {
                            w.WriteLine(new string(tempA));
                        }
                        else
                        {
                            l.Add(new string(tempA));
                        }
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
            if (w != null)
            {
                w.Close();
            }
            return l;
        }
    }
}

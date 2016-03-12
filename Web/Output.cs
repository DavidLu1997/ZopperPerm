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
        //Initialize output
        private void initOutput(int k)
        {
            l = new List<string>();
        }

        //Process output to correct form
        private void processOutput(string s)
        {
            l.Add(s);
        }

        //Finalize output
        private void finishOutput()
        {
            l = l.Distinct().ToList();
            l.Sort();
        }

        //Get l
        public List<string> getOutput()
        {
            if (l != null)
                return l;
            else
                return null;
        }
    }
}

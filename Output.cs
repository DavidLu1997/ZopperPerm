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
            if (filename == "" || filename == null)
            {
                l = new List<string>();
            }
            else
            {
                writer = new StreamWriter(filename);
            }
        }

        //Process output to correct form
        private void processOutput(string s)
        {
            if (writer != null)
            {
                writer.WriteLine(s);
            }
            else
            {
                l.Add(s);
            }
        }

        //Finalize output
        private void finishOutput()
        {
            //Sort if writer is null
            if (writer == null)
            {
                l = l.Distinct().ToList();
                l.Sort();
            }
            //Close and return
            if (writer != null)
            {
                writer.Close();
                writer.Dispose();
                writer = null;
            }
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

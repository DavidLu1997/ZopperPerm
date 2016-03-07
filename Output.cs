using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZopperPerm
{
    public partial class CalculatePermutations
    {
        //Initialize output
        private void initOutput()
        {
            
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
            if (progress != null)
            {
                progress.Value++;
            }
        }

        //Finalize output
        private void finishOutput()
        {
            //Sort
            l = l.Distinct().ToList();
            l.Sort();

            //If progress bar
            if (progress != null)
            {
                progress.Value = 0;
            }
            //Close and return
            if (writer != null)
            {
                writer.Close();
            }
        }
    }
}

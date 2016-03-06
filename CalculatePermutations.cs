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
        //String to permute
        private string str;
        
        //ProgressBar
        System.Windows.Forms.ProgressBar p;

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
    }
}

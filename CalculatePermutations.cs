using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ZopperPerm
{
    public partial class CalculatePermutations
    {
        //String to permute
        private string str;
        
        //ProgressBar
        ProgressBar progress;

        //StreamWriter
        StreamWriter writer;

        //Set string
        public void setString(string s)
        {
            this.str = s;
        }

        //Set progress bar
        public void setProgressBar(System.Windows.Forms.ProgressBar p)
        {
            this.progress = p;
        }

        //Set StreamWriter
        public void setStreamWriter(string filename)
        {
            if (filename != "")
            {
                this.writer = new StreamWriter(filename);
            }
            else
            {
                this.writer = null;
            }
        }
    }
}

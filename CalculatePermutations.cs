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

        //StreamWriter
        StreamWriter writer;

        //File path
        string filename;

        //Output list
        List<string> l;

        //Set string
        public void setString(string s)
        {
            this.str = s;
        }

        //Set StreamWriter
        public void setStreamWriter(string filename)
        {
            this.filename = filename;
        }
    }
}

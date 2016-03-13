using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZopperPerm
{
    public partial class CalculatePermutations
    {
        //Singleton instance
        private static CalculatePermutations instance;

        //Constructor
        private CalculatePermutations()
        {
            this.str = "";
            writer = null;
            l = null;
        }

        //Get instance
        public static CalculatePermutations Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CalculatePermutations();
                }
                return instance;
            }
        }
    }
}

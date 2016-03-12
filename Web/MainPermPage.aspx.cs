using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZopperPerm;

namespace Web
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        //Total number of permutations
        protected ulong totalCount;

        //Maximum displayable lines
        //Currently 100 000
        protected const int maxDisplayed = 100000;

        //Permutations calculator
        protected CalculatePermutations c;

        protected void Page_Load(object sender, EventArgs e)
        {
            permutationButton.Checked = true;
            totalCount = 0;
            c = CalculatePermutations.Instance;
        }

        //Generates permutations/combinations
        protected void generateAction(object sender, EventArgs e)
        {
            //Return if wrong action
            if (sender != generateButton)
            {
                return;
            }

            //Return if invalid input
            if (stringToPermute.Text.Length == 0 || kValue.Text == "0")
            {
                mainOutput.Text = "";
                return;
            }

            //Clear display
            mainOutput.Text = "";

            //Otherwise create object to get permutations
            c.setString(stringToPermute.Text);
            if (permutationButton.Checked)
            {
                c.perm(Int32.Parse(kValue.Text));
            }
            else
            {
                c.comb(Int32.Parse(kValue.Text));
            }
            List<string> l = c.getOutput();
            foreach (string s in l)
            {
                mainOutput.Text += s + "\n";
            }
        }

        //Change k bounds
        protected void changeK(object sender, EventArgs e)
        {
            if (sender != stringToPermute)
            {
                return;
            }
            kValue.Text = stringToPermute.Text.Length.ToString();
            updateTotal();
        }

        //Update displayed total
        protected void updateTotal()
        {
            //Find Total number of output lines
            c.setString(stringToPermute.Text);
            if (permutationButton.Checked)
            {
                totalCount = c.numPerm(Int32.Parse(kValue.Text));
            }
            else
            {
                totalCount = c.numComb(Int32.Parse(kValue.Text));
            }
            total.Text = "Total: " + totalCount.ToString();
        }

        //Update total
        protected void changeKValue(object sender, EventArgs e)
        {
            updateTotal();
        }

        //Update total
        protected void updateRadioButtons(object sender, EventArgs e)
        {
            updateTotal();
        }

    }
}
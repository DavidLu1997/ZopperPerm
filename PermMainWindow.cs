using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZopperPerm
{
    public partial class PermMainWindow : Form
    {
        //Total number of permutations
        private ulong totalCount;

        //Maximum displayable lines
        //Currently 100 000
        private const int maxDisplayed = 100000;

        //Permutations calculator
        private CalculatePermutations c;
        public PermMainWindow()
        {
            InitializeComponent();
            permutationButton.Checked = true;
            progressBar.Visible = false;
            totalCount = 0;
            c = CalculatePermutations.Instance;
        }

        private void PermMainWindow_Load(object sender, EventArgs e)
        {

        }

        //Generates permutations/combinations
        private void generateAction(object sender, EventArgs e)
        {
            //Return if wrong action
            if (sender != generateButton)
            {
                return;
            }

            //Return if invalid input
            if (stringToPermute.Text.Length == 0 || kValue.Value == 0)
            {
                mainOutput.Clear();
                return;
            }

            //Otherwise create object to get permutations
            progressBar.Visible = true;
            c.setString(stringToPermute.Text);
            c.setProgressBar(progressBar);
            string filename = "";
            if (fileOutput.Checked)
            {
                filename = fileName.Text;
            }
            c.setStreamWriter(filename);
            if (permutationButton.Checked)
            {
                mainOutput.Lines = c.perm((int)kValue.Value).ToArray();
            }
            else
            {
                mainOutput.Lines = c.comb((int)kValue.Value).ToArray();
            }
            progressBar.Visible = false;
        }

        //Change k bounds
        private void changeK(object sender, EventArgs e)
        {
            if (sender != stringToPermute)
            {
                return;
            }

            kValue.Maximum = stringToPermute.Text.Length;
            kValue.Minimum = 0;
            kValue.Value = stringToPermute.Text.Length;

            //Mandatory file output if not displayable
            if (totalCount > maxDisplayed)
            {
                fileOutput.Checked = true;
                fileOutput.Enabled = false;
            }
            //Otherwise don't touch it, and enable it
            else
            {
                fileOutput.Enabled = true;
            }
            updateTotal();
        }

        //Update displayed total
        private void updateTotal()
        {
            //Find Total number of output lines
            c.setString(stringToPermute.Text);
            if (permutationButton.Checked)
            {
                total.Text = "Total: " + c.numPerm((int)kValue.Value).ToString();
            }
            else
            {
                total.Text = "Total: " + c.numComb((int)kValue.Value).ToString();
            }
        }

        //Enable file output
        private void fileOutput_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == fileOutput)
            {
                fileName.Visible= fileOutput.Checked;
            }
        }

        //Update total
        private void changeKValue(object sender, EventArgs e)
        {
            updateTotal();
        }

        //Update total
        private void updateRadioButtons(object sender, EventArgs e)
        {
            updateTotal();
        }
    }
}

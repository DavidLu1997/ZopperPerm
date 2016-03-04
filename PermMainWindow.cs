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
        public PermMainWindow()
        {
            InitializeComponent();
            permutationButton.Checked = true;
            progressBar.Visible = false;
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
            CalculatePermutationsLong c = new CalculatePermutationsLong(stringToPermute.Text);
            c.setProgressBar(progressBar);
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
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }
    }
}

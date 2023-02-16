using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taxBot
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            bool result = CheckInput(txtIncome.Text);

            if (result == true)
            {
                double income = double.Parse(txtIncome.Text);

                txtTaxedSingle.Text = TaxSingle(income).ToString();
                txtTaxedJoint.Text = TaxJoint(income).ToString();
                txtTaxedSeperate.Text = TaxSeperate(income).ToString();
                txtTaxedHOH.Text = TaxHOH(income).ToString();

                txtNetSingle.Text = (income - double.Parse(txtTaxedSingle.Text)).ToString();
                txtNetJoint.Text = (income - double.Parse(txtTaxedJoint.Text)).ToString();
                txtNetSeperate.Text = (income - double.Parse(txtTaxedSeperate.Text)).ToString();
                txtNetHOH.Text = (income - double.Parse(txtTaxedHOH.Text)).ToString();
            }
            


        }

        public static bool CheckInput(string input)
        {
            bool passableStatus = false;

            try
            {
                double test = double.Parse(input);
                passableStatus = true;
            }
            catch (Exception)
            {               
                MessageBox.Show("Please make sure you are only entering a number.\nLetters and neumerical abbreviations are not allowed.");
            }

            return passableStatus;
        }

        //----------------------------------------------------------------------------------------------------------------------------//

        public static double TaxSingle(double income)
        {
            double taxed = 0;

            if (income <= 9075)
            {
                taxed = income * .1;
            }
            else if (income <= 36900)
            {
                taxed = (income * .15) + 907.50;
            }
            else if (income <= 89350)
            {
                taxed = (income * .25) + 5081.25;
            }
            else if (income <= 186350)
            {
                taxed = (income * .28) + 18193.75;
            }
            else if (income <= 405100)
            {
                taxed = (income * .33) + 45353.75;
            }
            else if (income <= 406750)
            {
                taxed = (income * .35) + 117541.25;

            }
            else if (income > 406750)
            {
                taxed = (income * .396) + 118118.75;
            }

            return taxed;
        }

        //----------------------------------------------------------------------------------------------------------------------------//

        public static double TaxJoint(double income)
        {
            double taxed = 0;

            if (income <= 18150)
            {
                taxed = income * .1;
            }
            else if (income <= 73800)
            {
                taxed = (income * .15) + 1815;
            }
            else if (income <= 148850)
            {
                taxed = (income * .25) + 10162.50;
            }
            else if (income <= 226850)
            {
                taxed = (income * .28) + 28925;
            }
            else if (income <= 405100)
            {
                taxed = (income * .33) + 50765;
            }
            else if (income <= 457600)
            {
                taxed = (income * .35) + 109587.50;

            }
            else if (income > 457600)
            {
                taxed = (income * .396) + 127962.5;
            }

            return taxed;
        }

        //----------------------------------------------------------------------------------------------------------------------------//

        public static double TaxSeperate(double income)
        {
            double taxed = 0;

            if (income <= 9075)
            {
                taxed = income * .1;
            }
            else if (income <= 36900)
            {
                taxed = (income * .15) + 907.50;
            }
            else if (income <= 74425)
            {
                taxed = (income * .25) + 5081.25;
            }
            else if (income <= 113425)
            {
                taxed = (income * .28) + 14462.50;
            }
            else if (income <= 202550)
            {
                taxed = (income * .33) + 25382.50;
            }
            else if (income <= 228800)
            {
                taxed = (income * .35) + 54793.75;

            }
            else if (income > 228800)
            {
                taxed = (income * .396) + 63981.25;
            }

            return taxed;
        }

        //----------------------------------------------------------------------------------------------------------------------------//

        public static double TaxHOH(double income)
        {
            double taxed = 0;

            if (income <= 12950)
            {
                taxed = income * .1;
            }
            else if (income <= 49400)
            {
                taxed = (income * .15) + 1295;
            }
            else if (income <= 127550)
            {
                taxed = (income * .25) + 6762.5;
            }
            else if (income <= 206600)
            {
                taxed = (income * .28) + 26300;
            }
            else if (income <= 405100)
            {
                taxed = (income * .33) + 48434;
            }
            else if (income <= 432200)
            {
                taxed = (income * .35) + 113939;

            }
            else if (income > 432200)
            {
                taxed = (income * .396) + 118118.75;
            }

            return taxed;
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        //----------------------------------------------------------------------------------------------------------------------------//

    }
}

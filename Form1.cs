using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Walczak_VehiclePurchaseApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void calculateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string baseInput = baseBox.Text;
            string tradeInput = tradeBox.Text;
            int baseNumber = 0, tradeNumber = 0;
            double totalSub, totalCost;
            double checkBoxValue = 0;
            double amountDue = 0;

            //Test if base number is actually a number
            baseNumber = GetBaseNumber(baseInput);

            //Test if trade number is actually a number
            if (tradeBox.Text != "")
                tradeNumber = GetTradeNumber(tradeInput);

            //Get values from checkboxes
            checkBoxValue = GetCheckBoxes();
            
            //Subtotal
            totalSub = baseNumber + checkBoxValue;

            //Get total Cost
            totalCost = GetTotalCost(totalSub);

            //Amount due
            if (totalCost == 0)
                amountDue = 0;
            else
                amountDue = Math.Round(totalCost - tradeNumber, 2);

            //Output sub total, total, and amount due
            subOutput.Text = "$ " + Convert.ToString(totalSub);
            
            totalOutput.Text = "$ " + Convert.ToString(totalCost);

            amountOutput.Text = "$ " + Convert.ToString(amountDue);            
        }

        int GetBaseNumber(string input)
        {
            int baseNum = 0;

            if (int.TryParse(input, out int num))
            {
                baseNum = num;
            }
            else
            {
                MessageBox.Show("Enter valid base number");
                baseBox.Clear();
            }

            return baseNum;
        }

        int GetTradeNumber(string input)
        {
            int tradeNum = 0;

            if (int.TryParse(input, out int num))
            {
                tradeNum = num;
            }
            else
            {
                MessageBox.Show("Enter valid trade-in number");
                tradeBox.Clear();
            }

            return tradeNum;
        }

        double GetCheckBoxes()
        {
            double totalValue = 0;
            double[] checkedBoxes = {425.76, 987.41, 1741.23, 0, 345.72, 599.99};

            if (stereoBox.Checked == true)
            {
                totalValue += checkedBoxes[0];
            }
            if (leatherIntBox.Checked == true)
            {
                totalValue += checkedBoxes[1];
            }
            if (compNavBox.Checked == true)
            {
                totalValue += checkedBoxes[2];
            }
            if (standardBox.Checked == true)
            {
                totalValue += checkedBoxes[3];
            }
            if (pearlizeBox.Checked == true)
            {
                totalValue += checkedBoxes[4];
            }
            if (customBox.Checked == true)
            {
                totalValue += checkedBoxes[5];
            }

            return totalValue;
        }

        double GetTotalCost (double subCost)
        {
            double taxRate = 0.08;
            double total = 0;

            total = Math.Round((subCost + (subCost * taxRate)), 2);

            return total;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baseBox.Clear();
            tradeBox.Clear();
            stereoBox.Checked = false;
            leatherIntBox.Checked = false;
            compNavBox.Checked = false;
            standardBox.Checked = false;
            pearlizeBox.Checked = false;
            customBox.Checked = false;
            subOutput.Text = "";
            totalOutput.Text = "";
            amountOutput.Text = "";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

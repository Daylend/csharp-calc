using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_1___Calculator
{
    public partial class Form1 : Form
    {
        public string storedVar1;
        public string storedVar2;
        public string operation;
        bool answer = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            int textLength = txtOutput.Text.Length - 1; //Array length
            if (textLength + 1 > 0) //+1 for literal length
                txtOutput.Text = txtOutput.Text.Remove(textLength);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            storedVar1 = "";
            operation = "";
            answer = false;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //For all digit inputs. Better than 123124123123 event handlers.
            Button button = (Button)sender;

            if (answer) // If an answer was just given, clear last output first.
            {
                txtOutput.Text = "";
                answer = false;
            }

            if (button.Text != ".") //Check for decimal button
            {
                if (txtOutput.Text.Length < 12)
                    txtOutput.Text += button.Text;
            }
            else
            {
                //If there is already a decimal, remove the existing one and append a new one.
                if (txtOutput.Text.Contains('.'))
                {
                    int indexOf = txtOutput.Text.IndexOf('.');
                    txtOutput.Text = txtOutput.Text.Remove(indexOf, 1);
                    txtOutput.Text += ".";
                }
                else
                {
                    txtOutput.Text += ".";
                }
            }
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text.Contains('-'))
                txtOutput.Text = txtOutput.Text.Remove(0, 1);
            else
                txtOutput.Text = "-" + txtOutput.Text;

        }

        //Honestly these events could have been grouped too but I wasn't sure about AND and OR until later.
        private void btnDivide_Click(object sender, EventArgs e)
        {
            storedVar1 = txtOutput.Text;
            operation = "/";
            txtOutput.Text = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            storedVar1 = txtOutput.Text;
            operation = "*";
            txtOutput.Text = "";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            storedVar1 = txtOutput.Text;
            operation = "-";
            txtOutput.Text = "";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            storedVar1 = txtOutput.Text;
            operation = "+";
            txtOutput.Text = "";
        }
        private void btnAND_Click(object sender, EventArgs e)
        {
            storedVar1 = txtOutput.Text;
            operation = "&";
            txtOutput.Text = "";
        }
        private void btnOR_Click(object sender, EventArgs e)
        {
            storedVar1 = txtOutput.Text;
            operation = "|";
            txtOutput.Text = "";
        }

        private void btnDecBin_Click(object sender, EventArgs e)
        {
            try
            {
                //Convert.ToString is doing all the work here, converting to base 2.
                txtOutput.Text = Convert.ToString(Convert.ToInt64(txtOutput.Text), 2);
            }
            catch (Exception)
            {
            }
        }

        private void btnBinDec_Click(object sender, EventArgs e)
        {
            try
            {
                //ToInt64 taking base2 numbers and converting to base10.
                txtOutput.Text = Convert.ToInt64(txtOutput.Text, 2).ToString();
            }
            catch (Exception)
            {
            }
        }

        private void btnShiftL_Click(object sender, EventArgs e)
        {
            //Try to do a binary shift first, if it fails, do a decimal shift.
            //Only problem with this is if you mean 100 in decimal, not binary.
            //In which case, you need to convert 100 to binary, then shift.
            try
            {
                txtOutput.Text = Convert.ToString((Convert.ToInt64(txtOutput.Text, 2) << 1), 2);
            }
            catch (Exception)
            {
                try
                {
                    txtOutput.Text = (Convert.ToInt64(txtOutput.Text) << 1).ToString();
                }
                catch (Exception)
                {

                }
            }
        }

        private void btnShiftR_Click(object sender, EventArgs e)
        {
            try
            {
                txtOutput.Text = Convert.ToString((Convert.ToInt64(txtOutput.Text, 2) >> 1), 2);
            }
            catch (Exception)
            {
                try
                {
                    txtOutput.Text = (Convert.ToInt64(txtOutput.Text) >> 1).ToString();
                }
                catch(Exception)
                {

                }
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            answer = true; //For clearing later            
            storedVar2 = txtOutput.Text;
            long num1 = 0, num2 = 0;
            double numD1 = 0.0, numD2 = 0.0;
            bool isDouble = false;

            //Try converting to ints first... Didn't work? Doubles. Still no luck? You suck!
            //Fairly certain nested try statements aren't the best practice... But this worked well. I think?
            try
            {
                num1 = Convert.ToInt64(storedVar1);
                num2 = Convert.ToInt64(storedVar2);
            }
            catch (Exception)
            {
                try
                {
                    numD1 = Convert.ToDouble(storedVar1);
                    numD2 = Convert.ToDouble(storedVar2);
                    isDouble = true;
                }
                catch (Exception)
                {
                    //If it doesn't work just clear everything. Try again you sneaky user.
                    txtOutput.Text = "";
                    storedVar1 = "";
                    return;
                }
            }

            //Had to use a conditional operator to avoid repeating an entire switch/tons of if statements.
            switch (operation)
            {
                case "+":
                    txtOutput.Text = isDouble ? (numD1 + numD2).ToString() : (num1 + num2).ToString();
                    break;
                case "-":
                    txtOutput.Text = isDouble ? (numD1 - numD2).ToString() : (num1 - num2).ToString();
                    break;
                case "/":
                    txtOutput.Text = isDouble ? (numD1 / numD2).ToString() : (num1 / num2).ToString();
                    break;
                case "*":
                    txtOutput.Text = isDouble ? (numD1 * numD2).ToString() : (num1 * num2).ToString();
                    break;
                case "&":
                    txtOutput.Text = isDouble ? "ERROR" : (num1 & num2).ToString();
                    break;
                case "|":
                    txtOutput.Text = isDouble ? "ERROR" : (num1 | num2).ToString();
                    break;
            }

            if (txtOutput.Text == "ERROR")
                answer = true;

        }





    }
}

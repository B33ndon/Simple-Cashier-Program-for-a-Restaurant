using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pass(string a) // private func that i made to make item name passing easy
        {
            rtxtbx.Text = rtxtbx.Text + a; // append the new item name to the list
            rtxtbx.Text = rtxtbx.Text + Environment.NewLine; // make a new line
        }

        private void price(double b) // private func to add prices to list
        {
            rtxtbxPrice.Text = rtxtbxPrice.Text + b; // append price to list
            rtxtbxPrice.Text = rtxtbxPrice.Text + Environment.NewLine; // make new line

            double i = Convert.ToDouble(lblTotal.Text); // get lblTotal text and convert it to a double 
            double x = i + b; // calculate new price
            string y = Convert.ToString(x); // convert the total back to a string
            
            lblTotal.Text = y; // replace current string with total string text
        }

        private string getTotalPrice()
        {
            string price = lblTotal.Text; // assigns contents of the label to a variable
            return price; // returns price variable
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (rdbtnTakeAway.Checked == true) // if checkbox takeaway is checked
            {
                rdbtnEatIn.Checked = false; // change eat in checkbox to un-checked
            }
            else if (rdbtnEatIn.Checked == true) // if checkbox eatin is checked
            {
                rdbtnTakeAway.Checked = false; // change take away checbox to un-checked
            }
        } // make eatin and takeaway buttons work in sync

        private void btnOne_Click(object sender, EventArgs e)
        {
            pass("Starter - Prawns"); // pass the item name into the item name function
            price(3.99); // pass the price into the item price function
        }

        private void rdbtnEatIn_CheckedChanged(object sender, EventArgs e)
        {
            //obselete method - dont discard
        }

        private void rdbtnTakeAway_CheckedChanged(object sender, EventArgs e)
        {
            //obselete method - dont discard
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tbpage2; // Once a base has been selected the toppings page will be shown
            pass("Pizza Base - Normal"); // pass item name into function
            price(4.99); // pass item price into function
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tbpage2;
            pass("Pizza Base - Thin Crust");
            price(4.99);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tbpage2;
            pass("Pizza Base - Stuffed Crust");
            price(5.99);
        }

        private void btnStarter2_Click(object sender, EventArgs e)
        {
            pass("Starter - Nachos");
            price(3.99);
        }

        private void btnStarter3_Click(object sender, EventArgs e)
        {
            pass("Starter - Cheese Twirls");
            price(3.99);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pass("      Olives");
            price(0.99);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pass("      Jalapenos"); // pass item name into function with indent before item name
            price(0.99); // pass item price into function
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pass("      Chicken Pieces");
            price(0.99);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pass("      Pineapple");
            price(0.99);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pass("      Tomato");
            price(0.99);
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tbpage3;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pass("Dessert - Brownies");
            price(4.99);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pass("Dessert - Ice Cream");
            price(3.99);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pass("Dessert - Apple Pie");
            price(2.99);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pass("Dessert - Carrot Cake");
            price(5.99);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pass("Dessert - Ice Lolly");
            price(0.99);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(rtxtbx.Text == "") // if items lits has nothing on it
            {
                MessageBox.Show(
                    "You cannot order nothing, Please go back and select items...", // message box contents
                    "Message", // message box title
                    MessageBoxButtons.OK); // message controls = OK
            }else if(rtxtbxPrice.Text == "") // if items price list has nothing on it
            {
                MessageBox.Show(
                    "You cannot order nothing, Please go back and select items...", // message box contents
                    "Message", // message box title
                    MessageBoxButtons.OK); // message controls = OK
            }
            else // if the upper two statements are not executed
            {
                MessageBox.Show(
                    "Are you sure you want to order? The total price is: " + getTotalPrice(), // concatenate string and variable
                    "Order?", // message box title
                    MessageBoxButtons.YesNoCancel // define the control types = yes, no, cancel
                    ); // Show message box
            }

        }
    }
}

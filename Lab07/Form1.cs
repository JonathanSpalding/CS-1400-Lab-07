// Author: Jonathan Spalding
// Assignment: Lab 07
// Instructor "Roger deBry
// Clas: CS 1400
// Date Written: 1/23/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // The textBox1_Leave Method
        // Purpose: take diameter of wheel in inches, convert it to a double, multiply it by 3.14 to find the circumference, divide it by a mile in inches, rout it up to the nearest circumferance, and then convert it back to a string and ouput in the output box.
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void textBox1_Leave(object sender, EventArgs e)
        {
            // State constants (A mile is 63360 inches, pi is 3.14 etc.).
            const double mile = 63360;
            const double pi = 3.14;
            // Convert Diameter of wheel from String to Double.
            double wheel = double.Parse(inputBox.Text);
            // Multiply Diameter of wheel by 3.14.
            double circumference = wheel * pi;
            // Divide mile in inches by circumference of wheel rounded up by one wheel circumference.
            double total = Math.Ceiling(mile / circumference);
            // Convert total to string.
            string outStr = $"{total}";
            // Output in the Output box.
            outputBox.Text = outStr;
        }

        // The clearButton_Leave Method
        // Purpose: Delete all content in the two text boxes, and put curser back in the first input box.
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Delete all content in both boxes.
            inputBox.Clear();
            outputBox.Clear();
            // Put curser in the input box.
            inputBox.Select();

        }
        // The exitToolStripMenuItem1_Click Method
        // Purpose: Display a pop up box when you click About
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // The aboutToolStripMenuItem_Click Method
        // Purpose: Display a pop up box when you click About
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jonathan Spalding/nCS1400/nLab #7");
        }
    }
}

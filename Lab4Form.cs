/*
 * Written by: Nicholas Cockcroft
 * Date: February 6, 2018
 * Class: .NET Environment
 * Assignment: Lab 4
 * 
 * Description: Simulate the rolling of a pair of dice 100,000 times and display the number
 * of 2s, 3s, ..., and 12s rolled. Do your values make sense? Write a description as to why
 * they make sense. Use a push button to start the processing and display the results in the label.
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Lab4Form : Form
    {
        public Lab4Form()
        {
            InitializeComponent();
        }

        private void RollingButton_Click(object sender, EventArgs e)
        {
            // Clear the text box each time the button is pressed.
            outputTextBox.Text = "";

            Random randNum1 = new Random(); 
            Random randNum2 = new Random();
            int die1;
            int die2;
            int result;
            int[] resultCounts = new int[11]; // Stores the counts of each result of rolling the dies.

            // Theoretically roll 2 die 100,000 times and get random results.
            for(int i = 0; i < 100000; i++)
            {
                die1 = randNum1.Next(1, 7);
                die2 = randNum2.Next(1, 7);

                result = die1 + die2;

                // Adds 1 to the count of each of the result possiblities.
                switch (result)
                {
                    case 2:
                        resultCounts[0] += 1;
                        break;

                    case 3:
                        resultCounts[1] += 1;
                        break;

                    case 4:
                        resultCounts[2] += 1;
                        break;

                    case 5:
                        resultCounts[3] += 1;
                        break;

                    case 6:
                        resultCounts[4] += 1;
                        break;

                    case 7:
                        resultCounts[5] += 1;
                        break;

                    case 8:
                        resultCounts[6] += 1;
                        break;

                    case 9:
                        resultCounts[7] += 1;
                        break;

                    case 10:
                        resultCounts[8] += 1;
                        break;

                    case 11:
                        resultCounts[9] += 1;
                        break;

                    case 12:
                        resultCounts[10] += 1;
                        break;

                    default:
                        outputTextBox.Text += "Error, invalid result.";
                        break;
                }
            }
            // Writes the counts to the output textbox.
            for (int j = 0; j < 11; j++)
            {
                outputTextBox.Text += "Count for ";
                outputTextBox.Text += (j + 2);
                outputTextBox.Text += ": ";
                outputTextBox.Text += resultCounts[j];
                outputTextBox.Text += "\r\n";
            }

            /*
             * Reasoning behind the results:
             * 
             * After running the program a couple of times, I noticed that each compile, there
             * was constantly 0 for roughly half of the counts of numbers. I think the reasoning
             * behind this is that since the random number generator is based on time, rolling a
             * pair of dice 100,000 times can be computed very quickly and possibly even in the same 
             * second. Thus, if all of the random numbers are happening close to the same second, it is
             * very likely to have the same "random" numbers as the result. That is why I think some of
             * the counts were in the thousands while the others were stuck at 0. I also noticed that
             * every time I ran the program, it was always 2, 4, 6, 8, 10, and 12 that had counts in 
             * the thousands and never any of the other numbers. I think this is also due to generating 
             * the random numbers in such close apporixmation to each other and that both of the references
             * to the random objects were being ran right next to each other in the program.
             * 
             */
        }

        private void Lab4Form_Load(object sender, EventArgs e)
        {

        }
    }
}

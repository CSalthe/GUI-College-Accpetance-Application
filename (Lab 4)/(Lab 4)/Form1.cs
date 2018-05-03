// Lab 4
// ID: X1084
// 2/18/2018
// CIS-199-02
// This program takes a user entered grade point average and test score to determine admissiion as well and counts each time the user presses the button on the form. 
using System;
using static System.Console;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Lab_4_
{
    public partial class admissionCalculator : Form
    {

        //sets count as a value to 0, which allows the clicke event to increaes 0 by 1 each time the utton is clicked
        int countAccepted = 0;
        int countRejected = 0;
        bool accepted = false;
        public admissionCalculator()
        
        {
            

            InitializeComponent();
        }
        // Thie event handler executes upon the button on the form being prssed, it determines if the input test scores and gpa is good enough for entrance
        private void admissionButton_Click(object sender, EventArgs e)
        {

            {

                int testScore; // The score recieved on admissions test
                float gpa; // The gpa of a given student 


                //takes user input as variables to later be input into if statement

                if (float.TryParse(gpaTextBox.Text, out gpa) && (gpa >= 0))
                {
                    if (int.TryParse(testScoreTextBox.Text, out testScore) && (testScore >= 0))
                    {
                        //IF statement to determine admission acceptance or rejection based on user input test scores and gpa
                        if ((gpa >= 3.0 && testScore >= 60) || (gpa < 3.0 && testScore >= 80))
                        {
                            admissionStandingTextBox.Text = "Accept";
                            accepted = true;
                        }
                        else
                        {
                            admissionStandingTextBox.Text = "Reject";
                            accepted = false;
                        }
                        // Running total of accepted and rejected applicants
                        if (accepted)
                        {
                            countAccepted++;
                            acceptedOutput.Text = countAccepted.ToString();
                        }
                        else
                        {
                            countRejected++;
                            rejectedOutput.Text = countRejected.ToString();
                        }
                    }
                    // Error message if invalid input is input
                    else
                        MessageBox.Show("Enter a valid Test Score and GPA");
                }
                //Error message for invalid input
                else
                    MessageBox.Show("Enter a valid Test Score and GPA");
            }

        }

        private void runningTotalLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

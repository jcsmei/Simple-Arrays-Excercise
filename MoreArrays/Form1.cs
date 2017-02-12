using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoreArrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTwoDimensionalArray_Click(object sender, EventArgs e)
        {
            //declaring wihtout initialization
            //decimal[,] price = new decimal [5,4];
            //price[0, 0] = 450m;
            //price[0, 1] = 450m;
            //price[0, 2] = 540m;
            //... ... ... shows you how to declare with initilization
            //decimal stores more digits, more precise data
            //used for money calculations
            //m used to assign decimal numbers
            decimal[,] prices =
            {
                {450m, 450m, 450m, 450m },
                {425m, 425m, 425m, 425m },
                {400m, 400m, 400m, 400m },
                {375m, 375m, 375m, 375m },
                {375m, 375m, 375m, 375m },
                {350m, 350m, 350m, 350m }
            };
            rtbDisplay.Text = "traversgin a two-dimensional array, row by row: \n";
            for (int x = 0; x <= prices.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= prices.GetUpperBound(1); y++)
                {
                    //rtbDisplay.AppendText(prices[x, y].ToString() + ",");
                    lblDisplay.Text = (prices[x, y].ToString());
                }
                //rtbDisplay.AppendText(Environment.NewLine);
                lblDisplay.Text.ToString();
            }

            rtbDisplay.AppendText("\ntraversing a two-dimensional array, column by column:\n");
            for (int y = 0; y <= prices.GetUpperBound(1); y++)
            {
                for (int x = 0; x <= prices.GetUpperBound(0); x++)
                {
                    rtbDisplay.AppendText(prices[x, y].ToString() + ",");
                }
                rtbDisplay.AppendText(Environment.NewLine);
            }
            rtbDisplay.AppendText("\nThe sum of all items is:    ");
            decimal sum = 0;
            for (int y = 0; y <= prices.GetUpperBound(1); y++)
            {
                for (int x = 0; x <= prices.GetUpperBound(0); x++)
                {
                    sum += prices[x, y];
                    //sum = sum + prices[x, y];
                }
            }
            rtbDisplay.AppendText(sum.ToString());
        }

        private void btnJaggedArray_Click(object sender, EventArgs e)
        {
            //an array of 3 int array.
            int[][] jaggedArray = new int[3][];//[rows][columns]

            //create individual arrays to populate the jaged array.
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
            jaggedArray[1] = new int[3] { 5, 6, 7 };
            jaggedArray[2] = new int[5] { 8, 9, 10, 11, 12 };

            rtbDisplay.Text = "Below are elements from a jagged array: \n";
            int sum = 0;
            for (int x = 0; x <= jaggedArray.GetUpperBound(0); x++)//GetUpperBound(ro)
            {
                //for (int y=0; y < jaggedArray[x].Length; y++)
                for (int y = 0; y <= jaggedArray[x].GetUpperBound(0); y++)
                {
                    rtbDisplay.AppendText(jaggedArray[x][y].ToString() + ",");
                    sum += jaggedArray[x][y]; //add each element
                }
                rtbDisplay.AppendText("\nThe total is: " + sum.ToString());
            }
        }

        private void btnPractice_Click(object sender, EventArgs e)
        {
            int[,] numbers =
            {
                {1,2,3,4,5 },
                {6,7,8,9,10 },
                {11,12,13,14,15 },
                {16,17,18,19,20 },
                {21,22,23,24,25 }
            };
            //rtbDisplay.AppendText("\ntraversing a two-dimensional array, DIAGONALLY:\n");
            //for (int y = 0; y <= numbers.GetUpperBound(1); y++)
            //{
            //    for (int x = 0; x <= numbers.GetUpperBound(0); x++)
            //    {
            //        rtbDisplay.AppendText(numbers[x, y].ToString() + ",");
            //    }
            //    rtbDisplay.AppendText(Environment.NewLine);
            //}
            //rtbDisplay.AppendText("\nThe sum of DIAGONAL items is:    ");
            //int sum = 0;
            //for (int x = 0; x <= numbers.GetUpperBound(0); x++)
            //{
            //    sum += numbers[x, x];//you don't need Y, you ONLY NEED X
            //    //x = (0, 0) (1, 1) (2, 2) etc. etc.
            //}
            //rtbDisplay.AppendText(sum.ToString());
            lblDisplay.Text = numbers[4, 4].ToString();

        }

        private void btnDisplayArray_Click(object sender, EventArgs e)
        {
            int[,] numberDisplay = new int[5, 5];
            int newNumbers = 1;
            for (int x = 0; x <= numberDisplay.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= numberDisplay.GetUpperBound(1); y++)                            
                {
                    numberDisplay[x, y] = newNumbers;
                    newNumbers++;
                    rtbDisplay.AppendText(numberDisplay[x, y].ToString() + ",");
                }
                rtbDisplay.AppendText(Environment.NewLine);
            }

        }
    }
}


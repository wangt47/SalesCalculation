/*
 CISP 405 Summer 2019 Tony Wang SID # 1443145
 
 Assignment 4 Description:
 Create a console app that uses a one-dimensional array
 that stores the each sales amount entered and then calculate
 each sales amount entry to find the result salary and
 fill out the range list of salary values to find the amount
 of people who has a salary in that min-max value and print
 out this list of range with the numbers specified.
 

 SalesCalculationTest.cs
 Making the framework of creating an array that stores a user's
 sales amount each time until the user types in a negative number
 to stop the loop and perform the calculation to find the list of 
 salary range values that counts how many sales person have a salary
 in that range.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculation
{
    class SalesCalcuation
    {
        private int[] salesAmountList  = new int[0]; // array of sales amount

        /* counter to place current position of 
         * the user input array (salesAmountList)
         */
        private int salesListCount = 0; 

        // An array of all calculated salaries.
        private double[] salesResultList = new double[0];

        // An array of counting the specific ranges possible.
        private int[] salesRangeCountList = new int[9];

        // Prompt user to enter in a sales amount for every entry repeatedly
        // until a negative number is entered to end the loop and move into 
        // the calculation and to output the salary ranges results.
        public void InputPrompt()
        {
            // user input amount variable.
            int userAmount;

            // do while repeats as long the user keeps entering 0 or a positive number.
            do
            {
                // Prompt user to enter in a sales amount and store amount in the variable.
                Console.Write("Enter sales amount (negative to end): ");
                userAmount = int.Parse(Console.ReadLine());

                // Exit do while loop if user entered a negative number.
                if (userAmount < 0)
                {
                    break;
                }
                // Resize the input array by one.
                Array.Resize(ref salesAmountList, salesAmountList.Length + 1); 
                // store the user input amount into the array.
                salesAmountList[salesListCount] = userAmount;
                // increase counter to keep track of input array's current size.
                salesListCount++;
                
            } while (userAmount >= 0);
        }

        // Perform the calculation of salaries for every input entry.
        public void saleCalculate()
        {
            int calcBase = 200;     // set base calculator, a base salary of $200. 
            double calcPercent = 0.09; // set multiplier, 9% of sales amount.

            /* Resizing the calculated salaries result array to be the same size
             * as the input array of sales amount.
             */
            Array.Resize(ref salesResultList, salesAmountList.Length);

            // calculate each input entry and store the calculated salary result
            // in the result array simultaneously.
            for (int i=0; i < salesResultList.Length; i++)
            {
                salesResultList[i] = calcBase + (calcPercent * salesAmountList[i]);
            }
        }

        /* For every entry from the list of calculated salaries (salesResultList),
         * specific entry of the range array increases by one to confirm the value
         * of the calculated salary is in that min-max value (i.e. $494 is for
         * $400 - $499) and count how many sales people of that salary min-max value 
         * are found so far.
         */
        public void saleRange()
        {
            for (int i=0; i < salesResultList.Length; i++)
            {
                // $200 - $299 range is found and the count is increased by 1.
                if (salesResultList[i]>=200 && salesResultList[i] < 300)
                {
                    salesRangeCountList[0] += 1;
                }
                // $300 - $399 range is found and the count is increased by 1.
                else if (salesResultList[i] >= 300 && salesResultList[i] < 400)
                {
                    salesRangeCountList[1] += 1;
                }
                // $400 - $499 range is found and the count is increased by 1.
                else if (salesResultList[i] >= 400 && salesResultList[i] < 500)
                {
                    salesRangeCountList[2] += 1;
                }
                // $500 - $599 range is found and the count is increased by 1.
                else if (salesResultList[i] >= 500 && salesResultList[i] < 600)
                {
                    salesRangeCountList[3] += 1;
                }
                // $600 - $699 range is found and the count is increased by 1.
                else if (salesResultList[i] >= 600 && salesResultList[i] < 700)
                {
                    salesRangeCountList[4] += 1;
                }
                // $700 - $799 range is found and the count is increased by 1.
                else if (salesResultList[i] >= 700 && salesResultList[i] < 800)
                {
                    salesRangeCountList[5] += 1;
                }
                // $800 - $899 range is found and the count is increased by 1.
                else if (salesResultList[i] >= 800 && salesResultList[i] < 900)
                {
                    salesRangeCountList[6] += 1;
                }
                // $900 - $999 range is found and the count is increased by 1.
                else if (salesResultList[i] >= 900 && salesResultList[i] < 1000)
                {
                    salesRangeCountList[7] += 1;
                }
                // $1000 or over range is found and the count is increased by 1.
                else if (salesResultList[i] > 1000)
                {
                    salesRangeCountList[8] += 1;
                }
            }
        }

        /* Prints out the result by showing the list of ranges
           and number which counts how many calculated salaries
           for that specified range.*/
        public void saleResultsOutput()
        {
            Console.WriteLine("Range                     Number");
            int rangeBaseBegin = 200, rangeMulti = 100, rangeBaseEnd = 299;
            // Print out every range entry and its number of sales people 
            // from $200 - $299 to $900 - $999.
            for(int i=0; i < salesRangeCountList.Length - 1; i++)
            {
                Console.WriteLine($"${rangeBaseBegin+(i*rangeMulti)}-${rangeBaseEnd + (i * rangeMulti)}                 {salesRangeCountList[i]}");
            }
            // Print out the last range entry: $1000 and over.
            Console.WriteLine($"$1000 and over            {salesRangeCountList[salesRangeCountList.Length-1]}");
        }
    }
}

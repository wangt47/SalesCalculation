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
 The main C# file to create the main program of this assignment,
 creates an object variable of SalesCalculation class to perform
 the program's purpose by calling out the methods in order.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculation
{
    class SalesCalculationTest
    {
        static void Main(string[] args)
        {
            // Create an object variable to use SalesCalculation class.
            SalesCalcuation salesClass = new SalesCalcuation();
            // the order of the program's execution.
            salesClass.InputPrompt();
            salesClass.saleCalculate();
            salesClass.saleRange();
            salesClass.saleResultsOutput();
            //Pauses the console and prompt any key to close the console
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

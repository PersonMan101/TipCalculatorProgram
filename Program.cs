// Program to calculate the total restaurant charges including tips
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double mealAmount = GetMealCharge();
            double tip = GetTipAmount(15.0, mealAmount);
            DisplayMealTab(mealAmount, 9.0, tip, 15.0);
            tip = GetTipAmount(20.0, mealAmount);
            DisplayMealTab(mealAmount, 9.0, tip, 20.0);
            Console.ReadKey();
        }
        // Gets the meal charge from the user
        static double GetMealCharge()
        {
            double charge;
            Console.WriteLine("Enter the charges for the meal");
            charge = double.Parse(Console.ReadLine());
            if (charge > 0)
            {
                return charge;
            }
            else
                return 0;
        }
        // Calculates and returns the tip amount for a specified tip rate
        static double GetTipAmount(double tipRate, double mealAmount)
        {
            double amount;
            if (tipRate <= 0) // Eliminate negative rates
                tipRate = 0;
            amount = tipRate * mealAmount / 100.0; // Assume tip rate is a percent
            return amount;
        }
        // Displays the bill
        static void DisplayMealTab(double meal, double tax, double tip, double tipRate)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Meal charge = {0:C}", meal);
            double taxAmount = meal * tax / 100.0;
            Console.WriteLine("Tax on meal = {0:C}", taxAmount);
            double total = meal + taxAmount;
            Console.WriteLine("Total before tip = {0:C}", total);
            Console.WriteLine("Tip Amount = {0:C} for {1:P} tip", tip, tipRate / 100.0);
            Console.WriteLine("Total = {0:C}", (total + tip));
            Console.WriteLine("---------------------------------");
        }
        
    }
} // End TipCalculator
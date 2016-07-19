using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekly_Earnings
{
    class Program
    {
        static void Main(string[] args)
        {
            double wageBeforeTax = 0;
            double wage = 0;
            double hours = 0;
            double totalHours = 0;
            double totalOT = 0;
            //final amount is the amount of money made at the end of the week. 
            double finalAmount = 0;

            Console.WriteLine("This is a calculator for the amount of money made in one week.");
            //make sure wage has not changed
            Console.WriteLine("Enter hourly wage");
            wageBeforeTax = Convert.ToDouble(Console.ReadLine());
            wage = wageBeforeTax * 0.82;

            //get hour count including overtime (OT)
            Console.WriteLine("How many hours worked on monday?");
            double monHours = Convert.ToDouble(Console.ReadLine());
            if (monHours > 8)
            {
                double monOT = monHours - 8;
                monHours = 8;
                totalOT = totalOT + monOT;

            }
            Console.WriteLine("tuesday?");
            double tuesHours = Convert.ToDouble(Console.ReadLine());
            if (tuesHours > 8)
            {
                double tuesOT = tuesHours - 8;
                tuesHours = 8;
                totalOT = totalOT + tuesOT;
            }
            Console.WriteLine("wednesday");
            double wedHours = Convert.ToDouble(Console.ReadLine());
            if (wedHours > 8)
            {
                double wedOT = wedHours - 8;
                wedHours = 8;
                totalOT = totalOT + wedOT;
            }
            Console.WriteLine("thursday?");
            double thursHours = Convert.ToDouble(Console.ReadLine());
            if (thursHours > 8)
            {
                double thursOT = thursHours - 8;
                thursHours = 8;
                totalOT = totalOT + thursOT;
            }
            Console.WriteLine("friday?");
            double friHours = Convert.ToDouble(Console.ReadLine());
            if (friHours > 8)
            {
                double friOT = friHours - 8;
                friHours = 8;
                totalOT = totalOT + friOT;
            }
            Console.WriteLine("saturday?");
            double satHours = Convert.ToDouble(Console.ReadLine());
            if (satHours > 8)
            {
                double satOT = satHours - 8;
                satHours = 8;
                totalOT = totalOT + satOT;
            }
            Console.WriteLine("sunday");
            double sunHours = Convert.ToDouble(Console.ReadLine());
            if (sunHours > 8)
            {
                double sunOT = sunHours - 8;
                sunHours = 8;
                totalOT = totalOT + sunOT;
            }

            //add it up
            totalHours = monHours + tuesHours + wedHours + thursHours + friHours + satHours + sunHours;
            Console.WriteLine("Your total hour count for this week was: " + totalHours + "\nYour total overtime hour count for this week was: " + totalOT);

            //calculate final weekly number
            double wageOT = (wage / 2) + wage;
            finalAmount = (totalHours * wage) + (totalOT * wageOT);
            Console.WriteLine("The amount of money you should receive this week is: " + finalAmount);
            Console.ReadLine();
        }
    }
}

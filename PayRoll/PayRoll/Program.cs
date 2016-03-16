using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SalariedEmp salariedEmployee =
            new SalariedEmp("John", "Smith", "111-11-1111", 800.00);
            HourlyEmp hourlyEmployee =
            new HourlyEmp("Karen", "Price",
            "222-22-2222", 16.75, 40.00);
            CommisionEmp commissionEmployee =
            new CommisionEmp("Sue", "Jones",
            "333-33-3333", 10000.00, 0.06);
            BaseSCEmp basesceemp =
            new BaseSCEmp("Bob", "Lewis",
            "444-44-4444", 5000.00, 0.04, 300.00);



            Console.WriteLine("{0}\nearned: {1:C}\n",
             salariedEmployee, salariedEmployee.CalculateTotal());
            Console.WriteLine("{0}\nearned: {1:C}\n",
            hourlyEmployee, hourlyEmployee.CalculateTotal());
            Console.WriteLine("{0}\nearned: {1:C}\n",
            commissionEmployee, commissionEmployee.CalculateTotal());
            Console.WriteLine("{0}\nearned: {1:C}\n",
            basesceemp,
            basesceemp.CalculateTotal());

           

        }
        public static bool UserEnteredWage_morethanzero(double userInput)
        {
            var result = false;

            // your implementation here
            if (userInput >0)
            {

                result = true;
            }


            return result;
        }

        public static bool UserEnteredHours(double userInput)
        {
            var result = false;

            // your implementation here
            if (userInput>0&&userInput<168)
            {

                result = true;
            }


            return result;
        }
        public static bool UserEnteredCommssionrate(double userInput)
        {
            var result = false;

       
            if (userInput>0.0&&userInput<1.0)
            {

                result = true;
            }
          


            return result;
        }
        public static bool EnterSSN(string userInput)
        {
            var result = false;

            // your implementation here
            if (userInput==" ")
            {

                result = false;
            }
            if (userInput == null)
            {
                result = false;
            }


            return result;
        }

    }
}

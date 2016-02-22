using System;

namespace GasPump
{
	public class Program
	{
		public enum GasType
		{
			None,
			RegularGas,
			MidgradeGas,
			PremiumGas,
			DieselFuel				
		}

        static void Main(string[] args)
        {
            // your implementation here
            Console.WriteLine("Please enter purchased gas type: Q/q to quit");
            char gastype = Char.Parse(Console.ReadLine());
            string c = gastype.ToString();
            if (UserEnteredSentinelValue(c))
            {
                Console.WriteLine("Application Terminated");


            }

            else
            {



                while (c!="Q"||c!="q"&&UserEnteredValidGasType(c))
                {
                    Console.WriteLine("Please enter purchased gas type: Q/q to quit ");
                    gastype = Char.Parse(Console.ReadLine());
                    c = gastype.ToString();

                    if (UserEnteredSentinelValue(c))
                    {
                        Console.WriteLine("Application Terminated");
                        break;
                    }
                    Console.WriteLine("Please enter purchased gas amount:");
                    string amount = Console.ReadLine();
                    if (UserEnteredValidAmount(amount))
                    {
                        //a = Char.Parse(Console.ReadLine());
                        //c = a.ToString();
                        char a = Convert.ToChar(gastype);
                        GasType gt = GasTypeMapper(a);
                        double price = GasPriceMapper(gt);
                       
                        int gasamount = Convert.ToInt32(amount);

                        double totalCost = 0.00;

                        Console.WriteLine("Your total cost for this purchese:");
                        CalculateTotalCost(gt, gasamount, ref totalCost);
                        //Console.WriteLine(price);

                       

                    }

                }

            }
        }


    

		// use this method to check and see if sentinel value is entered
		public static bool UserEnteredSentinelValue(string userInput)
		{
			var result = false;

			// your implementation here
            if(userInput=="Q"||userInput=="q")
            {
                
                result = true;
            }


			return result;
		}

		// use this method to parse and check the characters entered
		// this does not conform 
		public static bool UserEnteredValidGasType(string userInput)
		{
           
            var result = false;
            char[] a = userInput.ToCharArray();
            foreach (char b in userInput)
            {
                if (b >= 'a' && b <= 'z')
                {
                    result= true;
                }
                if (b >= 'A' && b <= 'Z')
                {
                    result= true;
                }

            }

           
            
            if (userInput != null)
            {
                if (userInput == "r" || userInput == "R" || userInput == "m" || userInput == "M" || userInput == "D" || userInput == "d" || userInput == "P" || userInput == "p")
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else
            {
                result = false;
            }
            // your implementation here
            if (userInput.IndexOf(" ") >= 0)
            {
                result= false;
            }
            if (userInput == " ")
                result=false;
            if (userInput.Length > 1)
                result= false;
            if (userInput == null)
                result = false;

            return result;

            // your implementation


            
           // if (userInput.Length > 1)
            //{
              // return false;
            //}
           
            //  System.Text.RegularExpressions.Regex.IsMatch(userInput, "[A-Z]");

           
           











            return result;
		}

		// use this method to parse and check the double type entered
		// please use Double.TryParse() method 
		public static bool UserEnteredValidAmount(string userInput)
		{
            var result = false;
            if (userInput != null && userInput != " ")
            {
                double amount;
                if (!Double.TryParse(userInput, out amount))

                    result= false;

                else {
                    double.TryParse(userInput, out amount);
                    if (amount < 0)
                    {
                        result= false;
                    }

                    return true;
                }
            }

            if (userInput == " ")
            {
                result= false;
            }


            // your implementation here

            return result;
        }

		// use this method to map a valid char entry to its enum representation
		// e.g. User enters 'R' or 'r' --> this should be mapped to GasType.RegularGas
		// this mapping "must" be used within CalculateTotalCost() method later on
		public static GasType GasTypeMapper(char c)
		{  
			GasType gasType = GasType.None;
            if ( c == 'r'||c=='R')
            {
                gasType = GasType.RegularGas;

            }
            if (c ==  'm'||c=='M')
            {
                gasType = GasType.MidgradeGas;
            }
            if (c ==  'p'||c=='P')
            {
                gasType = GasType.PremiumGas;
            }
            if (c ==  'd'||c=='D')
            {
                gasType = GasType.DieselFuel;
            }
              
                


            // your implementation here

            return gasType;
		}

		public static double GasPriceMapper(GasType gasType)
		{
			var result = 0.0;

            // your implementation here
            if (gasType == GasType.RegularGas)
                result = 1.94;
            if (gasType == GasType.MidgradeGas)
                result = 2.00;
            if (gasType == GasType.PremiumGas)
                result = 2.24;
            if (gasType == GasType.DieselFuel)
                result = 2.17;

			return result;
	}

		public static void CalculateTotalCost(GasType gasType, int gasAmount, ref double totalCost)
		{
            // your implementation here
            totalCost = GasPriceMapper(gasType) * gasAmount;
           // if (gasType == GasType.RegularGas)
            //{
              //  totalCost = 1.94 * gasAmount;
            //}
            //if (gasType == GasType.PremiumGas)
            //{
              //  totalCost = 2.24 * gasAmount;

//            }
  //          if (gasType == GasType.MidgradeGas)
    //        {
      //          totalCost = 2.00 * gasAmount;
        //    }
          //  if (gasType == GasType.DieselFuel)
            //{
              //  totalCost = 2.17 * gasAmount;
            //}



            Console.WriteLine(totalCost);





            }
            
		}
	}


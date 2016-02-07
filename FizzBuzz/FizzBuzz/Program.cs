using System;
namespace FizzBuzz

{
	class Program
	{
		static void Main(string[] args)
		{
            FizzBuzz fizzbuzz = new FizzBuzz();

          Console.WriteLine("Please input a number");
           int i = int.Parse(Console.ReadLine());
            string result = fizzbuzz.RunFizzBuzz(i);
            Console.Write("result={0}  ", result);
        }
	}
}

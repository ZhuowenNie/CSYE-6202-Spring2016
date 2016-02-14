using System;

namespace TrianglePatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			DisplayPatternA();
			DisplayPatternB();
			DisplayPatternC();
			DisplayPatternD();

			Console.ReadLine();
		}

		static void DisplayPatternA()
		{
            int i;
            int j;
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j <= i; j++)
                    Console.Write('*');
                Console.WriteLine();
            }
        }

		static void DisplayPatternB()
		{
            int i, j;
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10 - i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

		static void DisplayPatternC()
		{
            int i, j, k;
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write(" ");
                for (k = 10; k >= i; k--)
                    Console.Write("*");
                Console.WriteLine();

            }
        }

		static void DisplayPatternD()
		{
            int i, j, k;
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10 - i; j++)
                    Console.Write(" ");
                for (k = 1; k <= i; k++)
                    Console.Write("*");
                Console.WriteLine();

            }
        }
	}
}

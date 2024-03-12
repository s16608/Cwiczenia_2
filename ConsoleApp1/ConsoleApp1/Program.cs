using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        
        Console.WriteLine("Modyfikacja 1");
        
        Console.WriteLine("Modyfikacja 2");
        
        Console.WriteLine("Modyfikacja 3");

        int[] numbers = { 10, 20, 30, 40, 50 };

        static double CalculateAverageFromArray(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }

            return (double)sum/array.Length;
        }
        
        static int FindMax(int[] array)
        {
            int max = array[0];
            foreach (int num in array)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
    }
}
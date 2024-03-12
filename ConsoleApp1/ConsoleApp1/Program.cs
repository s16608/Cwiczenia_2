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
            int total = 0;
            foreach (int num in array)
            {
                total += num;
            }

            return (double)total/array.Length;
        }

        int[] numbers2 = { 3, 4, 12, 212, 4, 2, 8, 232 };
        
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
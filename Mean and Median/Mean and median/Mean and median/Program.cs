using System;

namespace Mean_and_median
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 10, 2, 1, 4, 2, 50 };
            Array.Sort(list);
            double sum = 0;
            foreach (double element in list)
            {
                sum += element;
            }
            double mean = sum / list.Length;
            double median = 0;
            if ((list.Length % 2) == 0)
            {
                median = (list[(list.Length / 2) - 1] + list[(list.Length / 2)]) / 2.0;
            }
            else
            {
                median = (list[(list.Length / 2)]);
            }
            Console.WriteLine($"Mean of given list = {mean}");
            Console.WriteLine($"Median of given list = {median}");
        }
    }
}

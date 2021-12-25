using System;
namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4];
            Random random = new Random();
            Console.WriteLine("Source array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10);
                Console.Write(array[i] + " ");
            }
            array.geometric_and_arithmetic_difference();
        }
    }
    public static class My_class
    {
        public static void geometric_and_arithmetic_difference(this int[] arr)
        {
            double arithmetic = 0;
            double geometric = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                arithmetic += arr[i];
                geometric *= arr[i];
            }
            arithmetic = arithmetic / arr.Length;
            Console.WriteLine("\narithmetic_difference:");
            Console.WriteLine(arithmetic);
            geometric = Math.Pow(geometric, 1.0/ arr.Length);
            Console.WriteLine("\ngeometric_difference:");
            Console.WriteLine(geometric);
        }
    }
}

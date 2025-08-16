using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace G08_20241109
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generate Start and End values for populating the array.
            int startValue, endValue;
            do
            {
                startValue = Random.Shared.Next(0, 1000);
                endValue = Random.Shared.Next(0, 1000);
            } while (endValue - startValue < 10);
            Console.WriteLine($"Start value: {startValue}\nEnd value: {endValue}\n");

            // Declare the array.
            int[] array = new int[10];


            // Populate the array with random values.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Random.Shared.Next(startValue, endValue);
                string type = array[i] % 2 == 0 ? "even" : "odd";
                Console.WriteLine($"Array[{i}] = {array[i]}");
            }

            int sumEven = 0;
            int sumOdd = 0;
            int countEven = 0;
            int countOdd = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] % 2 == 0)

                {
                    countEven++;
                    sumEven += array[i];
                }
                else if (array[i] % 2 == 1)

                {
                    countOdd++;
                    sumOdd += array[i];

                }


            Console.WriteLine($"Sum of Even numbers: {sumEven}");
            Console.WriteLine($"Sum of Odd numbers: {sumOdd}");



            double avgeven = (double)sumEven / countEven;
            Console.WriteLine($"Average of the array Even: {avgeven}");
            double avgodd = (double)sumOdd / countOdd;
            Console.WriteLine($"Avarage of the array Odd {avgodd}");

            int? minEven = null;
            int? minOdd = null;
            int? maxOdd = null;
            int? maxEven = null;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (minEven == null || array[i] < minEven)

                    {
                        minEven = array[i];
                    }
                }

                if (maxEven == null || array[i] > minEven)
                {
                    maxEven = array[i];
                }

                else if (minOdd == null || array[i] < minOdd)
                {
                    minOdd = array[i];

                }
                else if (maxOdd == null || array[i] > maxOdd)
                {
                    maxOdd = array[i];
                }

            }
            Console.WriteLine($"Minimum value of Even numbers: {minEven}");
            Console.WriteLine($"Minimum value of odd numbers: {minOdd}");
            Console.WriteLine($"Maximum value of Even numbers: {maxEven}");
            Console.WriteLine($"Maximum value of odd numbers: {maxOdd}");

        }

        // დამითვალეთ ჯამი, საშუალო, მინიმუმი და მაქსიმუმი მასივის ელემენტების.
        // ოღონდ ცალ ცალკე კენტებისთვის და ლუწებისთვის.
    }
}

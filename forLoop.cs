using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main()
        {
            //int[] x = new int[100];
            //int sum = 0;
            //for (int i = 0; i < x.Length; i++)
            //{
            //    x[i] = Random.Shared.Next(1, 100);
            //    sum += x[i];

            //}
            //Console.WriteLine(sum);

            int[] x = new int[10];
            int count = 0;
            double average = 0;
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = Random.Shared.Next(1, 10);
                count++;
                sum += x[i];
                average = sum / count;

            }
            Console.WriteLine(average);
        }
    }
}


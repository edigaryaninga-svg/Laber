using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class lab2
    {
        public static int ToMultiplicate(int x, int N = 2)
        {
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += x;
            }
            return sum;
        }

        public static double ToMultiplicate(double x, int N = 2)
        {
            double sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += x;
            }
            return sum;
        }

        public static string ToMultiplicate(string x, int N = 2)
        {
            string result = "";
            for (int i = 0; i < N; i++)
            {
                result += x;
            }
            return result;
        }
        static void Main(string[] args)
        {
            // Int
            int intRes1 = ToMultiplicate(5);
            int intRes2 = ToMultiplicate(5, 4);

            // Double
            double douRes1 = ToMultiplicate(2.5);
            double douRes2 = ToMultiplicate(2.5, 8);

            // String
            string strRes1 = ToMultiplicate("str ");
            string strRes2 = ToMultiplicate("str ", 3);

            Console.WriteLine("Int default: {0}", intRes1);
            Console.WriteLine("Int explicit: {0}", intRes2);

            Console.WriteLine("Double default: {0}", douRes1);
            Console.WriteLine("Double explicit: {0}", douRes2);

            Console.WriteLine("String default: {0}", strRes1);
            Console.WriteLine("String explicit: {0}", strRes2);
        }
    }
}

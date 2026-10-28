using System;

namespace Lab4
{
    internal class lab4
    {
        static void A(in int x)
        {
            // x = 10; // Error: in is used when the variables should not be modified by the method
            Console.WriteLine($"Inside method A (in): x = {x}");
        }

        static void B(out int x)
        {
            x = 50; // if we comment this line the error will emerge, out should always assign a value 
            Console.WriteLine($"Inside method B (out): x = {x}");
        }

        static void C(ref int x)
        {
            x += 10;
            Console.WriteLine($"Inside method C (ref): x = {x}");
        }

        static int SumValues(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("IN");
            int valA = 5;
            A(in valA);
            Console.WriteLine($"In Main after A: valA = {valA}\n");

            Console.WriteLine("OUT");

            // int unassignedOut;
            // Console.WriteLine(unassignedOut); // Error: Use of unassigned local variable
            // B(out unassignedOut);

            int valB;
            B(out valB);
            Console.WriteLine($"In Main after B: valB = {valB}\n");



            Console.WriteLine("REF");

            // int valRef;
            // C(ref valRef);

            int valC = 20;
            Console.WriteLine($"In Main before C: valC = {valC}");
            C(ref valC);
            Console.WriteLine($"In Main after C: valC = {valC}\n");

            Console.WriteLine("PARAMS");
            int sum1 = SumValues(1, 2, 3);
            int sum2 = SumValues(10, 20, 30, 40, 50);
            int sum3 = SumValues(5);

            Console.WriteLine($"SumValues(1, 2, 3) = {sum1}");
            Console.WriteLine($"SumValues(10, 20, 30, 40, 50) = {sum2}");
            Console.WriteLine($"SumValues(5) = {sum3}");
        }
    }
}

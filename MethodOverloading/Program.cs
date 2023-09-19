using System.ComponentModel;
using System.IO.Pipes;

namespace MethodOverloading
{
    public class Program
    {
        public static int Add1(int a, int b)
        {
            return a + b;
        }

        public static decimal Add2(decimal c, decimal d)
        {
            return c + d;
        }

        public static string Add3(int a, int b, bool withDollars)
        {
            if (withDollars && (a + b) != 1)
            {
                return $" {a + b} dollars.";
            }
            else if (withDollars && (a + b) == 1)
            {
                return $" {a + b} dollar";
            }
            else
            {
                return $" {a + b} ";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine($" 2 + 5 =  {Add1(2, 5)}");

            Console.WriteLine($" 5.9 + 9.7 = {Add2(5.9m, 9.7m)} ");

            Console.WriteLine($" In your bank account you have: {Add3(15, 37, true)} ");
        }
    }
}
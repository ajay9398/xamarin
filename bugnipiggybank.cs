using System;

namespace helloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no. of 10 rs coin:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter no. of 5 rs coin:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter no. of 2 rs coin:");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter no. of 1 re coin:");
            int num4 = int.Parse(Console.ReadLine());

            int totalamount = (num1 * 10) + (num2 * 5) + (num3 * 2) + (num4 * 1);
            Console.WriteLine("Total Amount :" + totalamount);
            Console.ReadKey();
        }
    }
}

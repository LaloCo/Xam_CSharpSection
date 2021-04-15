using System;

namespace CSharpSection
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(Add(432, 543));

            Console.ReadLine();
        }

        private static int Add(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}

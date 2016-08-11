namespace TypeFundamentals1
{
    using System;

    class Program
    {
        private static void Main(string[] args)
        {
            var p1 = new Person("Alex", "Ivanov");
            var p2 = new Person("Alex", "Ivanov");

            Console.WriteLine(p1.Equals(p2));
            Console.ReadKey();
        }
    }
}



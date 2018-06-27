using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            String name = Console.ReadLine();
            Console.WriteLine("Hello , " + name);

            Console.WriteLine("How many hours of sleep did you get last night?");
            int sleep = int.Parse(Console.ReadLine());

            if(sleep < 8)
            {
                Console.WriteLine("You must be tired");
            }else
            {
                Console.WriteLine("You have slept well");
            }

            Console.ReadLine();
              
        }
    }
}

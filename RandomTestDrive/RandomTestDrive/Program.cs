using System;

namespace RandomTestDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomInt = random.Next();
            Console.WriteLine(randomInt);
        }
    }
}

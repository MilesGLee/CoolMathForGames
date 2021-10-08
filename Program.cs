using System;

namespace CoolMathForGames
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo input = Console.ReadKey(true); ;
            while (input.Key != ConsoleKey.Escape) 
            {
                input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.D) 
                {
                    Console.WriteLine("Yee");
                }
            }
        }
    }
}

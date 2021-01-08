using System;

namespace Task05_Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            int achievedHeight = 5364;
            int day = 1;

            while (achievedHeight < 8848)
            {
                string action = Console.ReadLine();
                if (action == "END")
                {
                    break;
                }
                if (action == "Yes")
                {
                    day += 1;
                }
                
                int nextHeight = int.Parse(Console.ReadLine());
                achievedHeight += nextHeight;
                if (day >= 5)
                {
                    break;
                }
            }
            if (achievedHeight >= 8848)
            {
                Console.WriteLine($"Goal reached for {day} days!");
            }
            if (achievedHeight < 8848)
            {
                Console.WriteLine("Failed!");
                Console.WriteLine(achievedHeight);
            }
        }
    }
}

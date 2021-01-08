using System;

namespace Task02_Illidan
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int oneManPower = int.Parse(Console.ReadLine());
            int illidianPower = int.Parse(Console.ReadLine());

            int peoplePower = people * oneManPower;

            if (peoplePower >= illidianPower)
            {
                Console.WriteLine($"Illidan has been slain! You defeated him with {(peoplePower - illidianPower)} points.");
            }
            else
            {
                Console.WriteLine($"You are not prepared! You need {illidianPower - peoplePower} more points.");
            }
        }
    }
}

using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            double procesorPrise = double.Parse(Console.ReadLine());
            double videoPrise = double.Parse(Console.ReadLine());
            double oneRamPrise = double.Parse(Console.ReadLine());
            int numbersRam = int.Parse(Console.ReadLine());
            double discond = double.Parse(Console.ReadLine());
            double levaPerUsd = 1.57;
            double sum = (procesorPrise * levaPerUsd * (1 - discond)) + (videoPrise * levaPerUsd * (1 - discond)) + (oneRamPrise * numbersRam * levaPerUsd);
            Console.WriteLine($"Money needed - {sum:F2} leva."); 
        }
    }
}

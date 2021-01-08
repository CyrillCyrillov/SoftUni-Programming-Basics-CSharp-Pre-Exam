using System;

namespace Task04_Rate
{
    class Program
    {
        static void Main(string[] args)
        {
            double beginSum = double.Parse(Console.ReadLine());
            int mounts = int.Parse(Console.ReadLine());
            double simpleSum = 0;
            double complexSum = beginSum;

            for (int i = 1; i <= mounts; i++)
            {
                simpleSum = simpleSum + (beginSum * 0.03);
                complexSum = complexSum * 1.027;
            }
            double endSimplelSum = beginSum + simpleSum;
            double endComplexSum = complexSum;
            
            Console.WriteLine($"Simple interest rate: {endSimplelSum:F2} lv.");
            Console.WriteLine($"Complex interest rate: {endComplexSum:F2} lv.");
            
            if (endSimplelSum >= endComplexSum)
            {
                Console.WriteLine($"Choose a simple interest rate. You will win {(endSimplelSum - endComplexSum):F2} lv.");
            }
            if (endComplexSum > endSimplelSum)
            {
                Console.WriteLine($"Choose a complex interest rate. You will win {(endComplexSum - endSimplelSum):F2} lv.");
            }
        }
    }
}

using System;

namespace Task06_Substitute
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int numberSubstitutes = 0;
            
            for (int i = k; i <= 8; i++)
            {
                for (int j = 9; j >= l; j--)
                {
                    for (int x = m; x <= 8; x++)
                    {
                        for (int z = 9; z >= n; z--)
                        {
                            if ((i % 2 == 0) && (x % 2 == 0) && (j % 2 != 0) && (z % 2 != 0))
                            {
                               if (i == x && j == z)
                               {
                                    Console.WriteLine("Cannot change the same player.");
                               }
                               else
                                {
                                    Console.WriteLine($"{i}{j} - {x}{z}");
                                    numberSubstitutes += 1;
                                }
                                if (numberSubstitutes >= 6) break;
                            }
                        }
                        if (numberSubstitutes >= 6) break;
                    }
                    if (numberSubstitutes >= 6) break;
                }
                if (numberSubstitutes >= 6) break;
            }
        }
    }
}

using System;

namespace Task03_Aquapark
{
    class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();
            int hours = int.Parse(Console.ReadLine());
            int numbers = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();
            double pricePerHour = 0;

            switch (mounth)
            {
                case "march":
                case "april":
                case "may":
                    {
                        if (partOfDay == "day")
                        {
                            pricePerHour = 10.5;
                        }
                        else if (partOfDay == "night")
                        {
                            pricePerHour = 8.4;
                        }
                    }
                    break;
                case "june":
                case "july":
                case "august":
                    {
                        if (partOfDay == "day")
                        {
                            pricePerHour = 12.6;
                        }
                        else if (partOfDay == "night")
                        {
                            pricePerHour = 10.2;
                        }
                    }
                    break;
            }

            if (numbers >= 4)
            {
                pricePerHour *= 0.9;
            }
            if (hours >= 5)
            {
                pricePerHour *= 0.5;
            }
            
            
            
            Console.WriteLine($"Price per person for one hour: {pricePerHour:F2}");
            Console.WriteLine($"Total cost of the visit: {(pricePerHour * hours * numbers):F2}");
        }
    }
}

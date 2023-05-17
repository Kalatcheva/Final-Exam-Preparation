using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {

        string place = Console.ReadLine();
        string days = Console.ReadLine();
        int nightsSpent = int.Parse(Console.ReadLine());


        if(place == "France")
        {
            if(days == "21-23")
            {
                int price = nightsSpent * 30;
                Console.WriteLine($"Easter trip to {place} : {price:f2} leva.");
            }
            if (days == "24-27")
            {
                int price = nightsSpent * 35;
                Console.WriteLine($"Easter trip to {place} : {price:f2} leva.");
            }
            if (days == "28-31")
            {
                int price = nightsSpent * 40;
                Console.WriteLine($"Easter trip to {place} : {price:f2} leva.");
            }
        }
        else if(place == "Italy")
        {
            if (days == "21-23")
            {
                int price = nightsSpent * 28;
                Console.WriteLine($"Easter trip to {place} : {price:f2} leva.");
            }
            if (days == "24-27")
            {
                int price = nightsSpent * 32;
                Console.WriteLine($"Easter trip to {place} : {price:f2} leva.");
            }
            if (days == "28-31")
            {
                int price = nightsSpent * 39;
                Console.WriteLine($"Easter trip to {place} : {price:f2} leva.");
            }
        }
        else if(place == "Germany")
        {
            if (days == "21-23")
            {
                int price = nightsSpent * 32;
                Console.WriteLine($"Easter trip to {place} : {price:f2} leva.");
            }
            if (days == "24-27")
            {
                int price = nightsSpent * 37;
                Console.WriteLine($"Easter trip to {place} : {price:f2} leva.");
            }
            if (days == "28-31")
            {
                int price = nightsSpent * 43;
                Console.WriteLine($"Easter trip to {place} : {price:f2} leva.");
            }
            

        }

        


    }
}

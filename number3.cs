// Written by Mahlet Gebremedhin 
// Feb 4 2024 
using System;

class KingdomPointsCalculator
{
    static void Main()
    {
        Console.WriteLine("Welcome, Kings! Let's determine who has the greatest kingdom.");

        // Asking for province, duchy, and estate counts
        Console.Write("Enter the number of provinces you have: ");
        int provinces = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of duchies you have: ");
        int duchies = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of estates you have: ");
        int estates = Convert.ToInt32(Console.ReadLine());

        // Calculating the total score
        int totalPoints = (provinces * 6) + (duchies * 3) + (estates * 1);

        // Displaying the result
        Console.WriteLine($"\nYour total kingdom score is: {totalPoints} points!");

        Console.WriteLine("\nMay the greatest king reign supreme!");
    }
}


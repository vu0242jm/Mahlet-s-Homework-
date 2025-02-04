// Written by Mahlet Gebremedhin
// Feb 4 2025

using System;

class ChocolateEggsDivider
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Chocolate Egg Divider!");

        // Asking for the total number of chocolate eggs collected
        Console.Write("Enter the number of chocolate eggs collected today: ");
        int totalEggs = Convert.ToInt32(Console.ReadLine());

        // There are 4 sisters
        int numberOfSisters = 4;

        // Calculating eggs per sister
        int eggsPerSister = totalEggs / numberOfSisters;

        // Calculating leftover eggs for the duckbear
        int duckbearEggs = totalEggs % numberOfSisters;

        // Displaying results in a very beginner-friendly way
        Console.WriteLine("\nCalculating the distribution...");
        Console.WriteLine("Each sister gets: " + eggsPerSister + " eggs.");
        Console.WriteLine("The duckbear gets the leftover: " + duckbearEggs + " eggs.");

        Console.WriteLine("\nThank you for using the Chocolate Egg Divider!");

        // Finding three total egg counts where the duckbear gets more than a sister
        Console.WriteLine("\nFinding three cases where the duckbear gets more eggs than each sister...");

        for (int testEggs = 1; testEggs <= 100; testEggs++)  // Brute force checking up to 100 eggs
        {
            int testSisterEggs = testEggs / numberOfSisters;
            int testDuckbearEggs = testEggs % numberOfSisters;

            if (testDuckbearEggs > testSisterEggs)
            {
                Console.WriteLine($"Case Found! Total Eggs: {testEggs} | Sisters get: {testSisterEggs} | Duckbear gets: {testDuckbearEggs}");
            }
        }
    }
}



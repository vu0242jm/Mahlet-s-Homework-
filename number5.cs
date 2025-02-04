// Written by Mahlet Gebremedhin
// Feb 4 2024 
using System;

class ClocktowerRepair
{
    static void Main()
    {
        Console.WriteLine("Repairing the Clocktower of Consolas!");

        // Ask the user for a number
        Console.Write("Enter a number to keep the clock running: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Determine if the number is even or odd using the modulus operator (%)
        if (number % 2 == 0)
        {
            Console.WriteLine("Tick"); // Even number → Tick
        }
        else
        {
            Console.WriteLine("Tock"); // Odd number → Tock
        }

        Console.WriteLine("\nThe Clocktower is back in motion!");
    }
}




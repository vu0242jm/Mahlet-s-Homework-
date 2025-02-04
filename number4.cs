//Written by Mahlet Gebremedhin 
// Feb 4, 2024 

using System;

class DefenseOfConsolas
{
    static void Main()
    {
        // Change the console title
        Console.Title = "Defense of Consolas";

        Console.WriteLine("The City of Consolas is under attack!");
        Console.WriteLine("We need to deploy defenses around the target block.\n");

        // Ask for the target row and column
        Console.Write("Target Row? ");
        int targetRow = Convert.ToInt32(Console.ReadLine());

        Console.Write("Target Column? ");
        int targetColumn = Convert.ToInt32(Console.ReadLine());

        // Compute deployment positions
        int leftRow = targetRow;
        int leftCol = targetColumn - 1;

        int rightRow = targetRow;
        int rightCol = targetColumn + 1;

        int topRow = targetRow - 1;
        int topCol = targetColumn;

        int bottomRow = targetRow + 1;
        int bottomCol = targetColumn;

        // Change text color for deployment instructions
        Console.ForegroundColor = ConsoleColor.Green;

        // Display the deployment locations
        Console.WriteLine("\nDeploy to:");
        Console.WriteLine($"({leftRow}, {leftCol})");
        Console.WriteLine($"({topRow}, {topCol})");
        Console.WriteLine($"({rightRow}, {rightCol})");
        Console.WriteLine($"({bottomRow}, {bottomCol})");

        // Reset text color to default
        Console.ResetColor();

        // Play a beep sound to indicate completion
        Console.Beep();

        Console.WriteLine("\nThe city is defended! Stand by for further orders.");
    }
}



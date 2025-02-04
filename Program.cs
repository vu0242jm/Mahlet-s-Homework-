// written by Mahlet Gebremedhin
// Feb 4 2024 
using System;
class TriangleAreaCalculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to P-Thag's Triangle Area Calculator!");

        // Prompt user for base input
        Console.Write("Enter the base of the triangle: ");
        double baseSize = Convert.ToDouble(Console.ReadLine());

        // Prompt user for height input
        Console.Write("Enter the height of the triangle: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Compute the area using the formula: (b * h) / 2
        double area = (baseSize * height) / 2;

        // Display the result
        Console.WriteLine($"\nThe area of the triangle is: {area} square units.");

        Console.WriteLine("\nThank you for helping P-Thag!");
    }
}

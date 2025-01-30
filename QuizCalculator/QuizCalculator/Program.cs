
//written by Mahlet 
// 1/7/2025

namespace QuizCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {

            QuizCalculatorA aQuizCalculator = new QuizCalculatorA();

            aQuizCalculator.Quiz1 = 80.0;
            aQuizCalculator.Quiz2 = 85.0;
            aQuizCalculator.Quiz3 = 90.0;
            aQuizCalculator.Quiz4 = 85.0;

            Console.WriteLine("Total:" + aQuizCalculator.CalcTotal());
            Console.WriteLine("Average:" + aQuizCalculator.CalcAverage());
            Console.WriteLine("")

            Console.WriteLine("Hello, World!");
        }
    }
}

using System;

namespace Т04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            int students = 0;
            double evaluation = 0;
            double personalEvaluation;

            while (presentation != "Finish")
            {
                personalEvaluation = 0;
                for (int i = 1; i <= n; i++)
                {
                    personalEvaluation += double.Parse(Console.ReadLine());
                }
                personalEvaluation = personalEvaluation / n;
                Console.WriteLine($"{presentation} - {personalEvaluation:F2}.");
                students++;

                evaluation += personalEvaluation;
                presentation = Console.ReadLine();
            }
            evaluation = evaluation / students;
            Console.WriteLine($"Student's final assessment is {evaluation:F2}.");
        }
    }
}

using System;

namespace oop_assignment_2_2025_77804.Exam.Questions
{
    public static class ExamQuestion_4B
    {
        public static string FormatPrice(double price)
        {
            return price.ToString("€#,0.00");
        }

        public static void Run()
        {
            Console.WriteLine("Question 4B:");
            Console.WriteLine(FormatPrice(1500));
            Console.WriteLine();
        }
    }
}

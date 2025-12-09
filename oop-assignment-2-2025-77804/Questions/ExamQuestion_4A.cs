using System;

namespace oop_assignment_2_2025_77804.Exam.Questions
{
    public static class ExamQuestion_4A
    {
        public static string FormatFiveDigits(int num)
        {
            return num.ToString("D5");
        }

        public static void Run()
        {
            Console.WriteLine("Question 4A:");
            Console.WriteLine(FormatFiveDigits(15));
            Console.WriteLine();
        }
    }
}

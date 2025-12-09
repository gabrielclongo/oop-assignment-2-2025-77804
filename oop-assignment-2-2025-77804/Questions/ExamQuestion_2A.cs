using System;

namespace oop_assignment_2_2025_77804.Exam.Questions
{
    public static class ExamQuestion_2A
    {
        public static string Divide(int a, int b)
        {
            try
            {
                return (a / b).ToString();
            }
            catch (DivideByZeroException)
            {
                return "Cannot divide by 0";
            }
        }

        public static void Run()
        {
            Console.WriteLine("Question 2A:");
            Console.WriteLine(Divide(8, 2));
            Console.WriteLine();
        }
    }
}

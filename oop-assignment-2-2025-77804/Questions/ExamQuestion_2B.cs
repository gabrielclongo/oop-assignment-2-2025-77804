using System;

namespace oop_assignment_2_2025_77804.Exam.Questions
{
    public static class ExamQuestion_2B
    {
        public static string ConvertToInt(string input)
        {
            try
            {
                int n = int.Parse(input);
                return n.ToString();
            }
            catch
            {
                return "Invalid number entered.";
            }
        }

        public static void Run()
        {
            Console.WriteLine("Question 2B:");
            Console.WriteLine(ConvertToInt("120"));
            Console.WriteLine();
        }
    }
}

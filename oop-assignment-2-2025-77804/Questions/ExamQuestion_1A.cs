using System;
using System.Text.RegularExpressions;

namespace oop_assignment_2_2025_77804.Exam.Questions
{
    public static class ExamQuestion_1A
    {
        public static bool IsValidIrishMobile(string phone)
        {
            string pattern = @"^(083|085|089)\d{7}$";
            return Regex.IsMatch(phone, pattern);
        }

        public static void Run()
        {
            Console.WriteLine("Question 1A:");
            Console.WriteLine(IsValidIrishMobile("0831234567"));
            Console.WriteLine();
        }
    }
}

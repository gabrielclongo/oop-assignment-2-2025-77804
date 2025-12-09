using System;

namespace oop_assignment_2_2025_77804.Exam.Questions
{
    public static class ExamQuestion_2C
    {
        public static string RegisterUser(int age)
        {
            try
            {
                if (age < 18)
                    throw new ArgumentOutOfRangeException();

                return "Successfully registred!";
            }
            catch (ArgumentOutOfRangeException)
            {
                return "You must be at least 18 to register!";
            }
        }

        public static void Run()
        {
            Console.WriteLine("Question 2C:");
            Console.WriteLine(RegisterUser(17));
            Console.WriteLine();
        }
    }
}

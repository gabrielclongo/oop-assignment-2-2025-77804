using System;

namespace oop_assignment_2_2025_77804.Exam.Questions
{
    public static class ExamQuestion_1B
    {
        public static int GetDiscount(string level)
        {
            return level.ToLower() switch
            {
                "bronze" => 5,
                "silver" => 10,
                "gold" => 15,
                "platinum" => 20,
                _ => 0
            };
        }

        public static void Run()
        {
            Console.WriteLine("Question 1B:");
            Console.WriteLine(GetDiscount("platinum"));
            Console.WriteLine();
        }
    }
}

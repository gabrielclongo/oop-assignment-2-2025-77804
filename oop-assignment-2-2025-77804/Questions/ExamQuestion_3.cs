using System;
using System.Collections.Generic;
using System.Linq;

namespace oop_assignment_2_2025_77804.Exam.Questions
{
    public static class ExamQuestion_3
    {
        public static double GetAverage(List<int> ratings)
        {
            if (ratings.Count == 0) return 0;
            return Math.Round(ratings.Average(), 1);
        }

        public static void Run()
        {
            Console.WriteLine("Question 3:");

            var products = new List<(string Name, List<int> Ratings)>
            {
                ("Laptop", new List<int>{5,4,4,5,3}),
                ("Headphones", new List<int>{4,3,5}),
                ("Keyboard", new List<int>{5,5,5,4}),
                ("Mouse", new List<int>{3,3,4}),
                ("EmptyProduct", new List<int>())
            };

            double bestAvg = 0;
            string bestName = "";

            foreach (var p in products)
            {
                if (p.Ratings.Count == 0)
                {
                    Console.WriteLine($"{p.Name}: No ratings available");
                    continue;
                }

                double avg = GetAverage(p.Ratings);
                Console.WriteLine($"{p.Name}: Average Rating = {avg}");

                if (avg > bestAvg)
                {
                    bestAvg = avg;
                    bestName = p.Name;
                }
            }

            Console.WriteLine($"The top-rated product is {bestName} with an average rating of {bestAvg}\n");
        }
    }
}

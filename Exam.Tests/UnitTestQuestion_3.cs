using Xunit;
using System.Collections.Generic;
using oop_assignment_2_2025_77804.Exam.Questions;

namespace oop_assignment_2_2025_77804.Tests
{
    public class UnitTestQuestion_3
    {
        [Fact]
        public void TestAverageAndEmpty()
        {
            Assert.Equal(4.2, ExamQuestion_3.GetAverage(new List<int> { 5, 4, 4, 5, 3 }));
            Assert.Equal(0, ExamQuestion_3.GetAverage(new List<int>()));
        }
    }
}

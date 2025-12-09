using Xunit;
using oop_assignment_2_2025_77804.Exam.Questions;

namespace oop_assignment_2_2025_77804.Tests
{
    public class UnitTestQuestion_2A
    {
        [Fact]
        public void TestDivideByZero()
        {
            Assert.Equal("Cannot divide by 0", ExamQuestion_2A.Divide(10, 0));
        }
    }
}

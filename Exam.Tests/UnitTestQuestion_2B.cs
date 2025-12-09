using Xunit;
using oop_assignment_2_2025_77804.Exam.Questions;

namespace oop_assignment_2_2025_77804.Tests
{
    public class UnitTestQuestion_2B
    {
        [Fact]
        public void TestInvalidConversion()
        {
            Assert.Equal("The entered number is invalid!", ExamQuestion_2B.ConvertToInt("abc"));
        }
    }
}

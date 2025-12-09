using Xunit;
using oop_assignment_2_2025_77804.Exam.Questions;

namespace oop_assignment_2_2025_77804.Tests
{
    public class UnitTestQuestion_1A
    {
        [Theory]
        [InlineData("0831234567", true)]
        [InlineData("0899988776", true)]
        [InlineData("0812345678", false)]
        [InlineData("083 1234567", false)]
        [InlineData("08312345678", false)]
        public void TestIrishMobiles(string input, bool expected)
        {
            Assert.Equal(expected, ExamQuestion_1A.IsValidIrishMobile(input));
        }
    }
}

using Xunit;
using oop_assignment_2_2025_77804.Exam.Questions;

namespace oop_assignment_2_2025_77804.Tests
{
    public class UnitTestQuestion_4A
    {
        [Fact]
        public void TestPadFiveDigits()
        {
            Assert.Equal("00015", ExamQuestion_4A.FormatFiveDigits(15));
        }
    }
}

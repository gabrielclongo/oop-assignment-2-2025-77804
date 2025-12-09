using Xunit;
using oop_assignment_2_2025_77804.Exam.Questions;

namespace oop_assignment_2_2025_77804.Tests
{
    public class UnitTestQuestion_4B
    {
        [Fact]
        public void TestPriceFormat()
        {
            Assert.Equal("€1,500.00", ExamQuestion_4B.FormatPrice(1500.0));
        }
    }
}

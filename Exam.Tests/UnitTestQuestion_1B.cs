using Xunit;
using oop_assignment_2_2025_77804.Exam.Questions;

namespace oop_assignment_2_2025_77804.Tests
{
    public class UnitTestQuestion_1B
    {
        [Fact]
        public void TestDiscounts()
        {
            Assert.Equal(15, ExamQuestion_1B.GetDiscount("platinum"));
            Assert.Equal(0, ExamQuestion_1B.GetDiscount("invalid"));
        }
    }
}

using Xunit;
using oop_assignment_2_2025_77804.Exam.Questions;

namespace oop_assignment_2_2025_77804.Tests
{
    public class UnitTestQuestion_2C
    {
        [Fact]
        public void TestUnderage()
        {
            Assert.Equal("You must be at least 18 to register!", ExamQuestion_2C.RegisterUser(17));
        }
    }
}

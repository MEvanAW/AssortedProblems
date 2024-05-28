using QuestionsMarks;

namespace AssortedProblemsTests
{
    public class QuestionsMarksUnitTest
    {
        [Fact]
        public void FalseTest()
        {
            Assert.Equal(PatternChecker.FALSE_STRING, PatternChecker.QuestionsMarks("aa6?9"));
        }

        [Fact]
        public void TrueTest()
        {
            Assert.Equal(PatternChecker.TRUE_STRING, PatternChecker.QuestionsMarks("acc?7??sss?3rr1??????5"));
        }
    }
}

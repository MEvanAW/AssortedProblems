using Intersection;

namespace AssortedProblemsTests
{
    public class IntersectionUnitTest
    {
        [Fact]
        public void IntersectionExistTest()
        {
            var strArr = new string[] { "1, 3, 4, 7, 13", "1, 2, 4, 13, 15" };
            Assert.Equal("1,4,13", IntersectionFinder.FindIntersection(strArr));
            strArr = new string[] { "1, 3, 9, 10, 17, 18", "1, 4, 9, 10" };
            Assert.Equal("1,9,10", IntersectionFinder.FindIntersection(strArr));
        }

        [Fact]
        public void IntersectionDoesNotExistTest()
        {
            var strArr = new string[] { "1, 3", "2, 4" };
            Assert.Equal(IntersectionFinder.FALSE_STRING, IntersectionFinder.FindIntersection(strArr));
        }
    }
}

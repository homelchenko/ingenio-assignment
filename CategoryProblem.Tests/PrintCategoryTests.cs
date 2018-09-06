using Xunit;

namespace CategoryProblem.Tests
{
    public class PrintCategoryTests
    {
        [Fact]
        public void WhenProvidedRootCategoryContainingKeyword_ShouldReturnAllOwnProperties()
        {
            // Act
            string print = Solution.PrintCategory(100);

            // Assert
            Assert.Equal("ParentCategoryID=-1,Name=Business,Keywords=Money", print);
        }
    }
}

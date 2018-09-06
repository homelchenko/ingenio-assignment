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

        [Fact]
        public void WhenProvidedCategoryContainingKeyword_ShouldReturnAllOwnProperties()
        {
            // Act
            string print = Solution.PrintCategory(101);

            // Assert
            Assert.Equal("ParentCategoryID=100,Name=Accounting,Keywords=Taxes", print);
        }
    }
}

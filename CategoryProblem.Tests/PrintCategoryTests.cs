using Xunit;

namespace CategoryProblem.Tests
{
    public class PrintCategoryTests
    {
        [Fact]
        public void WhenProvidedRootCategoryContainingKeyword_ShouldReturnAllOwnProperties()
        {
            // Act
            string print = PrintCategory(100);

            // Assert
            Assert.Equal("ParentCategoryID=-1,Name=Business,Keywords=Money", print);
        }

        [Fact]
        public void WhenProvidedCategoryContainingKeyword_ShouldReturnAllOwnProperties()
        {
            // Act
            string print = PrintCategory(101);

            // Assert
            Assert.Equal("ParentCategoryID=100,Name=Accounting,Keywords=Taxes", print);
        }

        [Fact]
        public void WhenProvidedRootChildCategoryWithoutKeyword_ShouldReturnAllOwnPropertiesAndRootsKeyword()
        {
            // Act
            string print = PrintCategory(201);

            // Assert
            Assert.Equal("ParentCategoryID=200,Name=Computer,Keywords=Teaching", print);
        }

        private string PrintCategory(int categoryId)
        {
            return new Solution().PrintCategory(categoryId);
        }
    }
}

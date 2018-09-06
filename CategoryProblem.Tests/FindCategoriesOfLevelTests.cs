using Xunit;

namespace CategoryProblem.Tests
{
    public class FindCategoriesOfLevelTests
    {
        [Fact]
        public void WhenRootLevel_ShouldReturnAllRootCategories()
        {
            // Act
            int[] categories = new Solution().FindCategoriesOfLevel(1);

            // Assert
            Assert.Equal(new[] {100, 200 }, categories);
        }
    }
}

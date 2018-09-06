using Xunit;

namespace CategoryProblem.Tests
{
    public class FindCategoriesOfLevelTests
    {
        [Fact]
        public void WhenRootLevel_ShouldReturnAllRootCategories()
        {
            // Act
            int[] categories = FindCategoriesOfLevel(1);

            // Assert
            Assert.Equal(new[] {100, 200 }, categories);
        }

        [Fact]
        public void When2ndLevel_ShouldReturnRootChildren()
        {
            // Act
            int[] categories = FindCategoriesOfLevel(2);

            // Assert
            Assert.Equal(new[] {101, 102, 201 }, categories);
        }

        [Fact]
        public void When3rdLevel_ShouldReturnRootGrandChildren()
        {
            // Act
            int[] categories = FindCategoriesOfLevel(3);

            // Assert
            Assert.Equal(new[] {103, 109, 202 }, categories);
        }

        [Fact]
        public void When4thLevel_ShouldReturnEmpty()
        {
            // Act
            int[] categories = FindCategoriesOfLevel(4);

            // Assert
            Assert.Equal(new int[0], categories);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void WhenWrongLevel_ShouldReturnEmpty(int wrongLevel)
        {
            // Act
            int[] categories = FindCategoriesOfLevel(wrongLevel);

            // Assert
            Assert.Equal(new int[0], categories);
        }

        private static int[] FindCategoriesOfLevel(int level)
        {
            return new Solution().FindCategoriesOfLevel(level);
        }
    }
}

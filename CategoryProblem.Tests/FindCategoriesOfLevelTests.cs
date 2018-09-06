﻿using Xunit;

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

        private static int[] FindCategoriesOfLevel(int level)
        {
            return new Solution().FindCategoriesOfLevel(level);
        }
    }
}

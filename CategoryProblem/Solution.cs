using System.Collections.Generic;

namespace CategoryProblem
{
    public class Solution
    {
        private readonly List<Category> _categories;

        public Solution()
        {
            _categories = new List<Category>()
            {
                new Category { Id = 100, ParentId = -1, Name = "Business", Keywords = "Money" },
                new Category { Id = 101, ParentId = 100, Name = "Accounting", Keywords = "Taxes" }
            };
        }

        public string PrintCategory(int categoryId)
        {
            Category category = _categories.Find(c => c.Id == categoryId);

            return $"ParentCategoryID={category.ParentId},Name={category.Name},Keywords={category.Keywords}";
        }

        private class Category
        {
            public int Id { get; set; }

            public int ParentId { get; set; }

            public string Name { get; set; }

            public string Keywords { get; set; }
        }
    }
}

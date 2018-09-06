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
                new Category { Id = 101, ParentId = 100, Name = "Accounting", Keywords = "Taxes" },
                new Category { Id = 200, ParentId = -1, Name = "Tutoring", Keywords = "Teaching" },
                new Category { Id = 201, ParentId = 200, Name = "Computer" },
            };
        }

        public string PrintCategory(int categoryId)
        {
            Category category = FindCategory(categoryId);

            if (string.IsNullOrEmpty(category.Keywords))
            {
                Category parent = FindKeywordfulParent(category.ParentId);

                return $"ParentCategoryID={category.ParentId},Name={category.Name},Keywords={parent.Keywords}";
            }

            return $"ParentCategoryID={category.ParentId},Name={category.Name},Keywords={category.Keywords}";
        }

        private Category FindKeywordfulParent(int parentId)
        {
            Category category = FindCategory(parentId);

            if (string.IsNullOrEmpty(category.Keywords))
            {
                category = FindCategory(category.ParentId);
            }

            return category;
        }

        private Category FindCategory(int categoryId)
        {
            return _categories.Find(c => c.Id == categoryId);
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

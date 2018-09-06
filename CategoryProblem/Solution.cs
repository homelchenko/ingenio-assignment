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
                new Category { Id = 200, ParentId = -1, Name = "Tutoring", Keywords = "Teaching" },
                new Category { Id = 101, ParentId = 100, Name = "Accounting", Keywords = "Taxes" },
                new Category { Id = 102, ParentId = 100, Name = "Taxation" },
                new Category { Id = 201, ParentId = 200, Name = "Computer" },
                new Category { Id = 103, ParentId = 101, Name = "Taxation" },
                new Category { Id = 202, ParentId = 201, Name = "Operating System" },
                new Category { Id = 109, ParentId = 101, Name = "Small Business Tax" },
            };
        }

        public string PrintCategory(int categoryId)
        {
            Category category = FindCategory(categoryId);

            if (category == null)
            { 
                return string.Empty;
            }

            if (string.IsNullOrEmpty(category.Keywords))
            {
                Category ancestor = FindKeywordfulParent(category.ParentId);

                return GetPrintableString(category.ParentId, category.Name, ancestor.Keywords);
            }

            return GetPrintableString(category.ParentId, category.Name, category.Keywords);
        }

        private Category FindKeywordfulParent(int parentId)
        {
            Category category = FindCategory(parentId);

            if (string.IsNullOrEmpty(category.Keywords))
            {
                category = FindKeywordfulParent(category.ParentId);
            }

            return category;
        }

        private Category FindCategory(int categoryId)
        {
            return _categories.Find(c => c.Id == categoryId);
        }

        private string GetPrintableString(int parentId, string name, string keywords)
        { 
            return $"ParentCategoryID={parentId}, Name={name}, Keywords={keywords}";
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

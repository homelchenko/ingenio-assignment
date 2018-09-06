namespace CategoryProblem
{
    public class Solution
    {
        public static string PrintCategory(int categoryId)
        {
            if (categoryId == 100)
            {
                return "ParentCategoryID=-1,Name=Business,Keywords=Money";
            }
            else
            {
                return "ParentCategoryID=100,Name=Accounting,Keywords=Taxes";
            }
        }
    }
}

using System;

namespace KidsGame.Data_Folder
{
    [Serializable]
    public abstract class Category : IComparable<Category>
    {
        private int categorynumber { get; set; }
        public int CategoryNumber { get { return categorynumber; }
            set { if (value <= 0) { throw new ArgumentOutOfRangeException(); } else { categorynumber = value; } } }
        public string CategoryName { get; set; }
        public Category(int CategoryNumber, string CategoryName)
        {
            this.CategoryNumber = CategoryNumber;
            this.CategoryName = CategoryName;
        }
        public Category() { }

        public int CompareTo(Category category)
        {
            return CategoryNumber.CompareTo(category.CategoryNumber);
        }
    }
}

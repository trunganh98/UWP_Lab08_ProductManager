using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_ProductsCategory.Model
{
    public class CategoryItem
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string HeadLine { get; set; }
        public string Subhead { get; set; }
        public string DeadLine { get; set; }
        public string Image { get; set; }
    }

    public class NewsManager
    {

        public static void GetCategorys(string category, ObservableCollection<CategoryItem> categoryItems)
        {
            var allItems = GetCategoryItems();
            var filteredCategoryItems = allItems
                .Where(p => p.Category == category)
                .ToList();
            categoryItems.Clear();
            filteredCategoryItems.ForEach(p => categoryItems.Add(p));
        }

        private static List<CategoryItem> GetCategoryItems()
        {
            var Item = new List<CategoryItem>();
            Item.Add(new CategoryItem() { Id = 1, Category = "Laptop", HeadLine = "DEll", DeadLine = "13/10/2020", Image = "Assets/laptop1.jpg", Subhead = "DELL Gaming" });
            Item.Add(new CategoryItem() { Id = 2, Category = "Laptop", HeadLine = "MSI", DeadLine = "15/10/2020", Image = "Assets/laptop2.jpg", Subhead = "MSI Gaming" });
            Item.Add(new CategoryItem() { Id = 3, Category = "Laptop", HeadLine = "ASUS", DeadLine = "14/10/2020", Image = "Assets/laptop3.jpg", Subhead = "ASUS Gaming" });
            Item.Add(new CategoryItem() { Id = 4, Category = "Laptop", HeadLine = "ACER", DeadLine = "11/10/2020", Image = "Assets/laptop4.jpg", Subhead = "Acer Gaming" });
            Item.Add(new CategoryItem() { Id = 5, Category = "Laptop", HeadLine = "ASUS", DeadLine = "12/10/2020", Image = "Assets/laptop5.jpg", Subhead = "ASUS Gaming" });

            Item.Add(new CategoryItem() { Id = 6, Category = "Product", HeadLine = "ABC", DeadLine = "12/11/2020", Image = "Assets/icon1.png", Subhead = "Product1" });
            Item.Add(new CategoryItem() { Id = 7, Category = "Product", HeadLine = "DEF", DeadLine = "21/12/2020", Image = "Assets/icon2.png", Subhead = "Product2" });
            Item.Add(new CategoryItem() { Id = 8, Category = "Product", HeadLine = "GHJ", DeadLine = "13/10/2020", Image = "Assets/icon3.jfif", Subhead = "Product3" });
            Item.Add(new CategoryItem() { Id = 9, Category = "Product", HeadLine = "IKL", DeadLine = "16/10/2020", Image = "Assets/icon4.png", Subhead = "Product4" });
            Item.Add(new CategoryItem() { Id = 10, Category = "Product", HeadLine = "XYZ", DeadLine = "18/10/2020", Image = "Assets/icon6.png", Subhead = "Product5" });
            return Item;
        }
    }
}

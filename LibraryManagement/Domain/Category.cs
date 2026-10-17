using System;

namespace LibraryManagement.Domain
{
    public class Category
    {
        public string CategoryId { get; private set; }
        public string Name { get; private set; }

        private Category(string categoryId, string name)
        {
            CategoryId = categoryId;
            Name = name;
        }

        public static Category Create(string categoryId, string name)
        {
            if (string.IsNullOrWhiteSpace(categoryId))
                throw new ArgumentException("Mã thể loại không được để trống!");

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Tên thể loại không được để trống!");

            return new Category(categoryId, name);
        }
    }
}
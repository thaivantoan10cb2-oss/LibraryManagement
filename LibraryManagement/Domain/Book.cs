using System;

namespace LibraryManagement.Domain
{
    public class Book
    {
        public string BookId { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public Category Category { get; private set; } // Khóa ngoại

        private Book(string bookId, string title, string author, Category category)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            Category = category;
        }

        public static Book Create(string bookId, string title, string author, Category category)
        {
            if (string.IsNullOrWhiteSpace(bookId))
                throw new ArgumentException("Mã sách không được để trống!");

            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Tên sách không được để trống!");

            if (category == null)
                throw new ArgumentException("Sách phải thuộc một thể loại!");

            return new Book(bookId, title, author, category);
        }
    }
}
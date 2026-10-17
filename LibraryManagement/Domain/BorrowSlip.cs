using System;

namespace LibraryManagement.Domain
{
    public class BorrowSlip
    {
        public string SlipId { get; private set; }
        public DateTime BorrowDate { get; private set; }
        public DateTime DueDate { get; private set; }
        public Reader Reader { get; private set; } // Khóa ngoại
        public Book Book { get; private set; }     // Khóa ngoại

        private BorrowSlip(string slipId, DateTime borrowDate, DateTime dueDate, Reader reader, Book book)
        {
            SlipId = slipId;
            BorrowDate = borrowDate;
            DueDate = dueDate;
            Reader = reader;
            Book = book;
        }

        public static BorrowSlip Create(string slipId, DateTime borrowDate, Reader reader, Book book)
        {
            if (string.IsNullOrWhiteSpace(slipId))
                throw new ArgumentException("Mã phiếu mượn không được để trống!");

            if (reader == null)
                throw new ArgumentException("Phiếu mượn phải có thông tin độc giả!");

            if (book == null)
                throw new ArgumentException("Phiếu mượn phải có thông tin sách!");

            // Tự động tính hạn trả là 7 ngày kể từ ngày mượn
            DateTime dueDate = borrowDate.AddDays(7);

            return new BorrowSlip(slipId, borrowDate, dueDate, reader, book);
        }
    }
}
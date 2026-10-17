using System;

namespace LibraryManagement.Domain
{
    public class Reader
    {
        public string ReaderId { get; private set; }
        public string FullName { get; private set; }
        public string Phone { get; private set; }

        private Reader(string readerId, string fullName, string phone)
        {
            ReaderId = readerId;
            FullName = fullName;
            Phone = phone;
        }

        public static Reader Create(string readerId, string fullName, string phone)
        {
            if (string.IsNullOrWhiteSpace(readerId))
                throw new ArgumentException("Mã độc giả không được để trống!");

            if (string.IsNullOrWhiteSpace(fullName))
                throw new ArgumentException("Tên độc giả không được để trống!");

            if (string.IsNullOrWhiteSpace(phone) || phone.Length < 10)
                throw new ArgumentException("Số điện thoại không hợp lệ (phải từ 10 số)!");

            return new Reader(readerId, fullName, phone);
        }
    }
}
using System;

namespace LibraryManagement.Domain
{
    public class Librarian
    {
        public string LibId { get; private set; }
        public string Name { get; private set; }

        private Librarian(string libId, string name)
        {
            LibId = libId;
            Name = name;
        }

        public static Librarian Create(string libId, string name)
        {
            if (string.IsNullOrWhiteSpace(libId))
                throw new ArgumentException("Mã thủ thư không được để trống!");

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Tên thủ thư không được để trống!");

            return new Librarian(libId, name);
        }
    }
}
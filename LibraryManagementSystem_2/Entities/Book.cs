using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LibraryManagementSystem_2.Entities
{
    public class Book
    {
        public int BookID {  get; set; }
        public string BookName { get; set; } = string.Empty;
        public int PageCount {  get; set; }
        public int CategoryID {  get; set; }
        public int AuthorID {  get; set; }
        public bool IsBorrowed { get; set; }

        // EKLENECEK KISIM: WinForms'a ekranda ne göstereceğini kesin olarak söylüyoruz  *bookta Library Managementsystem yazıyordu*
        public override string ToString()
        {
            return BookName;
        }
    }
}

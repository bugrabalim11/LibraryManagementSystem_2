using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LibraryManagementSystem_2.Entities
{
    public class Author
    {
        public int AuthorID {  get; set; }
        public string AuthorName { get; set; } = string.Empty;
        public string AuthorSurname { get; set; } = string.Empty;
    }
}

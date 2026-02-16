using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem_2.Entities
{
    public class Category
    {
        public int CategoryID {  get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public bool Status {  get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem_2.Entities
{
    public class Member
    {
        public int MemberID {  get; set; }
        public string MemberName { get; set; } = string.Empty;
        public string MemberSurname { get; set; } = string.Empty;
        public string MemberEmail { get; set; } = string.Empty;
        public string MemberPhone { get; set; } = string.Empty;

        public override string ToString()
        {
            return MemberName;
        }
    }
}

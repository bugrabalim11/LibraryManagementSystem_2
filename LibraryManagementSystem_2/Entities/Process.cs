using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem_2.Entities
{
    public class Process
    {
        public int ProcessID {  get; set; }
        public int BookID {  get; set; }
        public int MemberID {  get; set; }
        public DateTime StartDate {  get; set; }
        public DateTime EndDate { get; set; }
        public bool IsReturned {  get; set; }



        // Yanına '?' ekleyerek nullable yapıyoruz, böylece CS8618 uyarısı gider.
        public virtual Book? Book { get; set; }
        public virtual Member? Member { get; set; }
    }
}

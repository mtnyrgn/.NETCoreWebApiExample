using System;
using System.Collections.Generic;
using System.Text;

namespace Data.StudentData
{
    public class Student : BaseEntity
    {
        public string StudentIdentityNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}

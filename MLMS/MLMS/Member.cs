using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLMS
{
    internal class Member
    {
        public int MemberId { get; set; }  // Auto-incremented primary key
        public string FullName { get; set; }  // Member's full name
        public string Address { get; set; }  // Member's address (optional)
        public DateTime? DOB { get; set; }  // Member's Date of Birth (optional)
        public string PhoneNumber { get; set; }  // Member's phone number (optional)
        public string Email { get; set; }  // Member's email (unique)
        public string Password { get; set; }  // Member's password (hashed)
    }
}

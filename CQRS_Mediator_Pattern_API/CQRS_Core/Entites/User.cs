using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Core.Entites
{
    public class User : IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
   public class Profile
    { 
        public int Id { get; set; }
        public string Address { get; set; }
        public int UserId { get; set; }
        public string Phone { get; set; }
        public string Photo { get; set; }
        public string LocalGovt { get; set; }
        public Users User { get; set; }
    }
}

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Photo { get; set; }
        public string LocalGovt { get; set; }

        // Reference to the User
        public User User { get; set; }
    }
}

 */
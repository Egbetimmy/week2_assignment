using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
   public class Users
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public Users(int userId, string userName, string email)
        {
            UserId = userId;
            UserName = userName;
            Email = email;
        }

        public Users()
        {
            // Default constructor
        }
    }
}

using Assignment.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Models;

namespace Assignment.Repository
{
    // User class implementing IUser interface
    public class UserRepository : IUser
    {
        private List<User> users = new List<User>();

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void EditUser(int userId, User updatedUser)
        {
            var userIndex = users.FindIndex(u => u.Id == userId);
            if (userIndex != -1)
            {
                users[userIndex] = updatedUser;
            }
        }

        public User ViewUser(int userId)
        {
            return users.FirstOrDefault(u => u.Id == userId);
        }
    }
}


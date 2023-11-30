using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.IRepository
{
    // Interface for User
    public interface IUser
    {
        void AddUser(User user);
        void EditUser(int userId, User updatedUser);
        User ViewUser(int userId);
    }
}

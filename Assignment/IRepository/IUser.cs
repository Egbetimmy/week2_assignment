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
        string AddUser(Users userList);
        List<Users> GetAllUser();
        void EditUser(int userId);
        void DeleteUser(int userId);
        void ViewUser(int userId);
    }
}

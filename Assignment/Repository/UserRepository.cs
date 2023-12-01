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
        private List<Users> users;

        public UserRepository()
        {
            users = new List<Users>();
        }

        public string AddUser(Users userList)
        {
            users.Add(userList);
            return "User added successfully";
        }

        public List<Users> GetAllUser()
        {
            return users;
        }

        public void ViewUser(int userId)
        {
            var user = users.Find(u => u.UserId == userId);
            if (user != null)
            {
                Console.WriteLine($"User ID: {user.UserId}, UserName: {user.UserName}, Email: {user.Email}");

                // Check if user profile exists and display profile details
                if (user.UserProfile != null)
                {
                    var profile = user.UserProfile;
                    Console.WriteLine($"Profile ID: {profile.Id}, Address: {profile.Address}, Phone: {profile.Phone}");
                    // Output other profile details as needed
                }
                else
                {
                    Console.WriteLine("User profile not found.");
                }
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        public void EditUser(int userId)
        {
            var user = users.Find(u => u.UserId == userId);
            if (user != null)
            {
                // Display current user details
                Console.WriteLine($"Current details of User ID: {user.UserId}, UserName: {user.UserName}, Email: {user.Email}");

                // Ask for new details
                Console.Write("Enter new User Name: ");
                string newUserName = Console.ReadLine();

                Console.Write("Enter new Email: ");
                string newEmail = Console.ReadLine();

                // Update user details if new details are provided
                if (!string.IsNullOrWhiteSpace(newUserName))
                {
                    user.UserName = newUserName;
                }

                if (!string.IsNullOrWhiteSpace(newEmail))
                {
                    user.Email = newEmail;
                }

                Console.WriteLine("User details updated successfully.");
            }
            else
            {
                Console.WriteLine("User not found. Cannot edit.");
            }
        }


        public void DeleteUser(int userId)
        {
            var user = users.Find(u => u.UserId == userId);
            if (user != null)
            {
                Console.WriteLine($"User ID: {user.UserId}, UserName: {user.UserName}, Email: {user.Email}");
                users.Remove(user); // Remove the user from the list if found
                Console.WriteLine("User deleted successfully.");
            }
            else
            {
                Console.WriteLine("User not found. Deletion failed.");
            }
        }
    }
}


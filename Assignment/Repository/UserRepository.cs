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
        private List<Profile> profiles;

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

                // Retrieve associated profile for the user
                var userProfile = profiles.Find(p => p.UserId == user.UserId);

                if (userProfile != null)
                {
                    Console.WriteLine("User Profile Details:");
                    Console.WriteLine($"Address: {userProfile.Address}, Phone: {userProfile.Phone}, Photo: {userProfile.Photo}, LocalGovt: {userProfile.LocalGovt}");
                }
                else
                {
                    Console.WriteLine("No profile found for this user.");
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


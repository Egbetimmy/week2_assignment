using System;
using System.Collections.Generic;
using Assignment.IRepository;
using Assignment.Repository;

namespace Wema.BIT.User
{
    public class Program
    {
        private static IUser UserRepository = new UserRepository();
        private static List<User> users = new List<User>();

        static void Main(string[] args)
        {
            GatherUserDetails();
            ProcessUserOperations();
        }

        private static void GatherUserDetails()
        {
            Console.WriteLine("Enter User Details or 'exit' to stop:");

            while (true)
            {
                Console.Write("User ID: ");
                string userIdInput = Console.ReadLine();

                if (userIdInput.ToLower() == "exit")
                    break;

                if (!int.TryParse(userIdInput, out int userId))
                {
                    Console.WriteLine("Invalid User ID. Please enter a valid integer or 'exit' to stop.");
                    continue;
                }

                Console.Write("User Name: ");
                string userName = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                User newUser = new UserList(userId, userName, email);
                users.Add(newUser);
            }
        }

        private static void ProcessUserOperations()
        {
            while (true)
            {
                DisplayUserOptions();
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting...");
                    break; // Exit the loop when 'exit' is entered
                }

                switch (userInput)
                {
                    case "1":
                        ViewUser();
                        break;
                    case "2":
                        DeleteUser();
                        break;
                    case "3":
                        EditUser();
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a valid option or 'exit'.");
                        break;
                }
            }
        }

        private static void DisplayUserOptions()
        {
            Console.WriteLine("Options:");
            Console.WriteLine("Enter 1 to view user by ID");
            Console.WriteLine("Enter 2 to delete user by ID");
            Console.WriteLine("Enter 3 to edit user by ID");
            Console.WriteLine("Enter 'exit' to exit");
            Console.Write("Enter your choice: ");
        }

        private static void ViewUser()
        {
            Console.Write("Enter User ID to view: ");
            if (int.TryParse(Console.ReadLine(), out int idToView))
            {
                User viewedUser = UserRepository.ViewUser(idToView);
                if (viewedUser != null)
                {
                    Console.WriteLine($"User Found - ID: {viewedUser.Id}, Name: {viewedUser.UserName}, Email: {viewedUser.Email}");
                }
                else
                {
                    Console.WriteLine("User not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid User ID.");
            }
        }

        private static void DeleteUser()
        {
            Console.Write("Enter User ID to delete: ");
            if (int.TryParse(Console.ReadLine(), out int idToDelete))
            {
                bool isDeleted = UserRepository.DeleteUser(idToDelete);
                if (isDeleted)
                {
                    Console.WriteLine("User deleted successfully.");
                }
                else
                {
                    Console.WriteLine("User not found or deletion failed.");
                }
            }
            else
            {
                Console.WriteLine("Invalid User ID.");
            }
        }

        private static void EditUser()
        {
            Console.Write("Enter User ID to edit: ");
            if (int.TryParse(Console.ReadLine(), out int idToEdit))
            {
                UserRepository.EditUser(idToEdit);
                Console.WriteLine("Edit operation complete.");
            }
            else
            {
                Console.WriteLine("Invalid User ID.");
            }
        }
    }
}

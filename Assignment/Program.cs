using System;
using System.Collections.Generic;
using Assignment.IRepository;
using Assignment.Models;
using Assignment.Repository;

namespace Assignment.User
{
    public class Program
    {
        private static IUser userRepository = new UserRepository();
        private static ITransaction transactionRepository = new TransactionRepository();
        private static IProfile profileRepository = new ProfileRepository();
        private static List<Users> users = new List<Users>();
        private static bool exit;

        static void Main(string[] args)
        {
            GatherUserDetails();
            NestedUserOperations();
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

                // Create a new User object using the constructor assuming it exists in the User class
                Users newUser = new Users { UserId = userId, UserName = userName, Email = email };
                users.Add(newUser);

                // Add the newly created user to the UserRepository
                userRepository.AddUser(newUser);
            }
        }

        private static void NestedUserOperations()
        {
            while (!exit)
            {
                Console.WriteLine("Options:");
                Console.WriteLine("Enter 1 for User Operations");
                Console.WriteLine("Enter 2 for Profile Operations");
                Console.WriteLine("Enter 3 for Transaction Operations");
                Console.WriteLine("Enter 4 to exit");

                Console.Write("Enter your choice: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        UserOperations();
                        break;

                    case "2":
                        ProfileOperations();
                        break;

                    case "3":
                        TransactionOperations();
                        break;

                    case "4":
                        exit = true;
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid input. Please enter a valid option.");
                        break;
                }
            }
        }

        private static void UserOperations()
        {
            bool exitUser = false;

            Users newUser = new Users();

            while (!exitUser)
            {
                Console.WriteLine("User Operations:");
                Console.WriteLine("Enter 1 to add user");
                Console.WriteLine("Enter 2 to view user");
                Console.WriteLine("Enter 3 to delete user");
                Console.WriteLine("Enter 4 to edit user");
                Console.WriteLine("Enter 5 to return to main menu");

                Console.Write("Enter your choice: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Write("Enter User ID to add: ");
                        if (int.TryParse(Console.ReadLine(), out int idToAdd))
                        {
                            Console.Write("Enter User Name: ");
                            string userName = Console.ReadLine();

                            Console.Write("Enter Email: ");
                            string email = Console.ReadLine();

                            // Create a new Users object
                            newUser = new Users(idToAdd, userName, email);

                            // Add the newly created user using userRepository.AddUser method
                            userRepository.AddUser(newUser);
                        }
                        else
                        {
                            Console.WriteLine("Invalid User ID.");
                        }
                        break;


                    case "2":
                        Console.Write("Enter User ID to view: ");

                        
                        if (int.TryParse(Console.ReadLine(), out int idToView))
                        {

                            userRepository.ViewUser(idToView);
                        }
                        else
                        {
                            Console.WriteLine("Invalid User ID.");
                        }
                        break;

                    case "3":
                        Console.Write("Enter User ID to delete: ");
                        if (int.TryParse(Console.ReadLine(), out int idToDelete))
                        {
                            userRepository.DeleteUser(idToDelete);
                        }
                        else
                        {
                            Console.WriteLine("Invalid User ID.");
                        }
                        break;

                    case "4":
                        Console.Write("Enter User ID to edit: ");
                        if (int.TryParse(Console.ReadLine(), out int idToEdit))
                        {
                            userRepository.EditUser(idToEdit);
                        }
                        else
                        {
                            Console.WriteLine("Invalid User ID.");
                        }
                        break;

                    case "5":
                        exitUser = true;
                        Console.WriteLine("Returning to main menu...");
                        break;

                    default:
                        Console.WriteLine("Invalid input. Please enter a valid option.");
                        break;
                }
            }
        }

        private static void ProfileOperations()
        {
            bool exitUser = false;

            while (!exitUser)
            {
                Console.WriteLine("User Operations:");
                Console.WriteLine("Enter 1 to Update profile");
                Console.WriteLine("Enter 2 to delete profile");
                Console.WriteLine("Enter 3 to return to main menu");

                Console.Write("Enter your choice: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Write("Enter User ID to update profile: ");
                        if (int.TryParse(Console.ReadLine(), out int idToView))
                        {
                            // Gather updated profile details from user input
                            Console.Write("Enter updated Address: ");
                            string updatedAddress = Console.ReadLine();

                            Console.Write("Enter updated Phone: ");
                            string updatedPhone = Console.ReadLine();

                            Console.Write("Enter updated Photo: ");
                            string updatedPhoto = Console.ReadLine();

                            Console.Write("Enter updated Local Government: ");
                            string updatedLocalGovt = Console.ReadLine();

                            // Create an instance of the updated profile
                            Profile updatedProfile = new Profile
                            {
                                UserId = idToView,
                                Address = updatedAddress,
                                Phone = updatedPhone,
                                Photo = updatedPhoto,
                                LocalGovt = updatedLocalGovt
                            };

                            // Update the profile using the repository method
                            profileRepository.UpdateProfile(idToView, updatedProfile);
                        }
                        else
                        {
                            Console.WriteLine("Invalid User ID.");
                        }
                        break;
  

                    case "2":
                        Console.Write("Enter User ID to delete: ");
                        if (int.TryParse(Console.ReadLine(), out int idToDelete))
                        {
                            profileRepository.DeleteProfile(idToDelete);
                        }
                        else
                        {
                            Console.WriteLine("Invalid User ID.");
                        }
                        break;

                    case "3":
                        exitUser = true;
                        Console.WriteLine("Returning to main menu...");
                        break;

                    default:
                        Console.WriteLine("Invalid input. Please enter a valid option.");
                        break;
                }
            }
        }

        private static void TransactionOperations()
        {
            bool exitUser = false;

            while (!exitUser)
            {
                Console.WriteLine("User Operations:");
                Console.WriteLine("Enter 1 to add Transaction");
                Console.WriteLine("Enter 2 to view Transaction");
                Console.WriteLine("Enter 3 to return to main menu");

                Console.Write("Enter your choice: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Write("Enter User ID to add payment: ");
                        if (int.TryParse(Console.ReadLine(), out int idToAdd))
                        {
                            Console.Write("Enter payment amount: ");
                            if (double.TryParse(Console.ReadLine(), out double paymentAmount))
                            {
                                // Create a new transaction instance with necessary data
                                Transaction newPayment = new Transaction { UserID = idToAdd, Transaction_amount = paymentAmount };
                                transactionRepository.AddPayment(idToAdd, newPayment);
                            }
                            else
                            {
                                Console.WriteLine("Invalid payment amount.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid User ID.");
                        }
                        break;

                    case "2":
                        Console.Write("Enter User ID to view transactions: ");
                        if (int.TryParse(Console.ReadLine(), out int idToView))
                        {
                            transactionRepository.ViewTransaction(idToView);
                        }
                        else
                        {
                            Console.WriteLine("Invalid User ID.");
                        }
                        break;


                    case "3":
                        exitUser = true;
                        Console.WriteLine("Returning to main menu...");
                        break;

                    default:
                        Console.WriteLine("Invalid input. Please enter a valid option.");
                        break;
                }
            }
        }

    }
}

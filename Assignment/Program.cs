using Assignment.IRepository;
using Assignment.Models;
using Assignment.Repository;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of the classes that implement the interfaces
        IUser userManager = new UserRepository();
        IProfile profileManager = new ProfileRepository();
        ITransaction transactionManager = new TransactionRepository();

        // Add user
        User newUser = new User { Id = 1, First_Name = "John", Last_Name = "Doe", Email = "john@example.com" };
        userManager.AddUser(newUser);

        // Update profile
        Profile newProfile = new Profile { UserId = 1, Address = "123 Main St", Phone = "123-456-7890" };
        profileManager.UpdateProfile(1, newProfile);

        // View user
        User retrievedUser = userManager.ViewUser(1);
        if (retrievedUser != null)
        {
            Console.WriteLine($"Retrieved User: {retrievedUser.First_Name} {retrievedUser.Last_Name}");
        } 

        // Add payment
        Transaction newPayment = new Transaction { TransactionId = 1, UserID = 1, Transaction_amount = 100 };
        transactionManager.AddPayment(1, newPayment);
    }
}

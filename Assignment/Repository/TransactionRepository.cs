using Assignment.IRepository;
using System;
using System.Collections.Generic;
using Assignment.Models;

namespace Assignment.Repository
{
    public class TransactionRepository : ITransaction
    {
        private List<Assignment.Models.Transaction> transactions = new List<Assignment.Models.Transaction>();

        public void AddPayment(int userId, Assignment.Models.Transaction payment)
        {
            // Add logic to associate payment with user and store it
            transactions.Add(payment);
        }

        public void ViewTransaction(int userId)
        {
            // Find transactions associated with the specified user ID
            var userTransactions = transactions.FindAll(t => t.UserID == userId);

            if (userTransactions.Count > 0)
            {
                Console.WriteLine($"Transactions for User ID {userId}:");
                foreach (var transaction in userTransactions)
                {
                    Console.WriteLine($"Transaction ID: {transaction.TransactionId}, Amount: {transaction.Transaction_amount}");
                    // Display other transaction details as needed
                }
            }
            else
            {
                Console.WriteLine("No transactions found for the specified user.");
            }
        }
    }
}

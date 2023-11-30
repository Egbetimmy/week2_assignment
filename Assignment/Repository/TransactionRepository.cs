using Assignment.IRepository;
using System;
using System.Collections.Generic;
// Ensure you're using Assignment.Models namespace to avoid conflicts
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Models; // Assuming Assignment.Models contains your Transaction class

namespace Assignment.IRepository
{
    // Interface for Transaction
    public interface ITransaction
    {
        void AddPayment(int userId, Assignment.Models.Transaction payment);
        // Other method declarations if needed
    }
}

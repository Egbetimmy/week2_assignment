using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int UserID { get; set; }
        public double Transaction_amount { get; set; }
        public User UserLists { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Transaction
    {
        public int PaymentId { get; set; }
        public int UserID { get; set; }
        public double Payment_amount { get; set; }
        public User UserLists { get; set; }
    }
}

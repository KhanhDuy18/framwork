using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses_MVC.Models
{

    public class Receipt
    {
        public int receiptId { get; set; }

        public float totalPrice { get; set; }

        public DateTime timeReceipt { get; set; }

        public int registerId { get; set; }

        public Register Register { get; set; }
    }
}

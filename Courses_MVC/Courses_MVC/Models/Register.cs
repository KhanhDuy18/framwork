using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses_MVC.Models
{
    public class Register
    {
        public int registerId { get; set; }

        public DateTime timeReg { get; set; }

        public string userId { get; set; }

        public AppUser AppUser { get; set; }

        public int courseId { get; set; }  

        public Course Course { get; set; }

        public ICollection<Receipt> Receipts { get; set; }
    }
}

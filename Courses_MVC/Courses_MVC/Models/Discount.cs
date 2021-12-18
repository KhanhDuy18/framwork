using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses_MVC.Models
{
    public class Discount
    {
        public int discountId { get; set; }

        public string? discription { get; set; }

        public DateTime time { get; set; }

        public float sale { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}

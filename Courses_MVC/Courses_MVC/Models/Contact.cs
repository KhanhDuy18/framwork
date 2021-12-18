using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses_MVC.Models
{
    public class Contact
    {
        public int contactId { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public string HoTen { get; set; }
        public string  email { get; set; }
        public string  SDT { get; set; }
        public string title { get; set; }
        public string content { get; set; }
    }
}

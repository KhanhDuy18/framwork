using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses_MVC.Models
{
    public class Comment
    {
        public string userId { get; set; }
        
        public AppUser AppUser { get; set; }

        public int courseId { get; set; }

        public Course Course { get; set; }

        public string content { get; set; }

        public float evaluate { get; set; }   

        
    }
}

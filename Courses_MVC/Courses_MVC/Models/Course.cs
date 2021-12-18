using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses_MVC.Models
{
    public class Course
    {
        public int courseId { get; set; }

        public string courseName { get; set; }

        public string discription { get; set; }

        public int price { get; set; }

        public int originalPrice { get; set; }

        public string imgCourse { get; set; }

        public string totalTime { get; set; }

        public int rating { get; set; }

        public int totalStudent { get; set; }

        public int topicId { get; set; }
        public Topic Topic { get; set;}
        
        public int discountId { get; set; }
        public Discount Discount { get; set; }

        public ICollection<Lesson> Lessons { get; set; }

        public ICollection<Register> Registers { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}

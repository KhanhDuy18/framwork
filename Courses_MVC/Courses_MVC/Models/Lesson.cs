using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses_MVC.Models
{
    public class Lesson
    {
        public int lessonId { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public string content { get; set; }

        public int courseId { get; set; }

        public Course Course { get; set; }

        public ICollection<Exercise> Exercises { get; set; }
    }
}

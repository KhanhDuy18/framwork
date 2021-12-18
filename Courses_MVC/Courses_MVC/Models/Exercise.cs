using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses_MVC.Models
{
    public class Exercise
    {
        public int exerciseId { get; set; }

        public string content { get; set; }

        public DateTime deadline { get; set; }

        public int lessonId { get; set; }

        public Lesson Lesson { get; set; }

        public string teacherId { get; set; }

        public AppUser AppUser { get; set; }

        public ICollection<ExerciseInUser> ExerciseInUsers { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses_MVC.Models
{
    public class ExerciseInUser
    {
        public int exerciseId { get; set; }

        public Exercise Exercise { get; set; }

        public string studentId { get; set; }

        public string status { get; set; }

        public AppUser AppUser { get; set; }

        public DateTime submit { get; set; }

        public float scores { get; set; }

    }
}

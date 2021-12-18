using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses_MVC.Models
{
    public class Topic
    {
        public int topicId { get; set; }
        public string topicName { get; set; }
        public ICollection<Course> Course { get; set; }

    }
}

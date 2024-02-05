using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business
{
    public class CourseManager
    {
        Course[] courses = new Course[3];

        //constructor
        public CourseManager()
        {
            Course course1 = new();
            course1.Id = 1;
            course1.Name = "C#";
            course1.Description = "C#  .NET 8";
            course1.Price = 0;

            Course course2 = new();
            course2.Id = 2;
            course2.Name = "Java";
            course2.Description = "Java 17..";
            course2.Price = 10;

            Course course3 = new();
            course3.Id = 3;
            course3.Name = "Python";
            course3.Description = "Python 3.12 ..";
            course3.Price = 20;

            courses = [course1, course2, course3];
        }

        public Course[] GetAll()
        {
            return courses;
        }
    }
}

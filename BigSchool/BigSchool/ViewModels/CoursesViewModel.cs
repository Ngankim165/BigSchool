using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public IEnumerable<Following> Following { get; set; }
        public IEnumerable<Course> Mine { get; set; }
        public bool ShowAction { get; set; }
    }
}
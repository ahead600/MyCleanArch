using MyCleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCleanArch.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}

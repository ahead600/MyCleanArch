using MyCleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCleanArch.Application.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses();
    }
}

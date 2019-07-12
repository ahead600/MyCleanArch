using MyCleanArch.Application.Interfaces;
using MyCleanArch.Application.ViewModels;
using MyCleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public CourseViewModel GetCourses()
        {
            return new CourseViewModel
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}

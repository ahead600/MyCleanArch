using MyCleanArch.Domain.Interfaces;
using MyCleanArch.Domain.Models;
using MyCleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCleanArch.Infra.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityContext _ctx;

        public CourseRepository(UniversityContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}

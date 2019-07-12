using Microsoft.EntityFrameworkCore;
using MyCleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCleanArch.Infra.Data.Context
{
    public class UniversityContext:DbContext
    {
        public UniversityContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
    }
}

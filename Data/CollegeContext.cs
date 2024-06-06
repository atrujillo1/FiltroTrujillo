using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiltroTrujillo.Models;
using Microsoft.EntityFrameworkCore;

namespace FiltroTrujillo.Data
{
    public class CollegeContext
    {
        //         public CollegeContext(CollegeContextOptions<CollegeContext> options): base(options)
        // {

        // }

        // public DbSet<Courses_Student>Courses_Student
        //  { get; set; }
        public DbSet<Course>?Courses{ get; set; }
        public DbSet<Enrollment>?Enrollments { get; set; }
        public DbSet<Student>?Students { get; set; }
        public DbSet<Teacher>?Teachers { get; set; }

        internal object Entry(Student student)
        {
            throw new NotImplementedException();
        }

        internal object Entry(Teacher teacher)
        {
            throw new NotImplementedException();
        }

        internal async Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }

    public class Courses_Student
    {
    }
}
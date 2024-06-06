using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiltroTrujillo.Data;
using FiltroTrujillo.Models;
using Microsoft.EntityFrameworkCore;

namespace FiltroTrujillo.Services
{
    public class StudentRepository
    {
   
    
        private readonly CollegeContext _context;

        public StudentRepository(CollegeContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> GetStudentById(int id)
        {
            return await _context.Students.FindAsync(id);
        }

        public async Task<Student> AddStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return student;
        }


        public async Task<bool> DeleteStudent(int id)
        {
            var Student = await _context.Students.FindAsync(id);
            if (Student == null)
            {
                return false;
            }

            _context.Students.Remove(Student);
            await _context.SaveChangesAsync();
            return true;
        }

        internal async Task UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}

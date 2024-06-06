using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiltroTrujillo.Data;
using FiltroTrujillo.Models;
using Microsoft.EntityFrameworkCore;

namespace FiltroTrujillo.Services
{
    public class TeacherRepository
    {
                private readonly CollegeContext _context;

        public TeacherRepository(CollegeContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Teacher>> GetAllTeachersAsync()
        {
            return await _context.Teachers.ToListAsync();
        }

        public async Task<Teacher> GetTeacherById(int id)
        {
            return await _context.Teachers.FindAsync(id);
        }

        public async Task<Teacher> AddTeacher(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
            await _context.SaveChangesAsync();
            return teacher;
        }

        // public async Task<Teacher> UpdateTeacher(Teacher teacher)
        // {
        //     _context.Entry(teacher).State = EntityState.Modified;
        //     await _context.SaveChangesAsync();
        //     return teacher;
        // }

        public async Task<bool> DeleteTeacher(int id)
        {
            var teacher = await _context.Teachers.FindAsync(id);
            if (teacher == null)
            {
                return false;
            }

            _context.Teachers.Remove(teacher);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
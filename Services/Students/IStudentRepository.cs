using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiltroTrujillo.Models;



namespace FiltroTrujillo.Services{
    public interface IStudentRepository<T> where T : class
    {
        Task<IEnumerable<Student>> GetAllAsync();
        Task<Student> GetByIdAsync(int id);
        Task AddAsync(Student student);
        Task UpdateAsync(Student student);

    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FiltroTrujillo.Models;
using FiltroTrujillo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FiltroTrujillo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentRepository _StudentRepository;

        public StudentController(StudentRepository StudentRepository)
        {
            _StudentRepository = StudentRepository;
        }


        [HttpGet]
    public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
    {
        var Student = await _StudentRepository.GetAllStudents();
        return Ok(Student);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Enrollment>> GetStudent(int id)
    {
        var Student = await _StudentRepository.GetStudentById(id);
        if (Student == null)
        {
            return NotFound();
        }
        return Ok(Student);
    }

    [HttpPost]
    public async Task<ActionResult> AddEnrollment(Student Student)
    {
        await _StudentRepository.AddStudent(Student);
        return CreatedAtAction(nameof(GetStudent), new { id = Student.Id }, Student);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateStudent(int id, Student Student)
    {
        if (id != Student.Id)
        {
            return BadRequest();
        }
        await _StudentRepository.UpdateStudent(Student);
        return NoContent();
    }



    }
}

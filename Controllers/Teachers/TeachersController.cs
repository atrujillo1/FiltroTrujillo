using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FiltroTrujillo.Models;
using FiltroTrujillo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

[ApiController]
[Route("api/[controller]")]
public class TeachersController : ControllerBase
{
    private readonly ITeacherRepository _TeacherService;

    public TeachersController(ITeacherRepository TeacherService)
    {
        _TeacherService = TeacherService;
    }

    // [HttpGet]
    // public async Task<ActionResult<IEnumerable<Teacher>>> GetTeachers()
    // {
    //     var Teacher = await _TeachersService.GetAllTeachersAsync();
    //     return Ok(Teacher);
    // }

    // [HttpGet("{id}")]
    // public async Task<ActionResult<Teacher>> GetTeacher(int id)
    // {
    //     var Teacher = await GetTeacherById(id);
    //     if (Teacher == null)
    //     {
    //         return NotFound();
    //     }
    //     return Ok(Teacher);
    // }

    [HttpPost]
    public async Task<ActionResult> AddTeacher(Teacher Teacher)
    {
        await _TeacherService.AddTeacher(Teacher);
        return CreatedAtAction(nameof(Teacher), new { id = Teacher.Id }, Teacher);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateTeacher(int id, Teacher Teacher)
    {
        if (id != Teacher.Id)
        {
            return BadRequest();
        }
        await _TeacherService.UpdateTeacher(Teacher);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteTeacher(int id)
    {
        await _TeacherService.DeleteTeacher(id);
        return NoContent();
    }

    [HttpPost("{id}/restore")]
    public async Task<ActionResult> RestoreTeacher(int id)
    {
        //await _TeacherService.RestoreTeacher(id);
        return NoContent();
    }


}
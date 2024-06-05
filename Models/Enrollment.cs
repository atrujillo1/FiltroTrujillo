using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace FiltroTrujillo.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } 
        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public Enum? Status { get; set; }
    }
}
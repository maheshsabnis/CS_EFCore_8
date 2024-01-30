using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EFCore_8.Models
{
    public class BirthRecord
    {
        [Key]
        public int BirthId { get; set; }
        public required string BirthName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public TimeOnly TimeOfBirth { get; set; }
    }
}

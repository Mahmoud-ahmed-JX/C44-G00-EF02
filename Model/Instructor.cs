using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Asmnt2.Model
{
    internal class Instructor
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [Range(1, double.MaxValue)]
        [Precision(10,2)]
        public decimal Salary { get; set; }
        [MaxLength(150)]
        public string Address { get; set; }
        [Precision(10, 2)]
        [Range(0, double.MaxValue)]
        [DefaultValue(0)]
        public decimal HourRateBonus { get; set; }
        [Required]
        public int Dep_Id { get; set; }
    }
}

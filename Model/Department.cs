using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Asmnt2.Model
{
    internal class Department
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        
        public int Ins_Id { get; set; }
        [Required]
        public DateOnly HiringDate { get; set; }
    }
}

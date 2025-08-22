using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Asmnt2.Model
{
    internal class Student
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LName { get; set; }

        [MaxLength(150)]
        public string Address { get; set; }
        [Required]
        [Range(18,60)]
        public int Age { get; set; }

        [Required]
        public int Dep_Id { get; set; }
    }
}

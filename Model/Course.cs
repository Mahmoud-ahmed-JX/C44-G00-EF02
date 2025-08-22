using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Asmnt2.Model
{
    internal class Course
    {
        public int Id { get; set; }
        [Required]
        [Range(1,int.MaxValue)]
        public int Duration { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }
        [Required]
        public int Top_Id { get; set; }


    }
}

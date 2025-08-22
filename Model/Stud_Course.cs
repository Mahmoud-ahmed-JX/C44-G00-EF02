using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Asmnt2.Model
{
    internal class Stud_Course
    {

        public int Stud_Id { get; set; }
        public int Course_Id { get; set; }

        [Range(0,100)]
        public int Grade { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualInstitute.Domain
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Qual { get; set; }
    }
}

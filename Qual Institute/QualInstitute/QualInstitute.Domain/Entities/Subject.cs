using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualInstitute.Domain
{
    public class Subject
    {
        public int SubjectID { get; set; }
        public string Name { get; set; }
        public float LectionHours { get; set; }
        public float PracticeHours { get; set; }
    }
}

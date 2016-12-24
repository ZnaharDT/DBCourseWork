using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualInstitute.Domain
{
    public class Speciality
    {
        public int SpecialityID { get; set; }
        public string Name { get; set; }
        public int StudyingTime { get; set; }
        public int TimesAtYear { get; set; }
        public bool HasHostel { get; set; }
    }
}

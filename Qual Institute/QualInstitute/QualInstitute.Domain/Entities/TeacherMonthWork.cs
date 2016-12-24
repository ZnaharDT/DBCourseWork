using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualInstitute.Domain.Entities
{
    public class TeacherMonthWork
    {
        [Key]
        public int ItemID { get; set; }
        public int TeacherID { get; set; }
        public int LectureHours { get; set; }
        public int PracticeHours { get; set; }
    }
}

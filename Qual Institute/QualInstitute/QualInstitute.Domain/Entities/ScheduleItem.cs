using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualInstitute.Domain
{
    public class ScheduleItem
    {
        [Key]
        public int ItemID { get; set; }
        public int TeacherID { get; set; }
        public int SubjectID { get; set; }
        public int GroupID { get; set; }
        public Days Day { get; set; }
        public TimeSpan Time { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualInstitute.Domain
{
    public class ScheduleItem
    {
        public int ItemID { get; set; }
        public int TeacherID { get; set; }
        public int SubjectID { get; set; }
        public int GroupID { get; set; }
        public byte Day { get; set; }
        public DateTime Time { get; set; }
    }
}

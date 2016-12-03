using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualInstitute.Domain
{
    public class Mark
    {
        public int MarkId { get; set; }
        public int StudentID { get; set; }
        public int SubjectID { get; set; }
        public int MarkValue { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QualInstitute.Domain.Concrete;

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

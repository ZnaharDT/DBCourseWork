using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualInstitute.Domain.Entities
{
    public class StudyingPlanItem
    {
        [Key]
        public int ItemID { get; set; }
        public int SpecialityID { get; set; }
        public int SubjectID { get; set; }
    }
}

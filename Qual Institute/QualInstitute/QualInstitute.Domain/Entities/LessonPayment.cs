using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualInstitute.Domain.Entities
{
    public class LessonPayment
    {
        [Key]
        public int PaymentID { get; set; }
        public bool Qual { get; set; }
        public double Rate { get; set; }
    }
}

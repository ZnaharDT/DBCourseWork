using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QualInstitute.Domain.Abstract;
using QualInstitute.Domain.Concrete;

namespace QualInstitute.UI
{
    public static class InstituteDB
    {
        public static IDBRepository Repository = new EFDbRepository();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualInstitute.Domain.Abstract
{
    public interface IDBRepository
    {
        IQueryable<Student> Students { get; }
        IQueryable<Group> Groups { get; }
        IQueryable<Subject> Subjects { get; }
        IQueryable<Speciality> Specialities { get; }
        IQueryable<ScheduleItem> Schedule { get; }
        IQueryable<Teacher> Teachers { get; }
        IQueryable<Mark> Marks { get; }

    }
}

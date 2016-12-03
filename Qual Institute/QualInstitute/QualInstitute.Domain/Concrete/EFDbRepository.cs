using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QualInstitute.Domain.Abstract;

namespace QualInstitute.Domain.Concrete
{
    public class EFDbRepository : IDBRepository
    {
        private EFDbContext context = new EFDbContext();

        public IQueryable<Student> Students => context.Students;
        public IQueryable<Group> Groups => context.Groups;
        public IQueryable<Subject> Subjects => context.Subjects;
        public IQueryable<Speciality> Specialities => context.Specialities;
        public IQueryable<ScheduleItem> Schedule => context.Schedule;
        public IQueryable<Teacher> Teachers => context.Teachers;
        public IQueryable<Mark> Marks => context.Marks;
    }
}

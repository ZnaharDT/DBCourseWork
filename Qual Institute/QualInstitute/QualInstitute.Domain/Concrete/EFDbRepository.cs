using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QualInstitute.Domain.Abstract;
using QualInstitute.Domain.Entities;

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
        public IQueryable<LessonPayment> Payments => context.Payments;
        public IQueryable<TeacherMonthWork> MonthReport => context.MonthReport;
        public IQueryable<StudyingPlanItem> StudyingPlan => context.StudyingPlan;

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualInstitute.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<ScheduleItem> Schedule { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Mark> Marks { get; set; }
    }
}

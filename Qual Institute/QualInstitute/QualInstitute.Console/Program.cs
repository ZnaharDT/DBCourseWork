using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QualInstitute.Domain.Abstract;
using QualInstitute.Domain.Concrete;

namespace QualInstitute.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IDBRepository repository = new EFDbRepository();
            foreach (var student in repository.Students)
            {
                System.Console.WriteLine(student.Name);
            }
            repository.Students.First(s => s.Name == "Sanya").Name = "Vityan";
            foreach (var student in repository.Students)
            {
                System.Console.WriteLine(student.Name);
            }
            System.Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QualInstitute.Domain;
using QualInstitute.Domain.Abstract;
using QualInstitute.Domain.Concrete;

namespace QualInstitute.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            EFDbContext repository = new EFDbContext();

            foreach (var grp in repository.Groups)
            {
                Console.WriteLine(grp.Name);
            }

            Console.ReadKey();
        }
    }
}

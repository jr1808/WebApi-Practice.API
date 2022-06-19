using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Practice.DataModels;

namespace WebAPI_Practice.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext context;
        public SqlStudentRepository(StudentAdminContext context)
        {
            this.context = context;
        }
        public List<Student> GetStudents()
        {
            return context.Student.ToList();
        }
    }
}

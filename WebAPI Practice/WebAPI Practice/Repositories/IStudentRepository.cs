using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Practice.DataModels;

namespace WebAPI_Practice.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();

    }
}

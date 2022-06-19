﻿using Microsoft.EntityFrameworkCore;
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

       public async Task<List<Student>> GetStudentsAsync()
        {
            //return await context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
            return await context.Student.ToListAsync();

        }
    }
}

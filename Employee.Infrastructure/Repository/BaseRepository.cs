using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Core.Entities;
using WebApi.Core.Interface.Infrastructure;

namespace WebApi.Infrastructure.Repository
{
    public class BaseRepository : IBaseRepository<Employee>
    {
        public int Delete(string employeeId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> FilterByIdNamePhone(string employeeId, string fullName, string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> getAll()
        {
            throw new NotImplementedException();
        }

        public int Post(Employee Entity)
        {
            throw new NotImplementedException();
        }

        public int Put(Employee Entity)
        {
            throw new NotImplementedException();
        }
    }
}
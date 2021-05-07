using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Core.Entities;
using WebApi.Core.Interface.Infrastructure;
using WebApi.Core.Interface.Service;

namespace WebApi.Core.Service
{
    public class EmployeeService : BaseService<Employee>, IEmployeeService<Employee>
    {
        private IEmployeeRepository<Employee> _employeeRepository;

        public EmployeeService(IEmployeeRepository<Employee> employeeRepository) : base(employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
    }
}
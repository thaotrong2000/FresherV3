using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Core.Interface.Infrastructure
{
    public interface IEmployeeRepository<MISAEntity> : IBaseRepository<MISAEntity> where MISAEntity : class
    {
    }
}
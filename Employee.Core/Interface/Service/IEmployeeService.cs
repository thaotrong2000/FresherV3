using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Core.Interface.Service
{
    public interface IEmployeeService<MISAEntity> : IBaseService<MISAEntity> where MISAEntity : class
    {
    }
}
using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
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
            // Kết nối với DataBase
            string connectString = "Host = 47.241.69.179;" +
                "Port = 3306;" +
                "Database = MF0_NVManh_CukCuk02;" +
                "User Id = dev;" +
                "Password = 12345678;" +
                "AllowZeroDateTime=True"
                ;
            IDbConnection dbConnection = new MySqlConnection(connectString);
            var employees = dbConnection.Query<Employee>("proc_GetAllEmployee", commandType: CommandType.StoredProcedure);

            // Trả về danh sách người dùng
            return employees;
        }

        public int Post(Employee Entity)
        {
            return 0;
        }

        public int Put(Employee Entity)
        {
            throw new NotImplementedException();
        }
    }
}
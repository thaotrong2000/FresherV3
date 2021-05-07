using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Core.Entities
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int GenderId { get; set; }
        public string Department { get; set; }
        public int IdentityId { get; set; }
        public DateTime IdentityDate { get; set; }
        public string PositionId { get; set; }
        public string IdentityPosition { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string LandlinePhone { get; set; }
        public string Email { get; set; }
        public int BankId { get; set; }
        public string BankName { get; set; }
        public string BankBranch { get; set; }
    }
}
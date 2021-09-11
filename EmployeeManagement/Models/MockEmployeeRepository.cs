using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id=101,Name="Siva",Department="HR",Email="siva@email.com" },
                new Employee(){Id=102,Name="Chaitanya",Department="IT",Email="chaitanya@email.com" },
                new Employee(){Id=103,Name="Vishnu",Department="HR",Email="Vishnu@email.com" },
                new Employee(){Id=104,Name="Vinay",Department="IT",Email="viany@email.com" }
            };
        }
        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(x => x.Id == Id);
        }
    }
}

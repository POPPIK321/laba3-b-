using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3_b_
{
    internal class Department
    {
        public string Title { get; set; }
        public int Number_of_employees
        {
            get
            {
                return Employees.Count;
            }
        }
        public Company _company_ { get; set; }
        public List<Employee> Employees { get; } = new List<Employee>();
        public void addEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
        public void removeEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }
    }
}

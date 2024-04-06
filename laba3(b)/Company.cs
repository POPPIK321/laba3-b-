using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3_b_
{
    internal class Company
    {
        public string Title { get; set; }
        public List<Department> Departments { get; } = new List<Department>();
        public void addDepartment(Department department)
        {
            Departments.Add(department);
        }
        public void removeDepartment(Department department)
        {
            Departments.Remove(department);
        }
    }
}

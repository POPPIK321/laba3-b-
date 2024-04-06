using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3_b_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Company company = new Company { Title = "Пивоварня MX" };
            Department department1 = new Department { Title = "Поставщики", _company_ = company };
            Department department2 = new Department { Title = "Варщики", _company_ = company };

            company.addDepartment(department1);
            company.addDepartment(department2);

            Employee employee1 = new Employee { Full_name = "Василий Чехов Владимирович", Position = "Водитель", Salary = 100, Departments = department1 };
            Employee employee2 = new Employee { Full_name = "Олег Карасёв Дмитриевич", Position = "Грузчик", Salary = 100, Departments = department1 };
            Employee employee3 = new Employee { Full_name = "Бахтеев Максим Александрович", Position = "Директор", Salary = 1_000_000, Departments = department2 };

            department1.addEmployee(employee1);
            department1.addEmployee(employee2);
            department2.addEmployee(employee3);

            Console.WriteLine($"Сотруднкик в отделе {department1.Title}:");
            foreach (var employee in department1.Employees)
            {
                Console.WriteLine($"{employee.Full_name} - {employee.Position}");
            }

            Console.WriteLine($"Количество сотрудников в отделе {department1.Title}: {department1.Number_of_employees}");
        }
    }
}

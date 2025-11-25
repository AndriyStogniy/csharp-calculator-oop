using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    public class Employee
    {
        private string name;
        private decimal salary;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public decimal Salary
        {
            get => salary;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Salary cannot be negative!");
                salary = value;
            }
        }

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        // +
        public static Employee operator +(Employee emp, decimal amount)
        {
            return new Employee(emp.Name, emp.Salary + amount);
        }

        // -
        public static Employee operator -(Employee emp, decimal amount)
        {
            return new Employee(emp.Name, emp.Salary - amount);
        }

        // ==
        public static bool operator ==(Employee a, Employee b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            return a.Salary == b.Salary;
        }

        // !=
        public static bool operator !=(Employee a, Employee b)
        {
            return !(a == b);
        }

        // <
        public static bool operator <(Employee a, Employee b)
        {
            return a.Salary < b.Salary;
        }

        // >
        public static bool operator >(Employee a, Employee b)
        {
            return a.Salary > b.Salary;
        }

        // For correct work == and !=
        public override bool Equals(object obj)
        {
            if (obj is Employee other)
                return Salary == other.Salary;
            return false;
        }

        public override int GetHashCode()
        {
            return Salary.GetHashCode();
        }

        // Show info
        public override string ToString()
        {
            return $"{Name} — Salary: {Salary}";
        }
    }
}

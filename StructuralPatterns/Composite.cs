using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralPatterns
{
    interface IEmployee
    {
        float GetSalary();
        string GetRole();
        string GetName();
    }


    class Developer : IEmployee
    {
        private string mName;
        private float mSalary;

        public Developer(string name, float salary)
        {
            this.mName = name;
            this.mSalary = salary;
        }

        public float GetSalary()
        {
            return this.mSalary;
        }

        public string GetRole()
        {
            return "Developer";
        }

        public string GetName()
        {
            return this.mName;
        }
    }

    class Designer : IEmployee
    {
        private string mName;
        private float mSalary;

        public Designer(string name, float salary)
        {
            this.mName = name;
            this.mSalary = salary;
        }

        public float GetSalary()
        {
            return this.mSalary;
        }

        public string GetRole()
        {
            return "Designer";
        }

        public string GetName()
        {
            return this.mName;
        }
    }
    class Organization
    {
        protected List<IEmployee> employees;

        public Organization()
        {
            employees = new List<IEmployee>();
        }

        public void AddEmployee(IEmployee employee)
        {
            employees.Add(employee);
        }

        public float GetNetSalaries()
        {
            float netSalary = 0;

            foreach (var e in employees)
            {
                netSalary += e.GetSalary();
            }
            return netSalary;
        }
    }
    class UsageCompsite
    {
        public void use()
        {
            //Arrange Employees, Organization and add employees
            var developer = new Developer("John", 5000);
            var designer = new Designer("Arya", 5000);

            var organization = new Organization();
            organization.AddEmployee(developer);
            organization.AddEmployee(designer);

            Console.WriteLine($"Net Salary of Employees in Organization is {organization.GetNetSalaries():c}");
        }
    }
 }

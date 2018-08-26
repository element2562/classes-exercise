using System;
namespace Employment
{
    class Program
    {
        static void Main(string[] args)
        {
            Company newCompany = new Company();
            Employee Jacob = new Employee();
            Jacob.FirstName = "Jacob";
            Employee Jordan = new Employee();
            Jordan.FirstName = "Jordan";
            Employee Brett = new Employee();
            Brett.FirstName = "Brett";
            newCompany.Employees.Add(Jacob);
            newCompany.Employees.Add(Jordan);
            newCompany.Employees.Add(Brett);
            newCompany.ListEmployees();
        }
    }
}

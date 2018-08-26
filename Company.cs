using System;
using System.Collections.Generic;

namespace Employment
{
public class Company
{
    private DateTime dateFound;
    private string companyTitle;
    public DateTime DateFounded { get {return dateFound;} }
    
    public string CompanyName { get {return companyTitle;} }
    public List<Employee> Employees { get; set; }

    public Company()
    {
        Employees = new List<Employee>();
    }
    public void ListEmployees() {
        foreach (Employee item in Employees)
        {
            Console.WriteLine(item.FirstName);
        }
    }
    public void nameAndDate(string name, DateTime date){
        dateFound = date;
        companyTitle = name;
    }
}
}
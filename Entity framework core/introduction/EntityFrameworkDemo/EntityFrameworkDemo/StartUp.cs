using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace EntityFrameworkDemo
{
    public class StartUp
    {

        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();

            string result = GetEmployee147(context);
            Console.WriteLine(result);
        }
        //ex 04
        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employee = context.
                Employees
                .Where(e => e.Salary > 50000)
                .OrderBy(e => e.FirstName).ToList();

            foreach (var e in employee)
            {
                sb
                     .AppendLine($"{e.FirstName} - {e.Salary:f2}");
            }
            return sb.ToString().TrimEnd();
        }
        //ex 3
        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            var employee = context
                .Employees
                .OrderBy(x => x.EmployeeId);
            foreach (var item in employee)
            {
                sb.AppendLine($"{item.FirstName} {item.LastName} {item.MiddleName} {item.Salary}");
            }
            return sb.ToString().TrimEnd();
        }
        //ex 5
        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            var employee = context
                .Employees
                .Where(x => x.Department.Name == "Research and Development")
                .OrderBy(x => x.Salary)
                .ThenByDescending(x => x.FirstName)
                .ToList();

            foreach (var e in employee)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} {e.Department} {e.Salary:f2}");
            }
            return sb.ToString().TrimEnd();
        }
        //ex 6
        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            Address newAddress = new Address()
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };

            Employee employeeNakov = context.
                Employees.
                First(x => x.LastName == "Nakov");

            context.Addresses.Add(newAddress);
            employeeNakov.Address = newAddress;

            context.SaveChanges();

            var employee = context.
                Employees.
                OrderByDescending(x => x.AddressId).
                Take(10).
                Select(e => e.Address.AddressText).
                ToList();

            foreach (var item in employee)
            {
                sb.AppendLine(item);
            }
            return sb.ToString().TrimEnd();
     
        }
        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employee = context.
                Employees.
                Where(x => x.EmployeesProjects.Any(ep => ep.Project.StartDate.Year >= 2003
                && ep.Project.StartDate.Year <= 2003)).
                Take(10).
                Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    ManagerFirstNmae = e.Manager.FirstName,
                    ManagerLastName = e.Manager.LastName,
                    Projects = e.EmployeesProjects.
                    Select(ep => new {
                        ProjectName = ep.Project.Name,
                        StartDate = ep.Project.StartDate.ToString(
                        "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture),
                        EndDate = ep.Project.EndDate.HasValue ?
                        ep.Project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt",
                        CultureInfo.InvariantCulture) : "not finished"
                    }).
                    ToList()
                }).ToList();
                


            foreach (var e in employee)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} - Manager {e.ManagerFirstNmae} {e.ManagerLastName}");
                foreach (var p in e.Projects)
                {
                    sb.AppendLine($"--{p.ProjectName} - {p.StartDate} - {p.EndDate}");
                }
            }
            return sb.ToString().TrimEnd();
        }
        //8
        public static string GetEmployee147(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employee = context.Employees
                .Where(x => x.EmployeeId == 147).ToArray();

            foreach (var e in employee)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} {e.JobTitle} ");
                sb.AppendLine($"{e.JobTitle} ");
            }
            return sb.ToString().TrimEnd();
        }
    }
}

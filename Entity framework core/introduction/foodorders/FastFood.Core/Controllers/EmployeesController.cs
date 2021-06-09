namespace FastFood.Core.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Data;
    using FastFood.Models;
    using Microsoft.AspNetCore.Mvc;
    using ViewModels.Employees;

    public class EmployeesController : Controller
    {
        private readonly FastFoodContext context;
        private readonly IMapper mapper;

        public EmployeesController(FastFoodContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public IActionResult Register()
        {
            List<RegisterEmployeeInputModel> positions =
                context
                .Positions
                .ProjectTo<RegisterEmployeeInputModel>(mapper.ConfigurationProvider)
                .ToList();

            
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterEmployeeInputModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Error", "Home");
            }
            Employee employee = mapper.Map<Employee>(model);

            context.Employees.Add(employee);
            context.SaveChanges();

            return RedirectToAction("All");
        }

        public IActionResult All()
        {
            List<EmployeesAllViewModel> employees = context
                 .Employees
                 .ProjectTo<EmployeesAllViewModel>
                 (mapper.ConfigurationProvider)
                 .ToList();

            return View(employees);
        }
    }
}

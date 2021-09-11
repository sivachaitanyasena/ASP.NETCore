﻿using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    public class HomeController
    {
        IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public string Index()
        {
            return _employeeRepository.GetEmployee(101).Name;
        }
        public ObjectResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(101);
            return new ObjectResult(model);// _employeeRepository.GetEmployee(101).Name;
        }
    }
    //public class HomeController : Controller
    //{
    //    public IActionResult Index()
    //    {
    //        return View();
    //    }
    //}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department{ Id = 1,Name = "Categoria1"});
            list.Add(new Department { Id = 1, Name = "Categoria2" });
            list.Add(new Department { Id = 1, Name = "Categoria3" });

            return View(list);
        }
    }
}
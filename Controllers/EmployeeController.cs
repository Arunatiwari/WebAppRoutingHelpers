using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppRoutingHelpers.Controllers
{
    public class EmployeeController : Controller
    {
        [Route("show-details/{id}/{deptId}")]
        [Route("Employee/Index/{id}/{deptId}")]
        public IActionResult Index(int id, int deptId)
        {
            return View();
        }
    }
}

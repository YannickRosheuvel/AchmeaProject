using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AchmeaProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace AchmeaProject.Controllers
{
    public class SoftwareController : Controller
    {
        public IActionResult Index()
        {
            MockProject item = new MockProject("Achmea", "Complete", "Jim");
            MockProject item2 = new MockProject("Fontys", "Incomplete", "Marc");
            List<MockProject> list = new List<MockProject>();
            list.Add(item);
            list.Add(item2);

            return View(list);
        }
    }
}
using dkhp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace dkhp.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("MyView");
        }
        [HttpGet]
        public ViewResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ViewResult DangKy(GuestResponse rp)
        {
            Repository.AddResponse(rp);
            return View("Thanks", rp);
        }
        public ViewResult List()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}

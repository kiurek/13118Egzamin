using _13118EgzaminPraktyczny.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _13118EgzaminPraktyczny.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }
    }
}

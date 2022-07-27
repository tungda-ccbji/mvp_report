using Microsoft.AspNetCore.Mvc;
using MVP.Generate.Excel.Abstraction;
using MVP.Generate.Excel.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MVP.Generate.Excel.Controllers
{
    [Controller]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "Home";
        }
    }
}

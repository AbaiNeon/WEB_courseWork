﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CourseWork_Web.Controllers
{
    public class SquareGameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
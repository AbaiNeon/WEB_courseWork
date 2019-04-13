using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseWork_Web.Models;
using Microsoft.AspNetCore.Mvc;

//берутся 20 предложений рандомно
//формируется массив ответов
//сравнивается

namespace CourseWork_Web.Controllers
{
    public class EngQuizController : Controller
    {
        private List<Content> _content { get; set; } = new List<Content>();
        private Context _db;

        public EngQuizController(Context context)
        {
            _db = context;
        }

        public IActionResult Index()
        {
            var content = _db.Contents.OrderBy(c => Guid.NewGuid()).Take(20).ToList();

            return View(content);
        }

        public IActionResult Menu()
        {
            

            return View();
        }
    }
}
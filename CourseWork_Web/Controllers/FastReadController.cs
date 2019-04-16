using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CourseWork_Web.Controllers
{
    public class FastReadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //первая, вторая и посл буква остаются
        //через каждое третье слово
        [HttpPost]
        public IActionResult Process(string inputText)
        {
            List<string> words = inputText.Split(" ,.!?-".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < words.Count; i++)
            {
                if (i % 2 != 0)
                {
                    words[i] = ShuffleWord(words[i]);
                }

            }

            return Json(string.Join(" ", words));
        }

        public string ShuffleWord(string word)
        {
            char[] array = word.ToCharArray();
            Random rng = new Random();
            int n = array.Length - 2;
            while (n > 1)
            {

                int k = rng.Next(2, n+1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
                n--;
            }
            return new string(array);
        }
    }
}
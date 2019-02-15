using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork_Web.Models
{
    public class Content
    {
        public int Id { get; set; }
        public string Eng { get; set; }
        public string Rus { get; set; }
        public int? UserId { get; set; }
    }
}

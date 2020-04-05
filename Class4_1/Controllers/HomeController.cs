using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Class4_1.Models;
using Clas4_1.Data;

namespace Class4_1.Controllers
{
    public class HomeController : Controller
    {
        private string _conn = "Data Source=.\\sqlexpress;Initial Catalog=ToDoItem;Integrated Security=True;";
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPeople(List<Person> ppl)
        {
            PersonDB db = new PersonDB(_conn);
            foreach(Person p in ppl)
            {
                db.AddPerson(p);
            }
            return Redirect("/home/index");

        }

       
    }
}

using AddTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AddTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            string[] courses = { "JavaScript", "C#", "Java", "Python", "Основы" };
            SelectList list = new SelectList(courses, courses[1]);
            ViewBag.SList = list;
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegistrationBindingModel registration, string listItem)
        {
            if (registration.Date.DayOfWeek == DayOfWeek.Sunday | registration.Date.DayOfWeek == DayOfWeek.Saturday)
            {
                ModelState.AddModelError(nameof(registration.Date), "Консультации не осуществляются в выходные дни!");
            }
            if (registration.Date.DayOfYear < DateTime.Now.DayOfYear)
            {
                ModelState.AddModelError(nameof(registration.Date), "Дата консультации должна быть в будующем времени!");
            }

            if (listItem == "Основы" & registration.Date.DayOfWeek == DayOfWeek.Monday)
            {
                ModelState.AddModelError(nameof(registration.Date), "По курсу \"Основы\" занятия не проводятся в понедельник!");
            }

            if (ModelState.IsValid)
            {
                ViewBag.FName = registration.FName;
                ViewBag.Date = registration.Date.ToShortDateString();
                ViewBag.Course = listItem;
                return View("Success");
            }
            else
            {
                return View(registration);
            }
        }
    }
}

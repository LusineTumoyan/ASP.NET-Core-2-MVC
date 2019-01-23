using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DellCity.Models;
using BusinessLayer;

namespace DellCity.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Population()
        {            
            return View(await Person.GetAllPerson());
        }

        public async Task<IActionResult> Info(int id)
        {
            Person person = (await Person.GetAllPerson()).Where(p => id == p.Id).FirstOrDefault();
            return View(person);
        }


        public async Task<IActionResult> Edit(int id)
        {
            Person person = (await Person.GetAllPerson()).Where(p => id == p.Id).FirstOrDefault();
            return View(person);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Person person)
        {
            if (ModelState.IsValid)
            {
                await person.UpdatePerson();
                return RedirectToAction("Population");
            }
            else
            {
                return View(person);
            }
        }


        [HttpPost]
        public async Task<IActionResult> Delete(Person person)
        {
            await person.DeletePerson();
            return RedirectToAction("Population");
        }


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Person person)
        {
            await person.CreatePerson();
            return RedirectToAction("Population");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

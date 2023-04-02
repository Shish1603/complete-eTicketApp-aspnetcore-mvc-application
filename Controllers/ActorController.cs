using eTicketApp.Data.Services;
using eTicketApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace eTicketApp.Controllers
{
    public class ActorController : Controller
    {
        //Inject IActorsService

        private readonly IActorsService _service;
        public ActorController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allActors = await _service.GetAll();
            return View(allActors);
        }
        //Get: Actor/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Actor actor)
        {
            if(!ModelState.IsValid)
            {
                return View(actor);
            }

             _service.Add(actor);
            return RedirectToAction(nameof(Index));


        }
    }
}

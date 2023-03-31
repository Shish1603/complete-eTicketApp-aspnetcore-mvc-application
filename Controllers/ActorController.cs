using eTicketApp.Data;
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
        //Inject AppDbContext
        private readonly ApplicationDbContext _context;

        public ActorController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allActors = await _context.Actors.ToListAsync();
            return View(allActors);

        }
    }
}

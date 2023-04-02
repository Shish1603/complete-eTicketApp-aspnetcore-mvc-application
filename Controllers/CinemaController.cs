using eTicketApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketApp.Controllers
{
    public class CinemaController : Controller
    {
        //inject AppDbContext
        private readonly ApplicationDbContext _context;

        public CinemaController(ApplicationDbContext context)
        {
            _context = context;
        }

        //to fetch data asynchronously using async

        public async Task<IActionResult> Index()
        {
            var allCinemas = await _context.Cinemas.ToListAsync();
            return View(allCinemas);
        }
    }
}

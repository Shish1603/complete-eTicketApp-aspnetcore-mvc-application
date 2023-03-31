using eTicketApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketApp.Controllers
{
    public class ProducerController : Controller
    {
        //inject AppDbContext
        private readonly ApplicationDbContext _context;

        public ProducerController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        //to fetch data asynchronously using async

        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Producers.ToListAsync();
            return View();
        }

        //public IActionResult Index()
        //{
        //    var allProducers = _context.Producers.ToList();
        //    return View();
        //}

    }
}

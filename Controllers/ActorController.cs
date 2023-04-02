using eTicketApp.Data.Services;
using Microsoft.AspNetCore.Mvc;
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
    }
}

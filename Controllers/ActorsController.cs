using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using eticket.Data;
using eticket.Data.Services;
using System.Threading.Tasks;

namespace eticket.Controllers
{
    [Route("[controller]")]
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service=service;
        }

        public async Task<IActionResult> Index()
        {
            var actors =  await _service.GetAll();            
            return View(actors);
        }       

        //Get: Actors/Create
        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View();
        }         
    }
}
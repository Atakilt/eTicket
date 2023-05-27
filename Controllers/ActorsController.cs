using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using eticket.Data;

namespace eticket.Controllers
{
    [Route("[controller]")]
    public class ActorsController : Controller
    {
        private readonly ILogger<ActorsController> _logger;
        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context, ILogger<ActorsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var data =  _context.Actors.ToList();   
            
            return View(data);
        }        
    }
}
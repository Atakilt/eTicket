using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using eticket.Data;
using Microsoft.EntityFrameworkCore;

namespace eticket.Controllers
{
    [Route("[controller]")]
    public class CinemasController : Controller
    {
        private readonly ILogger<ProducersController> _logger;
        private readonly AppDbContext _context;

        public CinemasController(AppDbContext context,ILogger<ProducersController> logger)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _context.Cinemas.ToListAsync();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
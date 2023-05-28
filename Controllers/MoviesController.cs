using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using eticket.Data;
using Microsoft.EntityFrameworkCore;

namespace eticket.Controllers
{
    [Route("[controller]")]
    public class MoviesController : Controller
    {
        private readonly ILogger<ProducersController> _logger;
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context,ILogger<ProducersController> logger)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var movies = await _context.Movies
                                       .Include(c=>c.Cinema)
                                       .OrderBy(n=>n.Name)
                                       .ToListAsync();
            return View(movies);
        }
    }
}
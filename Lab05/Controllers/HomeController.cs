using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab05.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab05.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RecipeContext _context;

        public HomeController(ILogger<HomeController> logger, RecipeContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.recipes.ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}

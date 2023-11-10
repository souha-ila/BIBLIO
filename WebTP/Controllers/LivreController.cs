using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebTP.Models;

namespace WebTP.Controllers
{
    public class LivreController:Controller
    {
        private readonly ApplicationDbContext _context;

        public LivreController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var livres = _context.Livres.ToList();
            return View(livres);
        }

      

        public IActionResult AjouterLivre()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AjouterLivre(Livre livre)
        {
            _context.Livres.Add(livre);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
}
}

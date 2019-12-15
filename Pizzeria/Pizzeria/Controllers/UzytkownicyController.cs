using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pizzeria.Models;

namespace Pizzeria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UzytkownicyController : ControllerBase
    {
        private s15153Context _context;
        public UzytkownicyController(s15153Context context)
        {
            _context = context;
        }

        //api/danekontaktowe
        [HttpGet]
        public IActionResult GetUzytkownicy()
        {
            return Ok(_context.Uzytkownik.ToList());
        }

        //api/zamowienie/*
        [HttpGet("{id:int}")]
        public IActionResult GetUzytkownik(int id)
        {
            var uzytkownik = _context.Uzytkownik.FirstOrDefault(e => e.IdUzytkownik == id);
            if (uzytkownik == null)
            {
                return NotFound();
            }
            return Ok(uzytkownik);
        }
    }
}
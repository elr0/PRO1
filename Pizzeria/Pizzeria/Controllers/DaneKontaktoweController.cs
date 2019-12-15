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
    public class DaneKontaktoweController : ControllerBase
    {
        private s15153Context _context;
        public DaneKontaktoweController(s15153Context context)
        {
            _context = context;
        }

        //api/danekontaktowe
        [HttpGet]
        public IActionResult GetDaneKontaktowe()
        {
            return Ok(_context.DaneKontaktowe.ToList());
        }

        //api/zamowienie/*
        [HttpGet("{id:int}")]
        public IActionResult GetDaneKontaktowe(int id)
        {
            var daneKontaktowe = _context.DaneKontaktowe.FirstOrDefault(e => e.IdDaneKontaktowe == id);
            if (daneKontaktowe == null)
            {
                return NotFound();
            }
            return Ok(daneKontaktowe);
        }
    }
}
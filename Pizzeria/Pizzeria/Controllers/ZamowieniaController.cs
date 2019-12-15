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
    public class ZamowieniaController : ControllerBase
    {
        private s15153Context _context;
        public ZamowieniaController(s15153Context context)
        {
            _context = context;
        }

        //api/zamowienie
        [HttpGet]
        public IActionResult GetZamowienia()
        {
            return Ok(_context.Zamowienie.ToList());
        }

        //api/zamowienie/*
        [HttpGet("{id:int}")]
        public IActionResult GetZamowienie(int id)
        {
            var zamowienie = _context.Zamowienie.FirstOrDefault(e => e.IdZamowienie == id);
            if (zamowienie == null)
            {
                return NotFound();
            }
            return Ok(zamowienie);
        }
    }
}
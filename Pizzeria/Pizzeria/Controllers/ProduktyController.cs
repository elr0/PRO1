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
    public class ProduktyController : ControllerBase
    {
        private s15153Context _context;
        public ProduktyController(s15153Context context)
        {
            _context = context;
        }

        //api/products
        [HttpGet]
        public IActionResult GetProdukty()
        {
            return Ok(_context.Produkt.ToList());
        }

        //api/products/*
        [HttpGet("{id:int}")]
        public IActionResult GetProdukt(int id)
        {
            var product = _context.Produkt.FirstOrDefault(e => e.IdProdukt == id);
            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proeventos.API.Data;
using proeventos.API.Models;

namespace proeventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        public readonly DataContext _context;

        public EventosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(Evento => Evento.EventoId == id);
        }


        [HttpPost]
        public String Post()
        {
            return "exe post";
            
        }

        [HttpPut("{id}")]
        public String Put(int id)
        {
            return $"exemplo put com id= {id}";
            
        }

        [HttpDelete("{id}")]
        public String Delete(int id)
        {
            return $"exemplo delete com id= {id}";
            
        }
    }
}

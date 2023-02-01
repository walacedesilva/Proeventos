using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proeventos.API.Models;

namespace proeventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public EventoController()
        {
        }

        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento(){
                    EventoId= 1,
                    Tema = "Angular 11 e net 5",
                    Local = "Belo Horizonte",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    imagemURL = "foto.png"
                },
                new Evento(){
                    EventoId= 2,
                    Tema = "Angular 11 e net 5",
                    Local = "Sao paulo",
                    QtdPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    imagemURL = "foto1.png"
                }
            };
        



        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(Evento => Evento.EventoId == id);
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

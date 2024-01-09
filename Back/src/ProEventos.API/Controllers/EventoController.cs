using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public IEnumerable<Evento> _eventos = new Evento[]
    {
        new Evento()
        {
            EventoId = 1,
            Tema = "Angular 11  e .NET 5",
            Local = "Belo Horizonte",
            Lote = "1º Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            ImagemUrl = "foto.png"
        },
         new Evento() {
            EventoId = 2,
            Tema = "Angular 11  e suas novidades",
            Local = "São Paulo",
            Lote = "2º Lote",
            QtdPessoas = 350,
            DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
            ImagemUrl = "foto1.png"
        }
    };

    public EventoController()
    {
    }

    [HttpGet]
    public IEnumerable<Evento> Get() => _eventos;
    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id) => _eventos.Where(evento => evento.EventoId == id);

    [HttpPost]
    public string Post() => "Exemplo de Post";

    [HttpPut("{id}")]
    public string Put(int id) => $"Exemplo de Put com id = {id}";

    [HttpDelete("{id}")]
    public string Delete(int id) => $"Exemplo de Delete com id = {id}";
}

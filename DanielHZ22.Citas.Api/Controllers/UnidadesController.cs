using Microsoft.AspNetCore.Mvc;

namespace DanielHZ22.Citas.Api.Controllers
{
    [ApiController]
    [Route("api/unidades")]
    public class UnidadesController: ControllerBase
    {
        [HttpGet]
        public IEnumerable<Unidad> Get()
        { 
            return new List<Unidad> 
            { 
                new Unidad{Id = Guid.NewGuid(), Nombre = "Clinica 1", Privada = false},
                new Unidad{Id = Guid.NewGuid(), Nombre = "Clinica 2", Privada = true},
            };
        }
    }

    public class Unidad
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public bool Privada { get; set; }
    }
}

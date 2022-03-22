using BankAPI.Services.Int;
using BankDomain.Model;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GerenteController : ControllerBase
    {
        private readonly IGerenteService GerenteService;

        public GerenteController(IGerenteService GerenteService)
        {
            this.GerenteService = GerenteService;
        }

        [HttpGet]
        [Route("/GetGerentes")]
        public IActionResult getClient()
        {
            return Ok(this.GerenteService.GetAllGerente());
        }

        [HttpPost]
        [Route("/addGerente")]
        public IActionResult addGerente(Gerente Gerente)
        {
            Gerente added = this.GerenteService.addGerente(Gerente);
            return Created("Success", added);
        }
    }
}

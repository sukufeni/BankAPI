using BankAPI.Services.Int;
using BankDomain.Model;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClienteService ClienteService;

        public ClientController(IClienteService ClienteService)
        {
            this.ClienteService = ClienteService;
        }
        [HttpGet]
        [Route("/GetClientes")]
        public IActionResult getClient()
        {
            return Ok(this.ClienteService.GetAllCliente());
        }

        [HttpPost]
        [Route("/addCliente")]
        public IActionResult addCliente(Cliente Cliente)
        {
            Cliente added = this.ClienteService.addCliente(Cliente);
            return Created("Success", added);
        }
    }
}

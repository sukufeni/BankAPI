using BankAPI.Services.Int;
using Microsoft.AspNetCore.Mvc;

namespace BankAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaController : ControllerBase
    {
        private readonly IContaService contaService;

        public ContaController(IContaService contaService)
        {
            this.contaService = contaService;
        }

        [HttpGet]
        [Route("/DetalheConta")]
        public IActionResult getConta(int nrContaClient)
        {
            try
            {
                return Ok(this.contaService.GetConta(nrContaClient));
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
        }


        [HttpPost]
        [Route("/Saque")]
        [ActionName("/Saque/{nrContaClient}/{valorSaque}")]
        public IActionResult makeSaque(int nrContaClient, decimal valorSaque)
        {
            try
            {
                return Ok(this.contaService.saque(nrContaClient, valorSaque));
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
        }

        [HttpPatch]
        [Route("/Depositar")]
        [ActionName("/Depositar/{nrContaClient}/{valorDeposito}")]
        public IActionResult makeDeposito(int nrContaClient, decimal valorDeposito)
        {
            try
            {
                return Ok(this.contaService.deposito(nrContaClient, valorDeposito));
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
        }

        [HttpPut]
        [Route("/transferencia")]
        [ActionName("/Transferencia/{nrContaClient}/{destClient}/{valorTransferencia}")]
        public IActionResult makeTransferencia(int nrContaClient, int destClient, decimal valorTransferencia)
        {
            try
            {
                return Ok(this.contaService.transferir(nrContaClient, destClient, valorTransferencia));
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using senac_loja.Entidades.Cliente;
using senac_loja.Interfaces.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senac_loja.Controllers
{
    [Route("cliente")]
    public class ClienteController : Controller
    {
        private readonly IClienteService _appService;

        public ClienteController(IClienteService appService) 
        {
            _appService = appService;
        }
        public IActionResult Cliente()
        {
            return View();
        }
        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Listar()
        {
            var retorno = _appService.Listar();
            return View("ClienteInserir");
           // return Ok(retorno);
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<IActionResult> ListarPeloId(int id)
        {
            var retorno = _appService.ListarPeloId(id);
            return Ok(retorno);
        }

        [HttpPost]
        [Route("Save")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Salvar(/*[FromBody]*/ Cliente cliente)
        {
             _appService.Salvar(cliente);
            return Ok();
        }
        [HttpDelete]
        [Route("Delete")]
        public async Task<IActionResult> Deletar(int id)
        {
            _appService.Deletar(id);
            return Ok();
        }
    }
}

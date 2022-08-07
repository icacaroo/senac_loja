using Microsoft.AspNetCore.Mvc;
using senac_loja.Entidades.Venda;
using senac_loja.Interfaces.Venda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senac_loja.Controllers
{
    [Route("venda")]
    public class VendaController : Controller
    {
        private readonly IVendaService _appService;

        public VendaController(IVendaService appService)
        {
            _appService = appService;
        }
        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Listar()
        {
            var retorno =  _appService.Listar();
            return Ok(retorno);
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> ListarPeloId(int id)
        {
            var retorno = _appService.ListarPeloId(id);
            return Ok(retorno);
        }
        [HttpPost]
        [Route("Save")]
        public async Task<IActionResult> Salvar([FromBody] Venda venda)
        {
            _appService.Salvar(venda);
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

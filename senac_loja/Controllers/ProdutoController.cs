using Microsoft.AspNetCore.Mvc;
using senac_loja.Entidades.Produto;
using senac_loja.Interfaces.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senac_loja.Controllers
{
    [Route("produto")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _appService;

        public ProdutoController(IProdutoService appService)
        {
            _appService = appService;
        }

        [HttpGet]   
        [Route("Get")]
        public async Task<IActionResult> Listar ()
        {
            var retorno = _appService.Listar();
            return Ok(retorno);
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> ListarPeloId( int id)
        {
            var retorno = _appService.ListarPeloId(id);
            return Ok(retorno);
        }
        [HttpPost]
        [Route("Save")]
        public async Task<IActionResult> Salvar([FromBody] Produto produto)
        {
            _appService.Salvar(produto);
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

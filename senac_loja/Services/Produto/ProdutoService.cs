using senac_loja.Interfaces.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senac_loja.Services.Produto
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }
        public void Deletar(int id)
        {
            _repository.Deletar(id);
        }

        public IList<Entidades.Produto.Produto> Listar()
        {
            return _repository.Listar();
        }

        public Entidades.Produto.Produto ListarPeloId(int id)
        {
            return _repository.ListarPeloId(id);
        }

        public void Salvar(Entidades.Produto.Produto produto)
        {
            _repository.Salvar(produto);
        }
    }
}

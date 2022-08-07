using senac_loja.Interfaces.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senac_loja.Repository.Produto
{
    public class ProdutoRepository : IProdutoRepository
    {
        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Entidades.Produto.Produto> Listar()
        {
            throw new NotImplementedException();
        }

        public Entidades.Produto.Produto ListarPeloId(int id)
        {
            throw new NotImplementedException();
        }

        public void Salvar(Entidades.Produto.Produto produto)
        {
            throw new NotImplementedException();
        }
    }
}

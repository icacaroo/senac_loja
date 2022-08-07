using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senac_loja.Interfaces.Produto
{
    public interface IProdutoService
    {
        IList<senac_loja.Entidades.Produto.Produto> Listar();
        senac_loja.Entidades.Produto.Produto ListarPeloId(int id);
        void Salvar(senac_loja.Entidades.Produto.Produto produto);
        void Deletar(int id);

    }
}

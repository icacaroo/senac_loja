using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senac_loja.Interfaces.Venda
{
    public interface IVendaRepository
    {
        IList<senac_loja.Entidades.Venda.Venda> Listar();
        senac_loja.Entidades.Venda.Venda ListarPeloId(int id);
        void Salvar(senac_loja.Entidades.Venda.Venda venda);
        void Deletar(int id);
    }
}

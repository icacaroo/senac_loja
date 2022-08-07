using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace senac_loja.Interfaces.Cliente
{
    public interface IClienteService
    {
        IList<senac_loja.Entidades.Cliente.Cliente>  Listar();
        senac_loja.Entidades.Cliente.Cliente ListarPeloId(int id);
        void Salvar(senac_loja.Entidades.Cliente.Cliente cliente);
        void Deletar(int id);

    }
}

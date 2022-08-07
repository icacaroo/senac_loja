using senac_loja.Interfaces.Venda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senac_loja.Services.Venda
{
    public class VendaService : IVendaService
    {
        private readonly IVendaRepository _repository;

        public VendaService(IVendaRepository repository)
        {
            _repository = repository;
        }
        public void Deletar(int id)
        {
            _repository.Deletar(id);
        }

        public IList<Entidades.Venda.Venda> Listar()
        {
            return _repository.Listar();
        }

        public Entidades.Venda.Venda ListarPeloId(int id)
        {
            return _repository.ListarPeloId(id); ;
        }

        public void Salvar(Entidades.Venda.Venda venda)
        {
            _repository.Salvar(venda);
        }
    }
}

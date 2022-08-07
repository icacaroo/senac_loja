using senac_loja.Entidades.Cliente;
using senac_loja.Interfaces.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senac_loja.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repository;

        public ClienteService(IClienteRepository repository)
        {
            _repository = repository;
        }
        public void Deletar(int id)
        {
            _repository.Deletar(id);
           // throw new NotImplementedException();
        }

        public IList<Cliente> Listar()
        {
           
            return _repository.Listar();
           // return new List<Cliente>() { new Cliente() { Ativo = true ,Cpf = "23367341843",Nome = "Icaro",Id=1} };
           // throw new NotImplementedException();
        }

        public Cliente ListarPeloId(int id)
        {
            return _repository.ListarPeloId(id);
        }

        public void Salvar(Cliente cliente)
        {
            _repository.Salvar(cliente);
           // throw new NotImplementedException();
        }
    }
}

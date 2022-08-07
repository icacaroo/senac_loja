using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senac_loja.Entidades.Cliente
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime? Dh_Nascimento { get; set; }
        public bool Ativo { get; set; }
        public int Id_Tipo { get; set; }
    }
}

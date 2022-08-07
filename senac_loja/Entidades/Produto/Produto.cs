using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senac_loja.Entidades.Produto
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Dh_Validade { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }

    }
}

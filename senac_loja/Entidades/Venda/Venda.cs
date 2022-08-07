using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senac_loja.Entidades.Venda
{
    public class Venda
    {
        public int Id { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Produto { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaAvonale.Models.Responses
{
    public class DetalhesProdutos
    {
        public string Nome { get; set; }
        public double Valor_Unitario { get; set; }
        public int Qtde_Estoque { get; set; }
        public DateTime Data_Venda { get; set; }
        public double Valor_Venda { get; set; }
    }
}

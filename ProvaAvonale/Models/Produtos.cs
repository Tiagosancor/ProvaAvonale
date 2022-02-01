using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaAvonale.Models
{
    public class Produtos
    {
        public int Produto_Id { get; set; }
        public string Nome { get; set; }
        public double Valor_Unitario { get; set; }
        public int Qtde_Estoque { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaAvonale.Models.Responses
{
    public class ProdutosResponse
    {
       public string Nome { get; set; } 
       public double Valor { get; set; }
       public int Quantidade_Estoque  { get; set; }
    }
}

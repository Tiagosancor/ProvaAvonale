using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaAvonale.Models.Requests
{
    public class PagamentoCompras
    {
        public double Valor { get; set; }
        public Cartoes Cartao { get; set; }
    }
}

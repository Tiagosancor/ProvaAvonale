using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaAvonale.Models.Requests
{
    public class ComprasRequest
    {
       public int Produto_Id { get; set; }
       public int Qtde_Comprada { get; set; }
       public Cartoes Cartao { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProvaAvonale.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaAvonale.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LojaController : ControllerBase
    {

        [HttpPost]
        [Route("api/produtos")]
        public Task<IActionResult> AdicionaProduto(ProdutosRequest produtosRequest)
        {
            var result = Services.LojaServices(produtosRequest);
            Ok();
        }  

        [HttpGet]
        [Route("api/produtos")]
        public Task<IActionResult> ListaProduto()
        {
            Ok();
        }

        [HttpGet]
        [Route("api/produtos")]
        public Task<IActionResult> DetalhaProduto(int produto_Id)
        {
            Ok();
        }

        [HttpPost]
        [Route("api/produtos")]
        public Task<IActionResult> CompraProduto(ComprasRequest comprasRequest)
        {
            Ok();
        }

        [HttpDelete]
        [Route("api/compras")]
        public Task<IActionResult> DeletaProduto(int produto_Id)
        {
            Ok();
        }

        [HttpPost]
        [Route("api/pagamento/compras")]
        public Task<IActionResult> PagamentoProduto(PagamentoCompras pagamentoCompras)
        {
            Ok();
        }
    }

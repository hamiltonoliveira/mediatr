using Infra.Interface;
using mediador.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace mediador.Controllers
{
    [Route("api/[controller]")]
    public class ProdutoController : Controller
    {

        private readonly IMediator _mediatr;
        public ProdutoController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        public IActionResult Index()
        {
            return View();
        }

         [HttpPost("Post")]
        public async Task<IActionResult> Post([FromBody]Produto message)
        {

            var response = await _mediatr.Send(message);

            if (response.IsNormalized())
            {
                return Ok(message);
            }
            return Ok(response);
        }


    }
}
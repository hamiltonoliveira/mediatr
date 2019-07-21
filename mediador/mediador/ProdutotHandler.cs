using Infra.Interface;
using mediador.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace mediador
{
    public class ProdutotHandler : IRequestHandler<Produto, string>
    {
        private readonly IRepositorio<Produto> _repo;

        public ProdutotHandler(IRepositorio<Produto> repo)
        {
            _repo = repo;
        }
        public async Task<string> Handle(Produto request, CancellationToken cancellationToken)
        {
           await  _repo.InsertAsync(request);
           
            //throw new NotImplementedException();
            return "Preencher todos os campos.";
        }
    }
}

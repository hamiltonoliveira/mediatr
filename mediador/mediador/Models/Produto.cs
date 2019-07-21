

using MediatR;

namespace mediador.Models
{
    public class Produto: IRequest<string>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}

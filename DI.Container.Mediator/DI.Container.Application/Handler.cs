using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DI.Container.Application
{
    public class Handler : IRequestHandler<Request, string>
    {
        public async Task<string> Handle(Request request, CancellationToken cancellationToken)
        {
            await Task.Delay(1);
            return "Hello World";
        }
    }
}
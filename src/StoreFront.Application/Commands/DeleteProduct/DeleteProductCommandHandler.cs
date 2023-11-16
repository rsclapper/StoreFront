using MediatR;
using StoreFront.Application.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace StoreFront.Application.Commands.DeleteProduct
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, Unit>
    {
        private readonly IProductService _productService;

        public DeleteProductCommandHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            await _productService.DeleteProductAsync(request.Id);
            return Unit.Value; // MediatR way to say "void" for handlers that do not return a value
        }
    }
}
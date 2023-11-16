using MediatR;
using StoreFront.Application.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace StoreFront.Application.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Unit>
    {
        private readonly IProductService _productService;

        public UpdateProductCommandHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            await _productService.UpdateProductAsync(request.Id, request.ProductDto);
            return Unit.Value; // MediatR way to indicate "void" or "no return value"
        }
    }
}
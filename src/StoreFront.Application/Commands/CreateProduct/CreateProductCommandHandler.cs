using MediatR;
using StoreFront.Application.DTOs;
using StoreFront.Application.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace StoreFront.Application.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ProductDto>
    {
        private readonly IProductService _productService;

        public CreateProductCommandHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<ProductDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            // Map the command to the DTO
            var productDto = new ProductDto
            {
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
                ReleaseDate = request.ReleaseDate
            };

            // Use the product service to create a new product
            var result = await _productService.CreateProductAsync(productDto);
            return result;
        }
    }
}
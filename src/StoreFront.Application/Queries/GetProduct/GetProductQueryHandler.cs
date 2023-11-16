using MediatR;
using StoreFront.Application.DTOs;
using StoreFront.Application.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StoreFront.Application.Queries.GetProduct;

namespace StoreFront.Application.Queries.GetAllProducts
{
    public class GetAllProductQueryHandler : IRequestHandler<GetProductQuery, ProductDto>
    {
        private readonly IProductService _productService;

        public GetAllProductQueryHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<ProductDto> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            return await _productService.GetProductByIdAsync(request.Id);
        }
    }
}
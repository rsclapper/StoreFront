using MediatR;
using StoreFront.Application.DTOs;
using System.Collections.Generic;

namespace StoreFront.Application.Queries.GetAllProducts
{
    public class GetAllProductsQuery : IRequest<IEnumerable<ProductDto>>
    {
    }
}
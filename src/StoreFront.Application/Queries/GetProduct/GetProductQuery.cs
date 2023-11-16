using MediatR;
using StoreFront.Application.DTOs;
using System.Collections.Generic;

namespace StoreFront.Application.Queries.GetProduct
{
    public class GetProductQuery : IRequest<ProductDto>
    {
        public int Id { get; set; }

        public GetProductQuery(int id)
        {
            Id = id;
        }
    }
}
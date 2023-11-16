using MediatR;
using StoreFront.Application.DTOs;

namespace StoreFront.Application.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<ProductDto>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime? ReleaseDate { get; set; }

        // You can add additional fields as required for product creation.
    }
}
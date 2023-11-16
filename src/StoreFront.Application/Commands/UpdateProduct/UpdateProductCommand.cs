using MediatR;
using StoreFront.Application.DTOs;

namespace StoreFront.Application.Commands.UpdateProduct
{
    public class UpdateProductCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public ProductDto ProductDto { get; set; }


        public UpdateProductCommand(int id, ProductDto productDto)
        {
            Id = id;
            ProductDto = productDto;
        }
        // You can add additional fields as required for product creation.
    }
}
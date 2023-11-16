using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StoreFront.Application.Commands.CreateProduct;
using StoreFront.Application.Queries.GetAllProducts;
using StoreFront.Application.Queries.GetProduct;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    // [Authorize(Policy = "UserPolicy")]
    public async Task<IActionResult> Get()
    {
        var products = await _mediator.Send(new GetAllProductsQuery());
        return Ok(products);
    }

    [HttpGet("{id}")]
    // [Authorize(Policy = "UserPolicy")]
    public async Task<IActionResult> GetById(int id)
    {
        var product = await _mediator.Send(new GetProductQuery(id));
        return Ok(product);
    }
    
    // CRUD operations for VendorUser only
    // Example for CreateProduct
    [HttpPost]
    // [Authorize(Policy = "VendorPolicy")]
    public async Task<IActionResult> Create(CreateProductCommand command)
    {
        var productId = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetById), new { id = productId }, command);
    }

    
    // Other CRUD actions
}
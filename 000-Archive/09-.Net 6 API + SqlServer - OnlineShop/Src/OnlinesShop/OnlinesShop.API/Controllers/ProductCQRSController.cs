using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlinesShop.Application.CQRS.ProductCommandQuery.Command;

namespace OnlinesShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCQRSController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductCQRSController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(SaveProductCommand saveProductCommand)
        {
            var result = await _mediator.Send(saveProductCommand);

            return Ok(result);
        }
    }
}

namespace Customer.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Customer.Application.Features.DeleteBuyer;

[ApiController]
[Route("api/[controller]")]
public class BuyerController : ControllerBase
{
    private readonly IMediator _mediator;
    public BuyerController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteBuyer(Guid id)
    {
        var response = _mediator.Send(new DeleteBuyerCommand { Id = id });
        return NoContent();
    }
}
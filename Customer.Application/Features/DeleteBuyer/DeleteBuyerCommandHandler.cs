using MediatR;

namespace Customer.Application.Features.DeleteBuyer;

public class DeleteBuyerCommandHandler : IRequestHandler<DeleteBuyerCommand, bool>
{
    public Task<bool> Handle(DeleteBuyerCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(true);
    }
}
using MediatR;

namespace Customer.Application.Features.DeleteBuyer;

 public class DeleteBuyerCommand: IRequest<bool>
 {
     public Guid Id { get; set; }
 }
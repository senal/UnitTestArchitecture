using Customer.Application.Features.DeleteBuyer;
using Microsoft.Extensions.DependencyInjection;

namespace Customer.Application.Extenions;

public static class AddApplicationExtensions
{
    public static void AddApplication(this IServiceCollection self)
    {
        self.AddMediatR(x => x.RegisterServicesFromAssemblies(typeof(DeleteBuyerCommand).Assembly));

    }
}

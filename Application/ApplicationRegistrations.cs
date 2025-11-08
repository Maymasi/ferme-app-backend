using Application.PipelineBehaviour;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ApplicationRegistrations
    {
        public static void AddApplicationRegistrations(this IServiceCollection services)
        {
            services.AddMediatR(options => options.RegisterServicesFromAssembly(typeof(ApplicationRegistrations).Assembly));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            //services.AddFluentValidation(typeof(ApplicationRegistrations));
        }
    }
}

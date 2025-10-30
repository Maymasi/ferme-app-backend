using FluentValidation;
using MediatR;

namespace Application.PipelineBehaviour
{
    public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {

        private readonly IEnumerable<IValidator<TRequest>> _validators;
        public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators) =>
            _validators = validators;

        public Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var context = new ValidationContext<TRequest>(request);
            var failures = _validators.Select(o => o.Validate(context))
                                       .SelectMany(om  => om.Errors)
                                       .Where(oc => oc != null)
                                       .ToList();

            //ici où il retourne les messages de validator
            if (failures.Any())
                throw new ValidationException(failures);

            return next();
        }
    }
}

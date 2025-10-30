using Application.FarmFeature.Commands;
using FluentValidation;

namespace Application.FarmFeature.Validations
{
    public class CreateFarmCommandValidator : AbstractValidator<CreateFarmCommand>
    {
        public CreateFarmCommandValidator()
        {
            RuleFor(o => o.farmRequestDto.name)
                    .NotEmpty().WithMessage("Le nom de la Ferme est obligatoire")
                    .MaximumLength(100).WithMessage("Le nom ne doit pas dépasser 100 caractères");

            RuleFor(o => o.farmRequestDto.address)
                    .NotEmpty().WithMessage("L'address de la Ferme est obligatoire")
                    .MaximumLength(200).WithMessage("L'address ne doit pas dépasser 200 caractères");

            RuleFor(o => o.farmRequestDto.latitude)
                    .InclusiveBetween(-90, 90).WithMessage("La latitude doit être comprise entre -90 et 90");

            RuleFor(o => o.farmRequestDto.longitude)
                    .InclusiveBetween(-180, 180).WithMessage("La latitude doit être comprise entre -180 et 180");
        }
    }
}

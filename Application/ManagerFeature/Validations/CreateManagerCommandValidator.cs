using Application.ManagerFeature.Commands;
using FluentValidation;

namespace Application.ManagerFeature.Validations
{
    public class CreateManagerCommandValidator : AbstractValidator<CreateManagerCommand>
    {
        public CreateManagerCommandValidator()
        {
            RuleFor(o => o.ManagerRequestDto.email)
                .NotEmpty().WithMessage("L'email est obligatoire")
                .EmailAddress().WithMessage("le format de l'email est invalide");

            RuleFor(o => o.ManagerRequestDto.firstName)
                .NotEmpty().WithMessage("Le Prénom est obligatoire")
                .MaximumLength(200).WithMessage("le prénom ne doit pas dépasser 200 caractères");

            RuleFor(o => o.ManagerRequestDto.lastName)
                .NotEmpty().WithMessage("Le Nom est obligatoire")
                .MaximumLength(200).WithMessage("le prénom ne doit pas dépasser 200 caractères");

            RuleFor(p => p.ManagerRequestDto.password)
                .NotEmpty().WithMessage("Le mot de passe est obligatoire")
                .MinimumLength(8).WithMessage("La longueur de votre mot de passe doit être d'au moins 8 caractères.")
                .MaximumLength(16).WithMessage("La longueur de votre mot de passe ne doit pas dépasser 16 caractères.")
                .Matches(@"[A-Z]+").WithMessage("Votre mot de passe doit contenir au moins une lettre majuscule.")
                .Matches(@"[a-z]+").WithMessage("Votre mot de passe doit contenir au moins une lettre minuscule.")
                .Matches(@"[0-9]+").WithMessage("Votre mot de passe doit contenir au moins un chiffre.")
                .Matches(@"[\!\?\*\.]+").WithMessage("Votre mot de passe doit contenir au moins un caractère spécial (!? *.).");

        }
    }
}

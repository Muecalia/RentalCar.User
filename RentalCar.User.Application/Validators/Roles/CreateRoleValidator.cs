using FluentValidation;
using RentalCar.User.Application.Commands.Request.Roles;

namespace RentalCar.User.Application.Validators.Roles
{
    public class CreateRoleValidator : AbstractValidator<CreateRoleRequest>
    {
        public CreateRoleValidator() 
        {
            RuleFor(r => r.Name)
                .NotEmpty()
                .WithMessage("Informe o nome");
        }
    }
}

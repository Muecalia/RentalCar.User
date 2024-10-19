using FluentValidation;
using RentalCar.User.Application.Commands.Request.Roles;

namespace RentalCar.User.Application.Validators.Roles
{
    public class DeleteRoleValidator : AbstractValidator<DeleteRoleRequest>
    {
        public DeleteRoleValidator() 
        {
            RuleFor(r => r.Id)
                .NotEmpty()
                .WithMessage("Informa o código do utilizador");
        }
    }
}

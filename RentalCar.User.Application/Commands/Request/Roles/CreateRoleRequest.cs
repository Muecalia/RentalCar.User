using MediatR;
using RentalCar.User.Application.Commands.Response.Roles;
using RentalCar.User.Application.Wrappers;

namespace RentalCar.User.Application.Commands.Request.Roles
{
    public class CreateRoleRequest : IRequest<ApiResponse<InputRoleResponse>>
    {
        public string Name { get; set; } = string.Empty;
    }
}

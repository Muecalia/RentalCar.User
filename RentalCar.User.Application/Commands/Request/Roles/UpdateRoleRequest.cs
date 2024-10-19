using MediatR;
using RentalCar.User.Application.Commands.Response.Roles;
using RentalCar.User.Application.Wrappers;

namespace RentalCar.User.Application.Commands.Request.Roles
{
    public class UpdateRoleRequest : IRequest<ApiResponse<InputRoleResponse>>
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}

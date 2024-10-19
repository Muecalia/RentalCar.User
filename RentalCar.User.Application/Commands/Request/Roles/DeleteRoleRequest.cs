using MediatR;
using RentalCar.User.Application.Commands.Response.Roles;
using RentalCar.User.Application.Wrappers;

namespace RentalCar.User.Application.Commands.Request.Roles
{
    public class DeleteRoleRequest(string id) : IRequest<ApiResponse<InputRoleResponse>>
    {
        public string Id { get; set; } = id;
    }
}

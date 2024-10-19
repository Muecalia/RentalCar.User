using MediatR;
using RentalCar.User.Application.Queries.Response.Roles;
using RentalCar.User.Application.Wrappers;

namespace RentalCar.User.Application.Queries.Request.Roles
{
    public class FindRoleByIdRequest(string id) : IRequest<ApiResponse<FindRoleResponse>>
    {
        public string Id { get; set; } = id;
    }
}

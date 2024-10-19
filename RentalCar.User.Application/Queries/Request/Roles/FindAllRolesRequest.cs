using MediatR;
using RentalCar.User.Application.Queries.Response.Roles;
using RentalCar.User.Application.Wrappers;

namespace RentalCar.User.Application.Queries.Request.Roles
{
    public class FindAllRolesRequest : IRequest<PagedResponse<FindRoleResponse>>
    {
    }
}

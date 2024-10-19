using MediatR;
using RentalCar.User.Application.Queries.Request.Roles;
using RentalCar.User.Application.Queries.Response.Roles;
using RentalCar.User.Application.Utils;
using RentalCar.User.Application.Wrappers;
using RentalCar.User.Core.Repositories;

namespace RentalCar.User.Application.Handlers.Roles
{
    public class FindRoleByIdHandler : IRequestHandler<FindRoleByIdRequest, ApiResponse<FindRoleResponse>>
    {
        private readonly IRoleRepository _iRoleRepository;

        public FindRoleByIdHandler(IRoleRepository iRoleRepository)
        {
            _iRoleRepository = iRoleRepository;
        }

        public async Task<ApiResponse<FindRoleResponse>> Handle(FindRoleByIdRequest request, CancellationToken cancellationToken)
        {
            const string Entidade = "perfil";
            try
            {
                var role = await _iRoleRepository.GetById(request.Id, cancellationToken);
                if (role == null)
                    return ApiResponse<FindRoleResponse>.Error(MensagemError.NotFound(Entidade));

                var result = new FindRoleResponse(role.Id, role.Name);
                return ApiResponse<FindRoleResponse>.Success(result, MensagemError.CarregamentoSucesso(Entidade));
            }
            catch (Exception ex)
            {
                return new PagedResponse<FindRoleResponse>(MensagemError.CarregamentoErro(Entidade, ex.Message));
                //throw;
            }
        }
    }
}

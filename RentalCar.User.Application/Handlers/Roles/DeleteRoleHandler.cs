using MediatR;
using RentalCar.User.Application.Commands.Request.Roles;
using RentalCar.User.Application.Commands.Response.Roles;
using RentalCar.User.Application.Utils;
using RentalCar.User.Application.Wrappers;
using RentalCar.User.Core.Repositories;

namespace RentalCar.User.Application.Handlers.Roles
{
    public class DeleteRoleHandler : IRequestHandler<DeleteRoleRequest, ApiResponse<InputRoleResponse>>
    {
        private readonly IRoleRepository _iRoleRepository;

        public DeleteRoleHandler(IRoleRepository iRoleRepository)
        {
            _iRoleRepository = iRoleRepository;
        }

        public async Task<ApiResponse<InputRoleResponse>> Handle(DeleteRoleRequest request, CancellationToken cancellationToken)
        {
            const string Entidade = "perfil";
            const string Operacao = "eliminar";
            try
            {
                var role = await _iRoleRepository.GetById(request.Id, cancellationToken);
                if (role == null)
                    return ApiResponse<InputRoleResponse>.Error(MensagemError.NotFound(Entidade));

                var result = await _iRoleRepository.Delete(role);
                if (!result)
                    return ApiResponse<InputRoleResponse>.Error(MensagemError.OperacaoErro(Entidade, Operacao));

                var response = new InputRoleResponse(role.Id, role.Name);

                return ApiResponse<InputRoleResponse>.Success(response, MensagemError.OperacaoSucesso(Entidade, Operacao));
            }
            catch (Exception ex)
            {
                return ApiResponse<InputRoleResponse>.Error(MensagemError.OperacaoErro(Entidade, Operacao, ex.Message));
                throw;
            }
        }
    }
}

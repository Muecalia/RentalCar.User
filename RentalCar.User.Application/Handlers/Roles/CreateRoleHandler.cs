using MediatR;
using RentalCar.User.Application.Commands.Request.Roles;
using RentalCar.User.Application.Commands.Response.Roles;
using RentalCar.User.Application.Utils;
using RentalCar.User.Application.Wrappers;
using RentalCar.User.Core.Repositories;

namespace RentalCar.User.Application.Handlers.Roles
{
    public class CreateRoleHandler : IRequestHandler<CreateRoleRequest, ApiResponse<InputRoleResponse>>
    {
        private readonly IRoleRepository _iRoleRepository;

        public CreateRoleHandler(IRoleRepository iRoleRepository)
        {
            _iRoleRepository = iRoleRepository;
        }

        public async Task<ApiResponse<InputRoleResponse>> Handle(CreateRoleRequest request, CancellationToken cancellationToken)
        {
            const string Entidade = "perfil";
            const string Operacao = "criar"; 
            try
            {
                if (await _iRoleRepository.Exists(request.Name, cancellationToken))
                    return ApiResponse<InputRoleResponse>.Error(MensagemError.Conflito(Entidade));

                var result = await _iRoleRepository.Create(request.Name);

                if (result == null)
                    return ApiResponse<InputRoleResponse>.Error(MensagemError.CarregamentoErro(Entidade, Operacao));

                var rsponse = new InputRoleResponse(result.Id, result.Name);

                return ApiResponse<InputRoleResponse>.Success(rsponse, MensagemError.OperacaoSucesso(Entidade, Operacao));
            }
            catch (Exception ex)
            {
                return ApiResponse<InputRoleResponse>.Error(MensagemError.OperacaoErro(Entidade, Operacao, ex.Message));
                throw;
            }
        }
    }
}

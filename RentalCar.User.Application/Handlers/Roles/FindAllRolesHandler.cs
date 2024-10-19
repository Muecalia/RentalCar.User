using MediatR;
using RentalCar.User.Application.Queries.Request.Roles;
using RentalCar.User.Application.Queries.Response.Roles;
using RentalCar.User.Application.Utils;
using RentalCar.User.Application.Wrappers;
using RentalCar.User.Core.Repositories;

namespace RentalCar.User.Application.Handlers.Roles
{
    public class FindAllRolesHandler : IRequestHandler<FindAllRolesRequest, PagedResponse<FindRoleResponse>>
    {
        private readonly IRoleRepository _iRoleRepository;

        public FindAllRolesHandler(IRoleRepository iRoleRepository)
        {
            _iRoleRepository = iRoleRepository;
        }

        public async Task<PagedResponse<FindRoleResponse>> Handle(FindAllRolesRequest request, CancellationToken cancellationToken)
        {
            const string Entidade = "perfil";
            try
            {
                var result = new List<FindRoleResponse>();
                var roles = await _iRoleRepository.GetAll(cancellationToken);

                roles.ForEach(role => result.Add(new FindRoleResponse(role.Id, role.Name)));

                return new PagedResponse<FindRoleResponse>(result, MensagemError.CarregamentoSucesso(Entidade, roles.Count));
            }
            catch (Exception ex)
            {
                return new PagedResponse<FindRoleResponse>(MensagemError.CarregamentoErro(Entidade, ex.Message));
                //throw;
            }
        }
    }
}

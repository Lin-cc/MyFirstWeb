using System.Threading.Tasks;
using Abp.Application.Services;
using MyFirstWeb.Roles.Dto;

namespace MyFirstWeb.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}

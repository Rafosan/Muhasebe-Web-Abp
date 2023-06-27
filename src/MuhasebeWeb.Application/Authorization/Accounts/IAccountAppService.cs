using System.Threading.Tasks;
using Abp.Application.Services;
using MuhasebeWeb.Authorization.Accounts.Dto;

namespace MuhasebeWeb.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

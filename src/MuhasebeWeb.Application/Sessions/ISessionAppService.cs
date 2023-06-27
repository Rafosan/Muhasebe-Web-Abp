using System.Threading.Tasks;
using Abp.Application.Services;
using MuhasebeWeb.Sessions.Dto;

namespace MuhasebeWeb.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

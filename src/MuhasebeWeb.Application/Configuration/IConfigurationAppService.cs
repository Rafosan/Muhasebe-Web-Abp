using System.Threading.Tasks;
using MuhasebeWeb.Configuration.Dto;

namespace MuhasebeWeb.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

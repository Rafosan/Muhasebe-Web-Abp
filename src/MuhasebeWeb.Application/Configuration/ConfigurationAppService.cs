﻿using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MuhasebeWeb.Configuration.Dto;

namespace MuhasebeWeb.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MuhasebeWebAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

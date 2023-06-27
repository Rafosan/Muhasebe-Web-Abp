using Abp.Application.Services.Dto;

namespace MuhasebeWeb.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}


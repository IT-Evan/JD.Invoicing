using Abp.Application.Services.Dto;

namespace JD.Invoicing.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}


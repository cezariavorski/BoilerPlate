using Abp.AutoMapper;
using BoilerPlate.Sessions.Dto;

namespace BoilerPlate.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
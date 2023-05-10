using System.Threading.Tasks;
using Abp.Application.Services;
using BoilerPlate.Authorization.Accounts.Dto;

namespace BoilerPlate.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

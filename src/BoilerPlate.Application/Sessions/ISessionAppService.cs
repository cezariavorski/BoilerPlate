using System.Threading.Tasks;
using Abp.Application.Services;
using BoilerPlate.Sessions.Dto;

namespace BoilerPlate.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

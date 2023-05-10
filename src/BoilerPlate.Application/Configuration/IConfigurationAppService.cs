using System.Threading.Tasks;
using Abp.Application.Services;
using BoilerPlate.Configuration.Dto;

namespace BoilerPlate.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
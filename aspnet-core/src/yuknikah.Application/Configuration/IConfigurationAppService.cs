using System.Threading.Tasks;
using yuknikah.Configuration.Dto;

namespace yuknikah.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

using System.Threading.Tasks;
using Abp.Application.Services;
using yuknikah.Sessions.Dto;

namespace yuknikah.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

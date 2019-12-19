using System.Threading.Tasks;
using Abp.Application.Services;
using yuknikah.Authorization.Accounts.Dto;

namespace yuknikah.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

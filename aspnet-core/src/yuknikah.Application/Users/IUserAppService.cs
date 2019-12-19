using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using yuknikah.Roles.Dto;
using yuknikah.Users.Dto;

namespace yuknikah.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}

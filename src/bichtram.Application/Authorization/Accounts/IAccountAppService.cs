using System.Threading.Tasks;
using Abp.Application.Services;
using bichtram.Authorization.Accounts.Dto;

namespace bichtram.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
